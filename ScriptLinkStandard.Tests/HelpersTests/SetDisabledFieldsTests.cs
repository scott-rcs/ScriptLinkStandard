﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Objects;
using System;
using System.Collections.Generic;

namespace ScriptLinkStandard.Tests.HelpersTests
{
    [TestClass]
    public class SetDisabledFieldsTests
    {
        [TestMethod]
        public void SetDisabledFields_OptionObject_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            optionObject.SetDisabledFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetDisabledFields_OptionObject_Null_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = null;
            optionObject.SetDisabledFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledFields_OptionObject_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            optionObject.SetDisabledFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject_Helper_ListFieldObjects()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                fieldObject
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            ScriptLinkHelpers.SetDisabledFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledFields_OptionObject_Null_Helper_ListFieldObjects()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                fieldObject
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = null;
            ScriptLinkHelpers.SetDisabledFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledFields_OptionObject_Helper_ListFieldObjects_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<FieldObject> fieldObjects = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            ScriptLinkHelpers.SetDisabledFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            ScriptLinkHelpers.SetDisabledFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledFields_OptionObject_Null_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = null;
            ScriptLinkHelpers.SetDisabledFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledFields_OptionObject_Helper_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            ScriptLinkHelpers.SetDisabledFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject2_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            optionObject.SetDisabledFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetDisabledFields_OptionObject2_Null_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = null;
            optionObject.SetDisabledFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledFields_OptionObject2_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            optionObject.SetDisabledFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject2_Helper_ListFieldObjects()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                fieldObject
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            ScriptLinkHelpers.SetDisabledFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledFields_OptionObject2_Null_Helper_ListFieldObjects()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                fieldObject
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = null;
            ScriptLinkHelpers.SetDisabledFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledFields_OptionObject2_Helper_ListFieldObjects_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<FieldObject> fieldObjects = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            ScriptLinkHelpers.SetDisabledFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject2_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            ScriptLinkHelpers.SetDisabledFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledFields_OptionObject2_Null_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = null;
            ScriptLinkHelpers.SetDisabledFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledFields_OptionObject2_Helper_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            ScriptLinkHelpers.SetDisabledFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject2015_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            optionObject.SetDisabledFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetDisabledFields_OptionObject2015_Null_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = null;
            optionObject.SetDisabledFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledFields_OptionObject2015_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            optionObject.SetDisabledFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject2015_Helper_ListFieldObjects()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                fieldObject
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            ScriptLinkHelpers.SetDisabledFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledFields_OptionObject2015_Null_Helper_ListFieldObjects()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                fieldObject
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = null;
            ScriptLinkHelpers.SetDisabledFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledFields_OptionObject2015_Helper_ListFieldObjects_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<FieldObject> fieldObjects = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            ScriptLinkHelpers.SetDisabledFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject2015_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            ScriptLinkHelpers.SetDisabledFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledFields_OptionObject2015_Null_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = null;
            ScriptLinkHelpers.SetDisabledFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledFields_OptionObject2015_Helper_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            ScriptLinkHelpers.SetDisabledFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_FormObject_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            formObject.SetDisabledFields(fieldNumbers);
            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetDisabledFields_FormObject_Null_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = null;
            formObject.SetDisabledFields(fieldNumbers);
            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledFields_FormObject_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            formObject.SetDisabledFields(fieldNumbers);
            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_FormObject_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            ScriptLinkHelpers.SetDisabledFields(formObject, fieldNumbers);
            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledFields_FormObject_Null_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = null;
            ScriptLinkHelpers.SetDisabledFields(formObject, fieldNumbers);
            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledFields_FormObject_Helper_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            ScriptLinkHelpers.SetDisabledFields(formObject, fieldNumbers);
            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_RowObject_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            rowObject.SetDisabledFields(fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetDisabledFields_RowObject_Null_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = null;
            rowObject.SetDisabledFields(fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledFields_RowObject_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            rowObject.SetDisabledFields(fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_RowObject_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            ScriptLinkHelpers.SetDisabledFields(rowObject, fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledFields_RowObject_Null_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = null;
            ScriptLinkHelpers.SetDisabledFields(rowObject, fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledFields_RowObject_Helper_ListFieldNumbers_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            ScriptLinkHelpers.SetDisabledFields(rowObject, fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
        }
    }
}
