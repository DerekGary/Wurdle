namespace Wurdle
{
    public partial class wurdleForm : Form
    {
        private static int numOfCols = 5;
        private static int numOfRows = 6;
        private int col = 0;
        private int row = 0;
        private bool firstCall = true;
        private TextBox[,] wurdleGrid = new TextBox[numOfRows, numOfCols];
        RandomWordGenerator randWord = new RandomWordGenerator();


        public wurdleForm()
        {
            InitializeComponent();
            menuStrip1.Renderer = new CustomThemeRenderer();
            formatUILayout();
            handleOnScreenKeyboardButtons();
        }

        private void formatUILayout()
        {
            wordleTextBox.Width = 64;
            wordleTextBox.Location = new Point(wordleTextBox.Location.X,
                wordleTextBox.Location.Y);
            wordleTextBox.Height = wordleTextBox.Width;
            wordleTextBox.Dock = DockStyle.None;
            initializeWurdleGrid();
        }
        private void initializeWurdleGrid()
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
        private void handleOnScreenKeyboardButtons()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    (control as Button).Click += OnScreenKeyboardClick;
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
                    wurdleGrid[row, col].Text = " ";
                    wurdleGrid[row, col].BackColor = wordleTextBox.BackColor;
                }
            }
            else if (buttonClicked.Text == "ENTER")
            {
                if (col == numOfCols)
                {
                    wordCheck();
                    row++;
                    col = 0;
                }
                if (row == numOfRows) 
                {
                    MessageBox.Show("Game Over.");
                }
            }
            else if (col < numOfCols && row < numOfRows)
            {
                wurdleGrid[row, col].Text = buttonClicked.Text;
                col++;
            }
        }

        private void wordCheck()
        {
            if (firstCall == true)
            {
                randWord.readList();
                firstCall = false;
            }

            for (int i = 0; i < numOfCols; i++)
            {
                int isAWord = randWord.buildStringAndMatch(wurdleGrid[row, i].Text, numOfCols);
                if (isAWord == 0)
                {
                    MessageBox.Show("Your current word is not part of the list of possible words.");
                    for (int a = 0; a < numOfCols; a++)
                    {
                        wurdleGrid[row, a].Text = " ";
                    }
                    row--;
                    col = 0;
                }
            }

            if (col == numOfCols)
            {
                string colorGuide = randWord.checkUserWordAgainstWinner();
                for (int a = 0; a < colorGuide.Length; a++)
                {
                    if (colorGuide[a].ToString() == "G")
                    {
                        wurdleGrid[row, a].BackColor = Color.Green;
                    }
                    else if (colorGuide[a].ToString() == "Y")
                    {
                        wurdleGrid[row, a].BackColor = Color.FromArgb(204,204,0);
                    }
                    else
                    {
                        wurdleGrid[row, a].BackColor = Color.Red;                     
                    }
                }
                if (colorGuide.Contains("GGGGG")) 
                {
                    MessageBox.Show("You guessed the word correctly.");
                }
            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void wurdleForm_Load(object sender, EventArgs e)
        {

        }

        private void PhysicalKeyboardClick(object sender, KeyPressEventArgs e)
        {
        }
    }

}