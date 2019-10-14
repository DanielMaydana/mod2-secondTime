using System;

namespace Models
{
    public class FizzBuzzGenerator
    {
        private const int FizzValue = 3;
        private const int BuzzValue = 5;
        private const int ShazamValue = 7;
        private const string FizzWord = "Fizz";
        private const string BuzzWord = "Buzz";
        private const string ShazamWord = "Shazam";
        private const string EmptyWord = "";

        public string Generate(int number)
        {
            string word = EmptyWord;
            ValidateNumber(number);
            word += IsFizzMultiple(number);
            word += IsBuzzMultiple(number);
            word += IsShazamMultiple(number);


            if (word == EmptyWord) word = number.ToString();

            return word;
        }

        private string IsFizzMultiple(int number)
        {
            return number != 0 && number % FizzValue == 0 ? FizzWord : EmptyWord;
        }

        private string IsBuzzMultiple(int number)
        {
            return number != 0 && number % BuzzValue == 0 ? BuzzWord : EmptyWord;
        }

        private string IsShazamMultiple(int number)
        {
            return number != 0 && number % ShazamValue == 0 ? ShazamWord : EmptyWord;
        }
        private void ValidateNumber(int number)
        {
            if (number < 0) throw new ArgumentException("Can't generate word for negative numbers");
        }
    }
}
