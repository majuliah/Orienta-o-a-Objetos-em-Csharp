namespace System
{
    public static class StringExtensions
    {
        public static string Cut(this string thisObject, int count)
        {
            if (thisObject.Length <= count)
            {
                return thisObject;
            }
            else
            {
                return thisObject.Substring(0, count) + $"...";
            }
        }
    }
}