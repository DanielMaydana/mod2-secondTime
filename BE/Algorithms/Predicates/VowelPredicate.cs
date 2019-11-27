using Algorithms;
using System;

namespace Predicates
{
    public class VowelPredicate : IPredicate
    {
        private char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        public bool Evaluate(object obj)
        {
            char letter = (char)obj;

            return Array.Exists(vowels, single => single == letter);
        }
    }
}
