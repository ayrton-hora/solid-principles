namespace SOLID_Principles.ExtensionMethods
{
    public static class StringExtension
    {
        public static string UpperStringFirstLetter(this string value)
        {
            if (value.Length > 0)
            {
                char[] chars = value.ToCharArray();
                chars[0] = char.ToUpper(chars[0]);
                return new string(chars);
            }

            return value;
        }
    }
}
