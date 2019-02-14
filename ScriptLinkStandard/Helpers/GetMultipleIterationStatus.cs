﻿using ScriptLinkStandard.Interfaces;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Returns whether a <see cref="IFormObject"/> in the <see cref="IOptionObject"/> is Multiple Iteration by specified FormId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <returns></returns>
        public static bool GetMultipleIterationStatus(IOptionObject optionObject, string formId)
        {
            if (optionObject == null)
                throw new System.NullReferenceException("Parameter 'optionObject' cannot be null.");
            return GetMultipleIterationStatus(optionObject.ToOptionObject2015(), formId);
        }
        /// <summary>
        /// Returns whether a <see cref="IFormObject"/> in the <see cref="IOptionObject2"/> is Multiple Iteration by specified FormId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <returns></returns>
        public static bool GetMultipleIterationStatus(IOptionObject2 optionObject, string formId)
        {
            if (optionObject == null)
                throw new System.NullReferenceException("Parameter 'optionObject' cannot be null.");
            return GetMultipleIterationStatus(optionObject.ToOptionObject2015(), formId);
        }
        /// <summary>
        /// Returns whether a <see cref="IFormObject"/> in the <see cref="IOptionObject2015"/> is Multiple Iteration by specified FormId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <returns></returns>
        public static bool GetMultipleIterationStatus(IOptionObject2015 optionObject, string formId)
        {
            if (optionObject == null)
                throw new System.NullReferenceException("Parameter 'optionObject' cannot be null.");
            if (formId == null || formId == "")
                throw new System.ArgumentException("Parameter cannot be null or blank.", "formId");
            if (optionObject.Forms == null)
                throw new System.ArgumentException("The OptionObject does not contain any Forms.");
            foreach (var formObject in optionObject.Forms)
            {
                if (formObject.FormId == formId)
                {
                    return GetMultipleIterationStatus(formObject);
                }
            }
            throw new System.ArgumentException("The FormObject with FormId " + formId + " does not exist in this OptionObject.");
        }
        /// <summary>
        /// Returns whether a <see cref="IFormObject"/> is Multiple Iteration.
        /// </summary>
        /// <param name="formObject"></param>
        /// <returns></returns>
        public static bool GetMultipleIterationStatus(IFormObject formObject)
        {
            if (formObject == null)
                throw new System.NullReferenceException("Parameter 'formObject' cannot be null.");
            return formObject.MultipleIteration;
        }
    }
}
