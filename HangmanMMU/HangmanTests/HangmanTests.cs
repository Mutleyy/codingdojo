using HangmanMMU;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HangmanTests
{
    [TestClass]
    public class HangmanTests
    {
        [DataTestMethod]
        [DataRow("---------", 'A')]
        [DataRow("-E-E---E-", 'E')]
        [DataRow("D--------", 'D')]
        [DataRow("--V------", 'V')]
        [DataRow("----L----", 'L')]
        [DataRow("-----O---", 'O')]
        [DataRow("------P--", 'P')]
        [DataRow("--------R", 'R')]
        [DataRow("---------", 'a')]
        [DataRow("-E-E---E-", 'e')]
        [DataRow("D--------", 'd')]
        [DataRow("--V------", 'v')]
        public void CheckThatFutReturnsCorrectStringOneLetter(string expected, char letter)
        {
            const string developer = "DEVELOPER";
            var hangman = new Hangman(developer);

            var a = hangman.Guess(letter);
            var comp = string.Compare(expected, a, false);

            hangman = new Hangman(developer);
            Assert.AreEqual(expected, hangman.Guess(letter));
        }

        [TestMethod]
        public void CheckThatReturnsCorrectWholeWork()
        {
            const string developer = "DEVELOPER";
            var hangman = new Hangman(developer);

            Assert.AreEqual("D--------", hangman.Guess('D'));
            Assert.AreEqual("DE-E---E-", hangman.Guess('E'));
            Assert.AreEqual("DEVE---E-", hangman.Guess('V'));
            Assert.AreEqual("DEVEL--E-", hangman.Guess('L'));
            Assert.AreEqual("DEVELO-E-", hangman.Guess('O'));
            Assert.AreEqual("DEVELOPE-", hangman.Guess('P'));
            Assert.AreEqual("DEVELOPER", hangman.Guess('R'));
        }
    }
}
