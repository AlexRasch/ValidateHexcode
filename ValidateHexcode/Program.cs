namespace ValidateHexcode
{
    public static  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


        public static bool IsValidHexCode(string inputHexCode)
        {
            // Validate length and that '#' exist
            char[] chars = inputHexCode.ToCharArray();
            if (chars[0] != '#')
                return false;

            int inputLength = inputHexCode.Length;
            if(inputLength != 4 && inputLength != 7)
                return false;

            for (int i = 1; i < chars.Length; i++)
            {
                if (!IsValidHexChar(chars[i]))
                    return false;
                
            }

            return true;
        }

        private static bool IsValidHexChar(char c)
        {
            if (c >= '0' && c <= '9' || c >= 'A' && c <= 'F' || c >= 'a' && c <= 'f')
                return true;

            return false;
        }
    }
}