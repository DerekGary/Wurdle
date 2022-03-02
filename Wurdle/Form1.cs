namespace Wurdle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            menuStrip1.Renderer = new CustomThemeRenderer();
        }

        private class CustomThemeRenderer : ToolStripProfessionalRenderer 
        {
            public CustomThemeRenderer() : base(new CustomThemeColors()) {}
        }

        private class CustomThemeColors : ProfessionalColorTable 
        {
            public override Color MenuItemSelectedGradientBegin => Color.FromArgb(85,85,85);
            public override Color MenuItemSelectedGradientEnd => Color.FromArgb(85, 85, 85);
            public override Color MenuItemPressedGradientBegin => Color.FromArgb(61, 61, 61);
            public override Color MenuItemPressedGradientEnd => Color.FromArgb(61, 61, 61);
        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}