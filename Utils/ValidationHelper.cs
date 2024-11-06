namespace Livraria.Utils
{
    public static class ValidationHelper
    {
        public static bool IsNumeric(string value)
        {
            return !string.IsNullOrWhiteSpace(value) && int.TryParse(value, out _);
        }

        public static bool IsString(string value)
        {
            return !string.IsNullOrWhiteSpace(value) || !string.IsNullOrEmpty(value);
        }
    }
}