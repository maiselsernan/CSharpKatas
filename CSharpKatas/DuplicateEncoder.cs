//https://www.codewars.com/kata/54b42f9314d9229fd6000d9c/train/csharp
using System.Text;

namespace CSharpKatas
{
    public class DuplicateEncoder
    {
        public static string DuplicateEncode(string word)
        {
            StringBuilder temp = new StringBuilder();
            foreach (var c in word.ToLower())
            {
                if (word.Count(x=> char.ToLower(x) == char.ToLower(c)) > 1)
                {
                    temp.Append(')');
                }
                else
                {
                    temp.Append('(');
                }
            }
            word = temp.ToString();
            return word;
        }
    }
}
