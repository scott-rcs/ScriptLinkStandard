﻿using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static OptionObject SetFieldObjects(IOptionObject optionObject, string fieldAction, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject.ToOptionObject2(), fieldAction, fieldObjects).ToOptionObject();
        }
        public static OptionObject SetFieldObjects(IOptionObject optionObject, string fieldAction, List<string> fieldNumbers)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject.ToOptionObject2(), fieldAction, fieldNumbers).ToOptionObject();
        }

        public static OptionObject2 SetFieldObjects(IOptionObject2 optionObject, string fieldAction, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            List<string> fieldNumbers = GetFieldNumbersToSet(fieldObjects);
            return SetFieldObjects(optionObject, fieldAction, fieldNumbers);
        }
        public static OptionObject2 SetFieldObjects(IOptionObject2 optionObject2, string fieldAction, List<string> fieldNumbers)
        {
            if (optionObject2 == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject2");
            if (optionObject2.Forms == null || optionObject2.Forms.Count == 0)
                throw new System.ArgumentException("There are no FormObjects in this OptionObject.");
            if (fieldAction == null || fieldAction == "")
                throw new System.ArgumentException("No FieldAction has been identified.");
            if (fieldNumbers == null || fieldNumbers.Count == 0)
                throw new System.ArgumentException("No FieldObjects have been identified to disable.");

            List<string> fieldsToSet = new List<string>();
            foreach (string fieldNumber in fieldNumbers)
            {
                if (IsFieldPresent(optionObject2, fieldNumber))
                    fieldsToSet.Add(fieldNumber);
            }
            if (fieldsToSet.Count == 0)
                throw new System.ArgumentException("None of the identified FieldsObjects were found in this OptionObject.");

            int formErrors = 0;
            for (int i = 0; i < optionObject2.Forms.Count; i++)
            {
                try
                {
                    optionObject2.Forms[i] = SetFieldObjects(optionObject2.Forms[i], fieldAction, fieldsToSet);
                }
                catch (Exception)
                {
                    // The FieldObjects to disable may not be present on each FormObject
                    formErrors++;
                }
            }
            if (formErrors == optionObject2.Forms.Count)
                throw new System.ArgumentException("None of the identified FieldsObjects were able to be disabled in " + optionObject2.Forms.Count.ToString() + " FormObjects");

            return (OptionObject2)optionObject2;
        }

        public static FormObject SetFieldObjects(IFormObject formObject, string fieldAction, List<string> fieldNumbers)
        {
            if (formObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "formObject");
            if (formObject.CurrentRow == null)
                throw new System.ArgumentException("The FormObject does not contain a CurrentRow.", "formObject");
            if (fieldAction == null || fieldAction == "")
                throw new System.ArgumentException("No FieldAction has been identified.");
            if (fieldNumbers == null || fieldNumbers.Count == 0)
                throw new System.ArgumentException("Parameter cannot be null or empty.", "fieldNumbers");

            List<string> fieldsToSet = new List<string>();
            foreach (string fieldNumber in fieldNumbers)
            {
                if (IsFieldPresent(formObject, fieldNumber))
                    fieldsToSet.Add(fieldNumber);
            }
            if (fieldsToSet.Count == 0)
                throw new System.ArgumentException("None of the identified FieldsObjects were found in this FormObject.");

            formObject.CurrentRow = SetFieldObjects(formObject.CurrentRow, fieldAction, fieldsToSet);

            if (formObject.MultipleIteration)
            {
                for (int i = 0; i < formObject.OtherRows.Count; i++)
                {
                    formObject.OtherRows[i] = SetFieldObjects(formObject.OtherRows[i], fieldAction, fieldsToSet);
                }
            }
            return (FormObject)formObject;
        }

        public static RowObject SetFieldObjects(IRowObject rowObject, string fieldAction, List<string> fieldNumbers)
        {
            if (rowObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "rowObject");
            if (fieldAction == null || fieldAction == "")
                throw new System.ArgumentException("No FieldAction has been identified.");
            if (fieldNumbers == null || fieldNumbers.Count == 0)
                throw new System.ArgumentException("Parameter cannot be null or empty.", "fieldNumbers");

            List<string> fieldsToSet = new List<string>();
            foreach (string fieldNumber in fieldNumbers)
            {
                if (IsFieldPresent(rowObject, fieldNumber))
                    fieldsToSet.Add(fieldNumber);
            }
            if (fieldsToSet.Count == 0)
                throw new System.ArgumentException("None of the identified FieldsObjects were found in this RowObject.");

            foreach (var fieldObject in rowObject.Fields)
            {
                if (fieldsToSet.Contains(fieldObject.FieldNumber))
                {
                    switch (fieldAction)
                    {
                        case "DISABLED":
                            fieldObject.SetAsDisabled();
                            rowObject.RowAction = "EDIT";
                            break;
                        case "ENABLED":
                            fieldObject.SetAsEnabled();
                            rowObject.RowAction = "EDIT";
                            break;
                        case "LOCKED":
                            fieldObject.SetAsLocked();
                            rowObject.RowAction = "EDIT";
                            break;
                        case "MODIFIED":
                            fieldObject.SetAsModified();
                            rowObject.RowAction = "EDIT";
                            break;
                        case "OPTIONAL":
                            fieldObject.SetAsOptional();
                            rowObject.RowAction = "EDIT";
                            break;
                        case "REQUIRED":
                            fieldObject.SetAsRequired();
                            rowObject.RowAction = "EDIT";
                            break;
                        case "UNLOCKED":
                            fieldObject.SetAsUnlocked();
                            rowObject.RowAction = "EDIT";
                            break;
                        default:
                            break;
                    }
                }
            }
            return (RowObject)rowObject;
        }

        private static List<string> GetFieldNumbersToSet(List<FieldObject> fieldObjects)
        {
            if (fieldObjects == null || fieldObjects.Count == 0)
                throw new System.ArgumentException("Parameter cannot be null or empty.", "fieldObjects");
            List<string> fieldNumbers = new List<string>();
            foreach (var fieldObject in fieldObjects)
            {
                fieldNumbers.Add(fieldObject.FieldNumber);
            }
            return fieldNumbers;
        }
    }
}
