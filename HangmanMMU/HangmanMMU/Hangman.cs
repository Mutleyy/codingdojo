using System;
using System.Collections.Generic;

namespace HangmanMMU
{
    public class Hangman
    {
        private string m_secret;
        private string m_secretMasked;

        public Hangman(string secret)
        {
            m_secret = secret ?? throw new ArgumentException(nameof(secret));
            m_secret = m_secret.ToUpper();

            FillMasked();
        }

        public string Guess(char letter)
        {
            var letterUpper = char.ToUpper(letter);

            var occurences = FindOccurences(letterUpper);

            foreach(var pos in occurences)
            {
                m_secretMasked = m_secretMasked.Insert(pos, letterUpper.ToString()).Remove(pos+1,1);
            }

            return m_secretMasked;
        }

        private IEnumerable<int> FindOccurences(char letter)
        {
            var positions = new List<int>();

            for (int i = 0; i < m_secret.Length; i++)
            {
                if (m_secret[i] == letter)
                {
                    positions.Add(i);
                }
            }
            return positions;
        }

        private void FillMasked()
        {
            var length = m_secret.Length;

            while (length > 0)
            {
                m_secretMasked += '-';
                length--;
            }
        }

    }
}
