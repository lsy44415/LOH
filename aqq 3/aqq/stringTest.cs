using System;
using System.Text.RegularExpressions;

namespace aqq
{
    public static class StringTest
    {


        public static bool isEmail(this string text)
        {
            if (text.Length == 0)
                return false;
            
			string expression = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
			if (Regex.IsMatch(text, expression))
			{
                return true;
			}
            return false;
		}

		public static bool isNum(this string aString)
		{
            char[] ch = new char[aString.Length];
                ch = aString.ToCharArray();

            if (aString.Length == 0)
                return false;
            
			for (int i = 0; i < aString.Length; i++)
 {
				if (ch[i] < 48 || ch[i] > 57)
					return false;
			}
			return true;
		}

		public static bool isPost(this string aString)
		{
			char[] ch = new char[aString.Length];
			ch = aString.ToCharArray();

            if (aString.Length != 4)
                return false;

			for (int i = 0; i < aString.Length; i++)
			{
                if (ch[i] < 48 || ch[i] > 57)
                    return false;
			}
			return true;
		}
    }
}
