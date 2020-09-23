using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }
            int answer = 0;
            for (int i = 0; i< numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    answer += numbers[i];
                }
                else
                {
                    answer -= numbers[i];
                }
            }
            return answer;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int answer = str1.Length;
            if (str2.Length<str1.Length)
            {
                answer = str2.Length;
            }
            if (str3.Length < answer)
            {
                answer = str3.Length;
            }
            if (str4.Length < answer)
            {
                answer = str4.Length;
            }
            return answer;
            
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int answer = number1;
            if (answer > number2)
            {
                answer = number2;
            }
            if (answer > number3)
            {
                answer = number3;
            }
            if (answer > number4)
            {
                answer = number4;
            }
            return answer;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength3 + sideLength1 > sideLength2;
        }

        public bool IsStringANumber(string input)
        {
            double x;
            return double.TryParse(input, out x);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            
            int count = 0;
            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    count++;
                }
            }
            return count > objs.Length / 2;
            //need help
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sumEvens = 0;
            int count = 0;
            for (int i = 0; i<numbers.Length; i++)
            {
                if (numbers[i]%2==0)
                {
                    sumEvens += numbers[i];
                    count++;
                }
               
            }
            if (count ==0)
            {
                return 0;
            }
            return (double)sumEvens / count;
        }

        public int Factorial(int number)
        {
            if (number< 0)
            {
                throw new ArgumentOutOfRangeException("needs to be a positive int");
            }
            int product = 1;
            for (int x = number; x !=0; x--)
            {
                product *= x;
            }
            return product;
        }
    }
}
