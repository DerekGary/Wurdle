using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wurdle
{
    class RandomWordGenerator
    {
        private string? winningWord;
        private bool firstRunCheck = true;
        private List<string> wordsList = new List<string>();
        StringBuilder userWord = new StringBuilder("");
        StringBuilder wordColorCoordination = new StringBuilder("");
        public void ReadList()
        {
            Random randomNum = new Random();
            try
            {
                StreamReader reader = new StreamReader("wordle-answers-alphabetical.txt");
                while (!reader.EndOfStream)
                {
                    string[] data = reader.ReadLine().Split(',');
                    wordsList.AddRange(data);
                }
                ChooseCorrectWord(wordsList, randomNum);

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Wurdle Word List Not Found.");
            }
        }

        private void ChooseCorrectWord(List<string> wordsList, Random randomNum)
        {
            int winningWordIndexNum = randomNum.Next(0, wordsList.Count);
            winningWord = wordsList[winningWordIndexNum].ToUpper();
        }

        public int BuildStringAndMatch(string currentLetter, int numOfCols)
        {
            userWord.Append(currentLetter);
            if (userWord.Length == numOfCols)
            {
                bool wordCheck = CheckIfInWordList(userWord.ToString());
                if (wordCheck == false)
                {
                    userWord.Clear();
                    return 0;
                }
                else if (wordCheck == true && userWord.ToString().Contains(winningWord.ToString())) 
                {
                    MessageBox.Show("Congratulations, you've won.");
                    userWord.Clear();
                }
                else 
                {
                    userWord.Clear();
                }
            }
            return 1;
        }
        private bool CheckIfInWordList(string currentUserWord) 
        {
            if (wordsList.Contains(currentUserWord.ToLower())) 
            {
                return true;
            }
            else 
            {
                MessageBox.Show(currentUserWord + " is not a valid word.");
                return false;
            }
        } 
        public string CheckLetterAgainstWinner(string userInput, int currentColNum) 
        {
            if (firstRunCheck == true) 
            {
                ReadList();
                MessageBox.Show(winningWord);
                firstRunCheck = false;
            }
            if (userInput == winningWord[currentColNum].ToString())
            {
                return "G";
            }
            else if (winningWord.Contains(userInput))
            {
                return "Y";
            }
            else 
            {
                return "R";
            }
        }
    
    }
}
