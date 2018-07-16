using System;

namespace FizzBuzz.Library
{
    public class FizzBuzzService
    {
        public string Print(int n) {
            if (IsDivisibleByFive(n) && IsDivisibleByThree(n)) {
                return "FizzBuzz";
            }
            else if (IsDivisibleByFive(n)) {
                return "Buzz";
            }
            else if (IsDivisibleByThree(n)) {
                return "Fizz";
            } else {
                return n.ToString();
            }
        }

        // refactor and extract repeated code
        private bool IsDivisibleByThree(int n) {
            return n % 3 == 0;
        }

        private bool IsDivisibleByFive(int n) {
            return n % 5 == 0;
        }
    }
}
