using System;
using System.Collections.Generic;
using System.Reflection;

namespace BankFileParsers
{
    public static class ListToCsv
    {
        private static char _fieldSep = ',';
        private static char _fieldPrefix = '"';
        private static char _fieldPostfix = '"';
        private static bool _disabledPrePost; // = false;

        private static string PrePostFix(string item)
        {
            if (!_disabledPrePost)
            {
                return _fieldPrefix + item + _fieldPostfix;
            }
            return item;
        }

        public static string ExportToCsv<T>(this List<T> list, List<string> dictionaryKeys, List<string> fields)
        {
            if (fields == null) fields = new List<string>();
            var ret = "";
            var dict = new Dictionary<string, PropertyInfo>();
            var type = typeof (T);
            var header = string.Empty;

            foreach (var field in fields)
            {
                string head;
                var pi = type.GetProperty(field.Trim());
                if (pi != null)
                {
                    dict.Add(field, pi);
                    head = PrePostFix(field) + _fieldSep;
                }
                else
                    throw new Exception(string.Format("{0} is not a valid property of type: \"{1}\"", field, type.Name));

                header += head;
            }

            // Add the dictionaryKeys to the header now
            if (dictionaryKeys != null)
            {
                foreach (var key in dictionaryKeys)
                {
                    header += PrePostFix(key) + _fieldSep;
                }
            }

            ret += header.TrimEnd(_fieldSep);
            if (header != string.Empty)
                ret += Environment.NewLine;

            foreach (var item in list)
            {
                var row = string.Empty;
                foreach (var field in fields)
                {
                    // If the column is null, then enter a blank space
                    var obj = dict[field].GetValue(item, null);
                    if (obj != null)
                        row += PrePostFix(obj.ToString()) + _fieldSep;
                    else
                        row += _fieldSep;
                }
                // Get the fields that are dictionary objects
                if (dictionaryKeys != null)
                {
                    var dictionaries = new List<Dictionary<string, string>>();
                    var properties = type.GetProperties();
                    foreach (var property in properties)
                    {
                        if (!fields.Contains(property.Name))
                        {
                            var obj = property.GetValue(item, null);
                            if (obj is Dictionary<string, string>)
                            {
                                dictionaries.Add(obj as Dictionary<string, string>);
                            }
                        }
                    }

                    // now we need to get the dictionaryKey out of the dictionary object(s)
                    foreach (var key in dictionaryKeys)
                    {
                        foreach (var dictionary in dictionaries)
                        {
                            if (dictionary == null) continue;
                            if (dictionary.ContainsKey(key))
                            {
                                row += PrePostFix(dictionary[key]) + _fieldSep;
                            }
                        }
                    }
                }

                ret += row.TrimEnd(_fieldSep);
                if (row != string.Empty)
                    ret += Environment.NewLine;
            }
            return ret;
        }

        public static string ExportToCsv<T>(this List<T> list, List<string> dictionaryKeys = null)
        {
            var fields = new List<string>();
            var type = typeof (T);
            var props = type.GetProperties();
            foreach (var info in props)
            {
                var typeName = info.PropertyType.FullName;
                if (!typeName.Contains("Dictionary"))
                    fields.Add(info.Name);
            }

            return ExportToCsv(list, dictionaryKeys, fields);
        }

        public static void CsvFieldSeparator<T>(this List<T> list, char fieldSep)
        {
            _fieldSep = fieldSep;
        }

        public static void CsvFieldPrefix<T>(this List<T> list, char fieldPrefix)
        {
            _fieldPrefix = fieldPrefix;
        }

        public static void CsvFieldPostfix<T>(this List<T> list, char fieldPostfix)
        {
            _fieldPostfix = fieldPostfix;
        }

        public static void CsvFieldPrefixPostfix<T>(this List<T> list, char fieldPrefixPostfix)
        {
            _fieldPostfix = fieldPrefixPostfix;
            _fieldPrefix = fieldPrefixPostfix;
        }

        public static void CsvDisablePrefixPostFix<T>(this List<T> list)
        {
            _disabledPrePost = true;
        }
    }
}
