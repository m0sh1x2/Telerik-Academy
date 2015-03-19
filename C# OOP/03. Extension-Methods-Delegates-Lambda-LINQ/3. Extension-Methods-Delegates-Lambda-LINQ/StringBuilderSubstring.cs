namespace _3.Extension_Methods_Delegates_Lambda_LINQ
{
    using System;
    using System.Text;

    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder strBuilder, int index, int count)
        {
            string initalString = strBuilder.ToString();

            StringBuilder result = new StringBuilder(count);

            if (index < 0 || index > initalString.Length - 1)
            {
                throw new IndexOutOfRangeException("Starting index must be in the range [0, string.Length) and ");
            }

            if (count < 0 || index + count > initalString.Length - 1)
            {
                throw new ArgumentException("Count must be >= 0 and index + count must be < string.Length");
            }

            for (int i = index; i < index + count; i++)
            {
                result.Append(initalString[i]);
            }
            return result;

        }
    }
}
