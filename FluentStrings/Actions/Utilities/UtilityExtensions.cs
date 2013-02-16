﻿using System;
using dokas.FluentStrings.Actions.Utilities;

namespace dokas.FluentStrings
{
    public static class UtilityExtensions
    {
        /// <summary>
        /// Checks whether string is empty or not
        /// N.B.: Equivalent of String.IsNullOrEmpty method
        /// </summary>
        /// <param name="source">Target string for examination</param>
        /// <returns>True if string is null or empty, otherwise false</returns>
        public static IsEmptyString IsEmpty(this string source)
        {
            return new IsEmptyString(source);
        }

        /// <summary>
        /// Adds validation whether string consists only of white-space characters
        /// N.B.: Equivalent of String.IsNullOrWhiteSpace method
        /// </summary>
        /// <returns>True if string consists only of white-space characters, otherwise false</returns>
        public static IsEmptyOrWhiteSpaceString OrWhiteSpace(this IsEmptyString source)
        {
            return new IsEmptyOrWhiteSpaceString(source);
        }

        /// <summary>
        /// Replaces the format item in a template with the text equivalent
        /// of the value specified in a values array.
        /// </summary>
        /// <param name="template">Formating template</param>
        /// <param name="values">Values for fomating template</param>
        public static string Format(this string template, params object[] values)
        {
            return String.Format(template, values);
        }
    }
}
