namespace Wurdle
{
    public partial class wurdleForm : Form
    {
        private static int numOfCols = 5;
        private static int numOfRows = 6;
        private int col = 0;
        private int row = 0;
        private int isAWord;
        private TextBox[,] wurdleGrid = new TextBox[numOfRows, numOfCols];
        private List<Button> buttonList = new List<Button>();
        private List<string> rowColorPattern = new List<string>();
        private readonly RandomWordGenerator randWord = new();

        public wurdleForm()
        {
            InitializeComponent();
            menuStrip1.Renderer = new CustomThemeRenderer();
            exitToolStripMenuItem.Click += (s, e) => this.Close();
            FormatUILayout();
            SubscribeOnScreenKeyboardButtons();
        }

        private void FormatUILayout()
        {
            wordleTextBox.Width = 64;
            wordleTextBox.Location = new Point(wordleTextBox.Location.X,
                wordleTextBox.Location.Y);
            wordleTextBox.Height = wordleTextBox.Width;
            wordleTextBox.Dock = DockStyle.None;
            InitializeWurdleGrid();
        }
        
        private void InitializeWurdleGrid()
        {
            int spaceBetweenBoxes = wordleTextBox.Size.Width + 4;
            for (int i = 0; i < wurdleGrid.GetLength(0); i++)
            {
                for (int j = 0; j < wurdleGrid.GetLength(1); j++)
                {
                    TextBox temp = new TextBox();
                    temp.Size = wordleTextBox.Size;
                    temp.MaxLength = 1;
                    temp.ForeColor = wordleTextBox.ForeColor;
                    temp.BackColor = wordleTextBox.BackColor;
                    temp.Font = wordleTextBox.Font;
                    temp.Text = wordleTextBox.Text;
                    temp.TextAlign = wordleTextBox.TextAlign;
                    temp.CharacterCasing = wordleTextBox.CharacterCasing;
                    temp.ReadOnly = wordleTextBox.ReadOnly;
                    temp.TabIndex = i * wurdleGrid.GetLength(1) + j;
                    temp.Dock = wordleTextBox.Dock;
                    if (i == 0 && j == 0)
                    {
                        temp.TextAlign = HorizontalAlignment.Center;
                        temp.Location = wordleTextBox.Location;
                        wurdleGrid[i, j] = temp;
                        this.Controls.Add(temp);
                    }
                    else if (j == 0)
                    {
                        temp.Location = new Point(wordleTextBox.Location.X,
                            wordleTextBox.Location.Y + (spaceBetweenBoxes * i));
                        wurdleGrid[i, j] = temp;
                        this.Controls.Add(temp);
                    }
                    else
                    {
                        temp.Location = new Point(wordleTextBox.Location.X + (spaceBetweenBoxes * j),
                            wordleTextBox.Location.Y + (spaceBetweenBoxes * i));
                        wurdleGrid[i, j] = temp;
                        this.Controls.Add(temp);
                    }
                }
            }
        }

        private void SubscribeOnScreenKeyboardButtons()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    (control as Button).Click += OnScreenKeyboardClick;
                    (control as Button).Enabled = true;
                    (control as Button).Visible = true;
                }
            }
        }

        private void OnScreenKeyboardClick(object? sender, EventArgs e)
        {
            Button? buttonClicked = sender as Button;
            if (buttonClicked.Text == "<=" && col >= 0)
            {
                if (col != 0)
                {
                    col--;
                    buttonList.RemoveAt(buttonList.Count - 1);
                    rowColorPattern.RemoveAt(rowColorPattern.Count - 1);
                    wurdleGrid[row, col].Text = " ";
                    wurdleGrid[row, col].BackColor = wordleTextBox.BackColor;
                }
            }

            else if (buttonClicked.Text == "ENTER")
            {
                if (col == numOfCols)
                {
                    WordValidityCheck();
                    AssignRowColorPattern();
                    buttonList.Clear();
                    rowColorPattern.Clear();
                    row++;
                    col = 0;
                }

                if (row == numOfRows)
                {
                    randWord.GameOverSequence();
                    UnsubscribeOnScreenKeyboardButtons();
                }
            }

            else if (col < numOfCols && row < numOfRows)
            {
                wurdleGrid[row, col].Text = buttonClicked.Text;
                LetterCheck(buttonClicked);
                col++;
            }
        }

        private void AssignRowColorPattern()
        {
            // Integer value of 1 indicates the word is a part of the list of accepted words.
            if (isAWord == 1)
            {
                for (int i = 0; i < rowColorPattern.Count; i++)
                {
                    if (rowColorPattern[i] == "R")
                    {
                        buttonList[i].Enabled = false;
                        buttonList[i].Visible = false;
                        wurdleGrid[row, i].BackColor = Color.Red;
                    }
                    else if (rowColorPattern[i] == "Y")
                    {
                        wurdleGrid[row, i].BackColor = Color.FromArgb(204, 204, 0);
                    }
                    else
                    {
                        wurdleGrid[row, i].BackColor = Color.Green;
                    }
                }
            }
            // Integer value of 3 indicates that the word guessed matches the winning word.
            else if (isAWord == 3)
            {
                for (int i = 0; i < rowColorPattern.Count; i++)
                {
                    wurdleGrid[row, i].BackColor = Color.Green;
                }
                UnsubscribeOnScreenKeyboardButtons();
                DialogResult winningMessage = MessageBox.Show($"Congratulations, you've guessed the correct word in {row + 1} tries. Would you like to restart?",
                    "Winner Winner Chicken Dinner!", MessageBoxButtons.YesNo);
                if (winningMessage == DialogResult.Yes)
                {
                    RestartGame();
                }
            }
        }
        
        private void RestartGame()
        {
            buttonList.Clear();
            rowColorPattern.Clear();
            for (int i = 0; i <= row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    wurdleGrid[i, j].Text = " ";
                    wurdleGrid[i, j].BackColor = wordleTextBox.BackColor;
                }
            }
            col = 0;
            row = -1;
            SubscribeOnScreenKeyboardButtons();
        }
        
        private void UnsubscribeOnScreenKeyboardButtons()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    (control as Button).Click -= OnScreenKeyboardClick;
                    (control as Button).Visible = false;

                }
            }
        }

        private void WordValidityCheck()
        {
            for (int i = 0; i < numOfCols; i++)
            {
                isAWord = randWord.BuildStringAndMatch(wurdleGrid[row, i].Text, numOfCols);
                if (isAWord == 0)
                {
                    for (int a = 0; a < numOfCols; a++)
                    {
                        wurdleGrid[row, a].Text = " ";
                    }
                    row--;
                    col = 0;
                }
            }
        }

        private void LetterCheck(Button buttonClicked)
        {
            string boxColorChoice = randWord.CheckLetterAgainstWinner(wurdleGrid[row, col].Text, col);
            buttonList.Add(buttonClicked);
            rowColorPattern.Add(boxColorChoice);
        }

        private class CustomThemeRenderer : ToolStripProfessionalRenderer
        {
            public CustomThemeRenderer() : base(new CustomThemeColors()) { }
        }

        private class CustomThemeColors : ProfessionalColorTable
        {
            public override Color MenuItemSelectedGradientBegin => Color.FromArgb(85, 85, 85);
            public override Color MenuItemSelectedGradientEnd => Color.FromArgb(85, 85, 85);
            public override Color MenuItemPressedGradientBegin => Color.FromArgb(61, 61, 61);
            public override Color MenuItemPressedGradientEnd => Color.FromArgb(61, 61, 61);
        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

    }

}