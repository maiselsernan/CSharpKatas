using System.Text;

namespace CSharpKatas
{
    //https://www.codewars.com/kata/517abf86da9663f1d2000003/train/csharp
    public class ToCamelCaseKata
    {
        public static string ToCamelCase(string str)
        {
            var tempStr = new StringBuilder();
            var nextUpper = false;
            foreach (var item in str)
            {
                if (item == '-' || item == '_')
                {
                    nextUpper = true;
                }
                else if (nextUpper)
                {
                    tempStr.Append(char.ToUpper(item));
                    nextUpper = false;
                }
                else
                {
                    tempStr.Append(item);
                }
            }

            str = tempStr.ToString();

            return str;
        }
    }
}
