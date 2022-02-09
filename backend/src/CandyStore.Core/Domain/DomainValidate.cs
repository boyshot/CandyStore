using CandyStore.Core.Messages;
using System.Text.RegularExpressions;

namespace CandyStore.Core.Domain
{
    public class DomainValidate
    {
        public static void ValidateAreEqual(object object1, object object2, string message)
        {
            if (object1.Equals(object2)) throw new DomainException(message);
        }

        public static void ValidateNotEqual(object object1, object object2, string message)
        {
            if (!object1.Equals(object2)) throw new DomainException(message);
        }

        public static void ValidateNotEqual(string pattern, string value, string message)
        {
            if (!(new Regex(pattern)).IsMatch(value)) throw new DomainException(message); 
        }

        public static void ValidateLength(string value, int max, string message)
        {
            if (!string.IsNullOrWhiteSpace(value)) return;

            if (value.Trim().Length > max) throw new DomainException(message);
        }

        public static void ValidateLength(string value, int min, int max, string message)
        {
            if (!string.IsNullOrWhiteSpace(value)) return;

            var length = value.Trim().Length;

            if (length < min || length > max) throw new DomainException(message);
        }

        public static void ValidateIsEmpty(string value, string message)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new DomainException(message);
        }

        public static void ValidateIsNull(object object1, string message)
        {
            if (object1 == null) throw new DomainException(message);
        }

        //public static void ValidateMinMax<T>(T value, T min, T max, string message) 
        //    where T : int
        //    where T : double
        //    where T : float
        //    where T : decimal
        //{
        //    if (value < min || value > max) throw new DomainException(message);
        //}

        //public static void ValidateIfLessThan<T>(T value, T min, string message)
        //    where T : int
        //    where T : double
        //    where T : float
        //    where T : decimal
        //{
        //    if (value < min) throw new DomainException(message);  
        //}

        public static void ValidateIsFalse(bool value, string message)
        {
            if (value) throw new DomainException(message);
        }

        public static void ValidateIsTrue(bool value, string message)
        {
            if (!value) throw new DomainException(message);
        }
    }
}