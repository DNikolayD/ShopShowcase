using System.Text;

namespace ShopShowcase.Common.Handlers.Specific
{
    public static class ErrorHandler
    {
        public static string CreateError(string condition, string objectName, string propertyName)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{propertyName} of {objectName} has to {condition}");
            return stringBuilder.ToString();
        }

        public static string CreateCondition(bool isString, string type, params string[] values)
        {
            var stringBuilder = new StringBuilder();
            if (values.Length > 0)
            {
                stringBuilder.AppendLine(isString ? $"{type} {values[0]} symbols" : $"{type} {values[0]}");
            }
            else
            {
                stringBuilder.AppendLine(type);
            }
            return stringBuilder.ToString();
        }
    }
}
