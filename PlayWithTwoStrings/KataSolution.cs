using System.Linq;

namespace PlayWithTwoStrings
{
    public class KataSolution
    {
        private string _outputString;

        public string WorkOnStrings(string firstString, string secondString)
        {
            _outputString = "";
            var firstCharArray = firstString.ToCharArray();
            var secondCharArray = secondString.ToCharArray();
            foreach (var singleChar in firstCharArray)
            {
                var swapCount = secondCharArray.Count(x => char.ToLower(x) == char.ToLower(singleChar)) % 2;
                if (swapCount == 1)
                {
                    _outputString += SwapCase(singleChar);
                }
                else
                {
                    _outputString += singleChar.ToString();
                }
            }
            foreach (var singleChar in secondCharArray)
            {
                var swapCount = firstCharArray.Count(x => char.ToLower(x) == char.ToLower(singleChar)) % 2;
                if (swapCount == 1)
                {
                    _outputString += SwapCase(singleChar);
                }
                else
                {
                    _outputString += singleChar.ToString();
                }
            }
            return _outputString;
        }

        private string SwapCase(char singleChar)
        {
            return char.IsUpper(singleChar)
                ? char.ToLower(singleChar).ToString()
                : char.ToUpper(singleChar).ToString();
        }
    }
}