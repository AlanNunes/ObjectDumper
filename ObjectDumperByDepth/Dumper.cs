using System;
using System.Reflection;

namespace ObjectDumperByDepth
{
    class Dumper
    {
        public static void Dump(object obj, ref string result, int depth, int tabIdentation = 0)
        {
            if (depth == 0)
            {
                return;
            }
            Type type = obj.GetType();
            result += GetTabIdentation(tabIdentation) + type.FullName + " {\n";
            foreach (PropertyInfo property in type.GetProperties())
            {
                if (property.CanRead && !property.PropertyType.FullName.StartsWith("Microsoft."))
                {
                    object propertyType = property.PropertyType.FullName;
                    object propertyName = property.Name;
                    object propertyValue = property.GetValue(obj);
                    result += GetTabIdentation(tabIdentation) + "\t" + propertyType.ToString();
                    result += " " + (propertyName is null ? "null" : propertyName.ToString());
                    result += " = " + (propertyValue is null ? "null" : propertyValue.ToString());
                    result += GetTabIdentation(tabIdentation) + "\n";
                }
                Dump(property, ref result, depth - 1, tabIdentation + 1);
            }
            result += GetTabIdentation(tabIdentation) + "\n}";
        }

        private static string GetTabIdentation(int amount)
        {
            string result = "";
            for (int i = 0; i < amount; i++)
            {
                result += "\t";
            }
            return result;
        }
    }
}
