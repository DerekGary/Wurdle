using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wurdle
{
    internal class InputHandler
    {
        int row = 0;
        int col = 0;
        public IEnumerable<Control>? Controls { get; private set; }
        public void OnScreenKeyboardClick(object sender, EventArgs e)
        {
            Button buttonClicked = (Button)sender;
                if (buttonClicked.Text == "<=" && col >= 0)
                {
                    eraseCurrentLetter();
                }
                else if (buttonClicked.Text == "ENTER")
                {
                    checkCurrentLetter();
                }
                else if (col < 5 && row < 6)
                {
                    wurdleForm.wurdleGrid[row, col].Text = buttonClicked.Text;
                    col++;
                }
        }
        private void eraseCurrentLetter()
        {
            if (col != 0)
            {
                col--;
                wurdleForm.wurdleGrid[row, col].Text = " ";
            }
        }
        private void checkCurrentLetter()
        {
            if (col == 5)
            {
                row++;
                col = 0;
            }
            if (row == 6) 
            {
                MessageBox.Show("Game Over!");
            }
        }
    }
}
