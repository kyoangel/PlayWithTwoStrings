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
            SwapCaseByAnother(firstCharArray, secondCharArray);
            SwapCaseByAnother(secondCharArray, firstCharArray);
            return _outputString;
        }

        private void SwapCaseByAnother(char[] firstCharArray, char[] secondCharArray)
        {
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
        }

        private string SwapCase(char singleChar)
        {
            return char.IsUpper(singleChar)
                ? char.ToLower(singleChar).ToString()
                : char.ToUpper(singleChar).ToString();
        }
    }
}