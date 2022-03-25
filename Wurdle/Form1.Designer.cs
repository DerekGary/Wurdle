namespace Wurdle
{
    partial class wurdleForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordleTextBox = new System.Windows.Forms.TextBox();
            this.wurdleLabel = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Label();
            this.qKey = new System.Windows.Forms.Button();
            this.aKey = new System.Windows.Forms.Button();
            this.xKey = new System.Windows.Forms.Button();
            this.cKey = new System.Windows.Forms.Button();
            this.nKey = new System.Windows.Forms.Button();
            this.bKey = new System.Windows.Forms.Button();
            this.vKey = new System.Windows.Forms.Button();
            this.mKey = new System.Windows.Forms.Button();
            this.kKey = new System.Windows.Forms.Button();
            this.jKey = new System.Windows.Forms.Button();
            this.hKey = new System.Windows.Forms.Button();
            this.gKey = new System.Windows.Forms.Button();
            this.fKey = new System.Windows.Forms.Button();
            this.dKey = new System.Windows.Forms.Button();
            this.sKey = new System.Windows.Forms.Button();
            this.lKey = new System.Windows.Forms.Button();
            this.pKey = new System.Windows.Forms.Button();
            this.oKey = new System.Windows.Forms.Button();
            this.iKey = new System.Windows.Forms.Button();
            this.uKey = new System.Windows.Forms.Button();
            this.yKey = new System.Windows.Forms.Button();
            this.rKey = new System.Windows.Forms.Button();
            this.eKey = new System.Windows.Forms.Button();
            this.wKey = new System.Windows.Forms.Button();
            this.enterKey = new System.Windows.Forms.Button();
            this.backspaceKey = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tKey = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.documentationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.documentationToolStripMenuItem.Text = "How to Play";
            this.documentationToolStripMenuItem.Click += new System.EventHandler(this.documentationToolStripMenuItem_Click);
            // 
            // wordleTextBox
            // 
            this.wordleTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wordleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.wordleTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.wordleTextBox.Enabled = false;
            this.wordleTextBox.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wordleTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.wordleTextBox.Location = new System.Drawing.Point(226, 73);
            this.wordleTextBox.Name = "wordleTextBox";
            this.wordleTextBox.ReadOnly = true;
            this.wordleTextBox.Size = new System.Drawing.Size(82, 63);
            this.wordleTextBox.TabIndex = 2;
            this.wordleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wordleTextBox.Visible = false;
            // 
            // wurdleLabel
            // 
            this.wurdleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.wurdleLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wurdleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.wurdleLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.wurdleLabel.Location = new System.Drawing.Point(0, 33);
            this.wurdleLabel.Name = "wurdleLabel";
            this.wurdleLabel.Size = new System.Drawing.Size(800, 37);
            this.wurdleLabel.TabIndex = 3;
            this.wurdleLabel.Text = "Wurdle";
            this.wurdleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // divider
            // 
            this.divider.AutoSize = true;
            this.divider.Enabled = false;
            this.divider.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.divider.Location = new System.Drawing.Point(339, 498);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(102, 25);
            this.divider.TabIndex = 4;
            this.divider.Text = "End of Grid";
            this.divider.Visible = false;
            // 
            // qKey
            // 
            this.qKey.BackColor = System.Drawing.Color.DarkGray;
            this.qKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.qKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qKey.ForeColor = System.Drawing.SystemColors.Control;
            this.qKey.Location = new System.Drawing.Point(103, 526);
            this.qKey.Name = "qKey";
            this.qKey.Size = new System.Drawing.Size(54, 64);
            this.qKey.TabIndex = 5;
            this.qKey.Text = "Q";
            this.qKey.UseVisualStyleBackColor = false;
            // 
            // aKey
            // 
            this.aKey.BackColor = System.Drawing.Color.DarkGray;
            this.aKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aKey.ForeColor = System.Drawing.SystemColors.Control;
            this.aKey.Location = new System.Drawing.Point(130, 596);
            this.aKey.Name = "aKey";
            this.aKey.Size = new System.Drawing.Size(54, 64);
            this.aKey.TabIndex = 7;
            this.aKey.Text = "A";
            this.aKey.UseVisualStyleBackColor = false;
            // 
            // xKey
            // 
            this.xKey.BackColor = System.Drawing.Color.DarkGray;
            this.xKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.xKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xKey.ForeColor = System.Drawing.SystemColors.Control;
            this.xKey.Location = new System.Drawing.Point(250, 666);
            this.xKey.Name = "xKey";
            this.xKey.Size = new System.Drawing.Size(54, 64);
            this.xKey.TabIndex = 9;
            this.xKey.Text = "X";
            this.xKey.UseVisualStyleBackColor = false;
            // 
            // cKey
            // 
            this.cKey.BackColor = System.Drawing.Color.DarkGray;
            this.cKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cKey.ForeColor = System.Drawing.SystemColors.Control;
            this.cKey.Location = new System.Drawing.Point(310, 666);
            this.cKey.Name = "cKey";
            this.cKey.Size = new System.Drawing.Size(54, 64);
            this.cKey.TabIndex = 10;
            this.cKey.Text = "C";
            this.cKey.UseVisualStyleBackColor = false;
            // 
            // nKey
            // 
            this.nKey.BackColor = System.Drawing.Color.DarkGray;
            this.nKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nKey.ForeColor = System.Drawing.SystemColors.Control;
            this.nKey.Location = new System.Drawing.Point(490, 666);
            this.nKey.Name = "nKey";
            this.nKey.Size = new System.Drawing.Size(54, 64);
            this.nKey.TabIndex = 13;
            this.nKey.Text = "N";
            this.nKey.UseVisualStyleBackColor = false;
            // 
            // bKey
            // 
            this.bKey.BackColor = System.Drawing.Color.DarkGray;
            this.bKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bKey.ForeColor = System.Drawing.SystemColors.Control;
            this.bKey.Location = new System.Drawing.Point(430, 666);
            this.bKey.Name = "bKey";
            this.bKey.Size = new System.Drawing.Size(54, 64);
            this.bKey.TabIndex = 12;
            this.bKey.Text = "B";
            this.bKey.UseVisualStyleBackColor = false;
            // 
            // vKey
            // 
            this.vKey.BackColor = System.Drawing.Color.DarkGray;
            this.vKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vKey.ForeColor = System.Drawing.SystemColors.Control;
            this.vKey.Location = new System.Drawing.Point(370, 666);
            this.vKey.Name = "vKey";
            this.vKey.Size = new System.Drawing.Size(54, 64);
            this.vKey.TabIndex = 11;
            this.vKey.Text = "V";
            this.vKey.UseVisualStyleBackColor = false;
            // 
            // mKey
            // 
            this.mKey.BackColor = System.Drawing.Color.DarkGray;
            this.mKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mKey.ForeColor = System.Drawing.SystemColors.Control;
            this.mKey.Location = new System.Drawing.Point(550, 666);
            this.mKey.Name = "mKey";
            this.mKey.Size = new System.Drawing.Size(54, 64);
            this.mKey.TabIndex = 14;
            this.mKey.Text = "M";
            this.mKey.UseVisualStyleBackColor = false;
            // 
            // kKey
            // 
            this.kKey.BackColor = System.Drawing.Color.DarkGray;
            this.kKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kKey.ForeColor = System.Drawing.SystemColors.Control;
            this.kKey.Location = new System.Drawing.Point(550, 596);
            this.kKey.Name = "kKey";
            this.kKey.Size = new System.Drawing.Size(54, 64);
            this.kKey.TabIndex = 21;
            this.kKey.Text = "K";
            this.kKey.UseVisualStyleBackColor = false;
            // 
            // jKey
            // 
            this.jKey.BackColor = System.Drawing.Color.DarkGray;
            this.jKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.jKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.jKey.ForeColor = System.Drawing.SystemColors.Control;
            this.jKey.Location = new System.Drawing.Point(490, 596);
            this.jKey.Name = "jKey";
            this.jKey.Size = new System.Drawing.Size(54, 64);
            this.jKey.TabIndex = 20;
            this.jKey.Text = "J";
            this.jKey.UseVisualStyleBackColor = false;
            // 
            // hKey
            // 
            this.hKey.BackColor = System.Drawing.Color.DarkGray;
            this.hKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hKey.ForeColor = System.Drawing.SystemColors.Control;
            this.hKey.Location = new System.Drawing.Point(430, 596);
            this.hKey.Name = "hKey";
            this.hKey.Size = new System.Drawing.Size(54, 64);
            this.hKey.TabIndex = 19;
            this.hKey.Text = "H";
            this.hKey.UseVisualStyleBackColor = false;
            // 
            // gKey
            // 
            this.gKey.BackColor = System.Drawing.Color.DarkGray;
            this.gKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gKey.ForeColor = System.Drawing.SystemColors.Control;
            this.gKey.Location = new System.Drawing.Point(370, 596);
            this.gKey.Name = "gKey";
            this.gKey.Size = new System.Drawing.Size(54, 64);
            this.gKey.TabIndex = 18;
            this.gKey.Text = "G";
            this.gKey.UseVisualStyleBackColor = false;
            // 
            // fKey
            // 
            this.fKey.BackColor = System.Drawing.Color.DarkGray;
            this.fKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fKey.ForeColor = System.Drawing.SystemColors.Control;
            this.fKey.Location = new System.Drawing.Point(310, 596);
            this.fKey.Name = "fKey";
            this.fKey.Size = new System.Drawing.Size(54, 64);
            this.fKey.TabIndex = 17;
            this.fKey.Text = "F";
            this.fKey.UseVisualStyleBackColor = false;
            // 
            // dKey
            // 
            this.dKey.BackColor = System.Drawing.Color.DarkGray;
            this.dKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dKey.ForeColor = System.Drawing.SystemColors.Control;
            this.dKey.Location = new System.Drawing.Point(250, 596);
            this.dKey.Name = "dKey";
            this.dKey.Size = new System.Drawing.Size(54, 64);
            this.dKey.TabIndex = 16;
            this.dKey.Text = "D";
            this.dKey.UseVisualStyleBackColor = false;
            // 
            // sKey
            // 
            this.sKey.BackColor = System.Drawing.Color.DarkGray;
            this.sKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sKey.ForeColor = System.Drawing.SystemColors.Control;
            this.sKey.Location = new System.Drawing.Point(190, 596);
            this.sKey.Name = "sKey";
            this.sKey.Size = new System.Drawing.Size(54, 64);
            this.sKey.TabIndex = 15;
            this.sKey.Text = "S";
            this.sKey.UseVisualStyleBackColor = false;
            // 
            // lKey
            // 
            this.lKey.BackColor = System.Drawing.Color.DarkGray;
            this.lKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lKey.ForeColor = System.Drawing.SystemColors.Control;
            this.lKey.Location = new System.Drawing.Point(610, 596);
            this.lKey.Name = "lKey";
            this.lKey.Size = new System.Drawing.Size(54, 64);
            this.lKey.TabIndex = 22;
            this.lKey.Text = "L";
            this.lKey.UseVisualStyleBackColor = false;
            // 
            // pKey
            // 
            this.pKey.BackColor = System.Drawing.Color.DarkGray;
            this.pKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pKey.ForeColor = System.Drawing.SystemColors.Control;
            this.pKey.Location = new System.Drawing.Point(643, 526);
            this.pKey.Name = "pKey";
            this.pKey.Size = new System.Drawing.Size(54, 64);
            this.pKey.TabIndex = 31;
            this.pKey.Text = "P";
            this.pKey.UseVisualStyleBackColor = false;
            // 
            // oKey
            // 
            this.oKey.BackColor = System.Drawing.Color.DarkGray;
            this.oKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oKey.ForeColor = System.Drawing.SystemColors.Control;
            this.oKey.Location = new System.Drawing.Point(583, 526);
            this.oKey.Name = "oKey";
            this.oKey.Size = new System.Drawing.Size(54, 64);
            this.oKey.TabIndex = 30;
            this.oKey.Text = "O";
            this.oKey.UseVisualStyleBackColor = false;
            // 
            // iKey
            // 
            this.iKey.BackColor = System.Drawing.Color.DarkGray;
            this.iKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iKey.ForeColor = System.Drawing.SystemColors.Control;
            this.iKey.Location = new System.Drawing.Point(523, 526);
            this.iKey.Name = "iKey";
            this.iKey.Size = new System.Drawing.Size(54, 64);
            this.iKey.TabIndex = 29;
            this.iKey.Text = "I";
            this.iKey.UseVisualStyleBackColor = false;
            // 
            // uKey
            // 
            this.uKey.BackColor = System.Drawing.Color.DarkGray;
            this.uKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uKey.ForeColor = System.Drawing.SystemColors.Control;
            this.uKey.Location = new System.Drawing.Point(463, 526);
            this.uKey.Name = "uKey";
            this.uKey.Size = new System.Drawing.Size(54, 64);
            this.uKey.TabIndex = 28;
            this.uKey.Text = "U";
            this.uKey.UseVisualStyleBackColor = false;
            // 
            // yKey
            // 
            this.yKey.BackColor = System.Drawing.Color.DarkGray;
            this.yKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yKey.ForeColor = System.Drawing.SystemColors.Control;
            this.yKey.Location = new System.Drawing.Point(403, 526);
            this.yKey.Name = "yKey";
            this.yKey.Size = new System.Drawing.Size(54, 64);
            this.yKey.TabIndex = 27;
            this.yKey.Text = "Y";
            this.yKey.UseVisualStyleBackColor = false;
            // 
            // rKey
            // 
            this.rKey.BackColor = System.Drawing.Color.DarkGray;
            this.rKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rKey.ForeColor = System.Drawing.SystemColors.Control;
            this.rKey.Location = new System.Drawing.Point(283, 526);
            this.rKey.Name = "rKey";
            this.rKey.Size = new System.Drawing.Size(54, 64);
            this.rKey.TabIndex = 25;
            this.rKey.Text = "R";
            this.rKey.UseVisualStyleBackColor = false;
            // 
            // eKey
            // 
            this.eKey.BackColor = System.Drawing.Color.DarkGray;
            this.eKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eKey.ForeColor = System.Drawing.SystemColors.Control;
            this.eKey.Location = new System.Drawing.Point(223, 526);
            this.eKey.Name = "eKey";
            this.eKey.Size = new System.Drawing.Size(54, 64);
            this.eKey.TabIndex = 24;
            this.eKey.Text = "E";
            this.eKey.UseVisualStyleBackColor = false;
            // 
            // wKey
            // 
            this.wKey.BackColor = System.Drawing.Color.DarkGray;
            this.wKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wKey.ForeColor = System.Drawing.SystemColors.Control;
            this.wKey.Location = new System.Drawing.Point(163, 526);
            this.wKey.Name = "wKey";
            this.wKey.Size = new System.Drawing.Size(54, 64);
            this.wKey.TabIndex = 23;
            this.wKey.Text = "W";
            this.wKey.UseVisualStyleBackColor = false;
            // 
            // enterKey
            // 
            this.enterKey.BackColor = System.Drawing.Color.DarkGray;
            this.enterKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enterKey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterKey.ForeColor = System.Drawing.SystemColors.Control;
            this.enterKey.Location = new System.Drawing.Point(103, 666);
            this.enterKey.Name = "enterKey";
            this.enterKey.Size = new System.Drawing.Size(81, 64);
            this.enterKey.TabIndex = 32;
            this.enterKey.Text = "ENTER";
            this.enterKey.UseVisualStyleBackColor = false;
            // 
            // backspaceKey
            // 
            this.backspaceKey.BackColor = System.Drawing.Color.DarkGray;
            this.backspaceKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backspaceKey.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backspaceKey.ForeColor = System.Drawing.SystemColors.Control;
            this.backspaceKey.Location = new System.Drawing.Point(610, 666);
            this.backspaceKey.Name = "backspaceKey";
            this.backspaceKey.Size = new System.Drawing.Size(87, 64);
            this.backspaceKey.TabIndex = 33;
            this.backspaceKey.Text = "<=";
            this.backspaceKey.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(190, 666);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 64);
            this.button1.TabIndex = 34;
            this.button1.Text = "Z";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tKey
            // 
            this.tKey.BackColor = System.Drawing.Color.DarkGray;
            this.tKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tKey.ForeColor = System.Drawing.SystemColors.Control;
            this.tKey.Location = new System.Drawing.Point(343, 526);
            this.tKey.Name = "tKey";
            this.tKey.Size = new System.Drawing.Size(54, 64);
            this.tKey.TabIndex = 26;
            this.tKey.Text = "T";
            this.tKey.UseVisualStyleBackColor = false;
            // 
            // wurdleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 770);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backspaceKey);
            this.Controls.Add(this.enterKey);
            this.Controls.Add(this.pKey);
            this.Controls.Add(this.oKey);
            this.Controls.Add(this.iKey);
            this.Controls.Add(this.uKey);
            this.Controls.Add(this.yKey);
            this.Controls.Add(this.tKey);
            this.Controls.Add(this.rKey);
            this.Controls.Add(this.eKey);
            this.Controls.Add(this.wKey);
            this.Controls.Add(this.lKey);
            this.Controls.Add(this.kKey);
            this.Controls.Add(this.jKey);
            this.Controls.Add(this.hKey);
            this.Controls.Add(this.gKey);
            this.Controls.Add(this.fKey);
            this.Controls.Add(this.dKey);
            this.Controls.Add(this.sKey);
            this.Controls.Add(this.mKey);
            this.Controls.Add(this.nKey);
            this.Controls.Add(this.bKey);
            this.Controls.Add(this.vKey);
            this.Controls.Add(this.cKey);
            this.Controls.Add(this.xKey);
            this.Controls.Add(this.aKey);
            this.Controls.Add(this.qKey);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.wurdleLabel);
            this.Controls.Add(this.wordleTextBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "wurdleForm";
            this.Text = "Wurdle | Game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem documentationToolStripMenuItem;
        private TextBox wordleTextBox;
        private Label wurdleLabel;
        private Label divider;
        private Button qKey;
        private Button aKey;
        private Button xKey;
        private Button cKey;
        private Button nKey;
        private Button bKey;
        private Button vKey;
        private Button mKey;
        private Button kKey;
        private Button jKey;
        private Button hKey;
        private Button gKey;
        private Button fKey;
        private Button dKey;
        private Button sKey;
        private Button lKey;
        private Button pKey;
        private Button oKey;
        private Button iKey;
        private Button uKey;
        private Button yKey;
        private Button rKey;
        private Button eKey;
        private Button wKey;
        private Button enterKey;
        private Button backspaceKey;
        private Button button1;
        private Button tKey;
    }
}