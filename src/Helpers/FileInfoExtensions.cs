using System;
using System.IO;

namespace AppWebView.Helpers
{
    /// <summary />
    public static class FileInfoExtensions
    {
        /// <summary />
        public static string NameWithoutExtension(this FileInfo file)
        {
            string name = file.Name;
            string extension = file.Extension;

            return name.Left(name.Length - extension.Length);
        }

        /// <summary>
        /// Returns the first N characters.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string Left(this string value, int length)
        {
            if (value == null)
                return string.Empty;

            if (length <= 0)
                return string.Empty;
            if (length >= value.Length)
                return value;
            else
                return value.Substring(0, length);
        }
    }
}
