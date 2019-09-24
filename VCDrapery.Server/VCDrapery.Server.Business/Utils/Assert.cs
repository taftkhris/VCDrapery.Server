using System;

namespace VCDrapery.Server.Business.Utils
{
    public static class Assert
    {
        public static void ArgNotNull(string paramName, object paramValue)
        {
            if (paramValue == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        public static void ArgNotEmpty(string paramName, string paramValue)
        {
            if (string.IsNullOrWhiteSpace(paramValue))
            {
                throw new ArgumentException($"Please provide a valid value for {paramName}");
            }
        }

        public static void ArgValid(bool condition, string message)
        {
            if (!condition)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
