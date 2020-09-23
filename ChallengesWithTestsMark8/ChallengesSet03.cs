using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int count = 0;
            foreach (var x in numbers)
            {

                if (Math.Abs(x) % 2 == 1)
                {
                    count++;
                }
            }
            return count % 2 == 1;

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = false; bool hasLower = false; bool hasDigit = false;
            for (int i = 0; i < password.Length && !(hasUpper && hasLower && hasDigit); i++)
            {
                char c = password[i];
                if (!hasUpper) hasUpper = char.IsUpper(c);
                if (!hasLower) hasLower = char.IsLower(c);
                if (!hasDigit) hasDigit = char.IsDigit(c);
            }
            return hasUpper && hasLower && hasDigit;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var answer = new int[50];
            int z = 0;
            for (int i = 1; i < 100; i += 2)
            {
                answer[z] = i;
                z++;
            }
            return answer;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
