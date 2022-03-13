namespace Wurdle
{
    public partial class wurdleForm : Form
    {
        TextBox[,] wurdleGrid = new TextBox[6,5];
        public wurdleForm()
        {
            InitializeComponent();
            menuStrip1.Renderer = new CustomThemeRenderer();
            formatUILayout();
        }

        private void formatUILayout()
        {
            wordleTextBox.Width = 64;
            wordleTextBox.Location = new Point(wordleTextBox.Location.X, wordleTextBox.Location.Y);
            wordleTextBox.Height = wordleTextBox.Width;
            wordleTextBox.Dock = DockStyle.None;
            initializeWurdleGrid();
        }

        private void initializeWurdleGrid() 
        {

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
                        temp.Location = new Point(wordleTextBox.Location.X, wordleTextBox.Location.Y + (67 * i));
                        wurdleGrid[i, j] = temp;
                        this.Controls.Add(temp);
                    }
                    else
                    {
                        temp.Location = new Point(wordleTextBox.Location.X + (67 * j), wordleTextBox.Location.Y + (67 * i));
                        wurdleGrid[i, j] = temp;
                        this.Controls.Add(temp);
                    }
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

        private void Keyboard_Click(object sender, EventArgs e)
        {

        }
    }

}