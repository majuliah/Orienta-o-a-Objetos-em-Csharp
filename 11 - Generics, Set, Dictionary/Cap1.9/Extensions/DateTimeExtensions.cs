using System.Globalization;

namespace System
{
    public static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObject)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObject);

            if (duration.TotalHours < 24)
            {
                return ($"{duration.TotalHours.ToString($"F1", CultureInfo.InvariantCulture)} hours");
            }
            else
            {
                return ($"{duration.TotalDays.ToString($"F1", CultureInfo.InvariantCulture)} days");
            }
        }
    }
}