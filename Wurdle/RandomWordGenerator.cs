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
        List<string> wordsList = new List<string>();
        StringBuilder userWord = new StringBuilder("");
        StringBuilder wordColorCoordination = new StringBuilder("");
        public void readList()
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
                chooseCorrectWord(wordsList, randomNum);

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Wurdle Word List Not Found.");
            }
        }

        private void chooseCorrectWord(List<string> wordsList, Random randomNum)
        {
            int winningWordIndexNum = randomNum.Next(0, wordsList.Count);
            winningWord = wordsList[winningWordIndexNum].ToUpper();
        }

        public int buildStringAndMatch(string currentLetter, int numOfCols)
        {
            userWord.Append(currentLetter);
            if (userWord.Length == numOfCols)
            {
                bool wordCheck = checkIfInWordList(userWord.ToString());
                if (wordCheck == false)
                {
                    userWord.Clear();
                    return 0;
                }
            }
            return 1;
        }
        private bool checkIfInWordList(string currentUserWord) 
        {
            if (wordsList.Contains(currentUserWord.ToLower())) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        public string checkUserWordAgainstWinner() 
        {
            wordColorCoordination.Clear();
            MessageBox.Show(winningWord.ToString());
            for(int i = 0; i < winningWord.Length; i++) 
            {
                if (winningWord[i] == userWord[i])
                {
                    wordColorCoordination.Append("G");
                }
                else if (winningWord.Contains(userWord[i])) 
                {
                    wordColorCoordination.Append("Y");
                }
                else 
                {
                    wordColorCoordination.Append("R");
                }
            }
            userWord.Clear();
            return wordColorCoordination.ToString();
        }
    }
}
