namespace exSCA
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pythonEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.declinerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Categories = new FastColoredTextBoxNS.FastColoredTextBox();
            this.Rewrite = new FastColoredTextBoxNS.FastColoredTextBox();
            this.AdvancedRewrite = new FastColoredTextBoxNS.FastColoredTextBox();
            this.Input = new FastColoredTextBoxNS.FastColoredTextBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BracketedOutput = new System.Windows.Forms.RadioButton();
            this.ArrowedOutput = new System.Windows.Forms.RadioButton();
            this.PlainOutput = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SyllabificationBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.SyllabifyHelpButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RewriteOnOutput = new System.Windows.Forms.CheckBox();
            this.ReportRules = new System.Windows.Forms.CheckBox();
            this.ShowChanges = new System.Windows.Forms.CheckBox();
            this.SoundChanges = new FastColoredTextBoxNS.FastColoredTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Categories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rewrite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvancedRewrite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SyllabificationBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoundChanges)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(2299, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 48);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(415, 46);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(415, 46);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(415, 46);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(80, 48);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(203, 46);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(203, 46);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pythonEditorToolStripMenuItem,
            this.declinerToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(99, 48);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // pythonEditorToolStripMenuItem
            // 
            this.pythonEditorToolStripMenuItem.Name = "pythonEditorToolStripMenuItem";
            this.pythonEditorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pythonEditorToolStripMenuItem.Size = new System.Drawing.Size(498, 46);
            this.pythonEditorToolStripMenuItem.Text = "Python Editor";
            this.pythonEditorToolStripMenuItem.Click += new System.EventHandler(this.pythonEditorToolStripMenuItem_Click);
            // 
            // declinerToolStripMenuItem
            // 
            this.declinerToolStripMenuItem.Name = "declinerToolStripMenuItem";
            this.declinerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.declinerToolStripMenuItem.Size = new System.Drawing.Size(498, 46);
            this.declinerToolStripMenuItem.Text = "Decliner/Conjugator";
            this.declinerToolStripMenuItem.Click += new System.EventHandler(this.declinerToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(92, 48);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(215, 46);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Categories
            // 
            this.Categories.AcceptsTab = false;
            this.Categories.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.Categories.AutoIndent = false;
            this.Categories.AutoIndentCharsPatterns = "";
            this.Categories.AutoScrollMinSize = new System.Drawing.Size(0, 36);
            this.Categories.BackBrush = null;
            this.Categories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Categories.CharHeight = 36;
            this.Categories.CharWidth = 20;
            this.Categories.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Categories.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Categories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Categories.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.Categories.IsReplaceMode = false;
            this.Categories.Location = new System.Drawing.Point(35, 31);
            this.Categories.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Categories.Name = "Categories";
            this.Categories.Paddings = new System.Windows.Forms.Padding(0);
            this.Categories.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Categories.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("Categories.ServiceColors")));
            this.Categories.ShowLineNumbers = false;
            this.Categories.Size = new System.Drawing.Size(433, 532);
            this.Categories.TabIndex = 1;
            this.Categories.WordWrap = true;
            this.Categories.Zoom = 100;
            this.Categories.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.Categories_TextChanged);
            // 
            // Rewrite
            // 
            this.Rewrite.AcceptsTab = false;
            this.Rewrite.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.Rewrite.AutoIndent = false;
            this.Rewrite.AutoIndentCharsPatterns = "";
            this.Rewrite.AutoScrollMinSize = new System.Drawing.Size(0, 36);
            this.Rewrite.BackBrush = null;
            this.Rewrite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rewrite.CharHeight = 36;
            this.Rewrite.CharWidth = 20;
            this.Rewrite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Rewrite.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Rewrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rewrite.IsReplaceMode = false;
            this.Rewrite.Location = new System.Drawing.Point(35, 577);
            this.Rewrite.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Rewrite.Name = "Rewrite";
            this.Rewrite.Paddings = new System.Windows.Forms.Padding(0);
            this.Rewrite.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Rewrite.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("Rewrite.ServiceColors")));
            this.Rewrite.ShowLineNumbers = false;
            this.Rewrite.Size = new System.Drawing.Size(433, 533);
            this.Rewrite.TabIndex = 2;
            this.Rewrite.WordWrap = true;
            this.Rewrite.Zoom = 100;
            this.Rewrite.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.SimpleRewrite_TextChanged);
            // 
            // AdvancedRewrite
            // 
            this.AdvancedRewrite.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.AdvancedRewrite.AutoScrollMinSize = new System.Drawing.Size(0, 36);
            this.AdvancedRewrite.BackBrush = null;
            this.AdvancedRewrite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdvancedRewrite.CharHeight = 36;
            this.AdvancedRewrite.CharWidth = 20;
            this.AdvancedRewrite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdvancedRewrite.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.AdvancedRewrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdvancedRewrite.IsReplaceMode = false;
            this.AdvancedRewrite.Location = new System.Drawing.Point(3, 3);
            this.AdvancedRewrite.Name = "AdvancedRewrite";
            this.AdvancedRewrite.Paddings = new System.Windows.Forms.Padding(0);
            this.AdvancedRewrite.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.AdvancedRewrite.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("AdvancedRewrite.ServiceColors")));
            this.AdvancedRewrite.ShowLineNumbers = false;
            this.AdvancedRewrite.Size = new System.Drawing.Size(148, 192);
            this.AdvancedRewrite.TabIndex = 2;
            this.AdvancedRewrite.WordWrap = true;
            this.AdvancedRewrite.Zoom = 100;
            // 
            // Input
            // 
            this.Input.AcceptsTab = false;
            this.Input.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.Input.AutoScrollMinSize = new System.Drawing.Size(0, 36);
            this.Input.BackBrush = null;
            this.Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Input.CharHeight = 36;
            this.Input.CharWidth = 20;
            this.Input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Input.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Input.IsReplaceMode = false;
            this.Input.Location = new System.Drawing.Point(933, 31);
            this.Input.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Input.Name = "Input";
            this.Input.Paddings = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.SetRowSpan(this.Input, 2);
            this.Input.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Input.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("Input.ServiceColors")));
            this.Input.ShowLineNumbers = false;
            this.Input.Size = new System.Drawing.Size(433, 1079);
            this.Input.TabIndex = 4;
            this.Input.WordWrap = true;
            this.Input.Zoom = 100;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApplyButton.Location = new System.Drawing.Point(8, 7);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(433, 55);
            this.ApplyButton.TabIndex = 6;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BracketedOutput);
            this.groupBox1.Controls.Add(this.ArrowedOutput);
            this.groupBox1.Controls.Add(this.PlainOutput);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(8, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(433, 241);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ouput Format";
            // 
            // BracketedOutput
            // 
            this.BracketedOutput.AutoSize = true;
            this.BracketedOutput.Location = new System.Drawing.Point(19, 157);
            this.BracketedOutput.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BracketedOutput.Name = "BracketedOutput";
            this.BracketedOutput.Size = new System.Drawing.Size(218, 36);
            this.BracketedOutput.TabIndex = 2;
            this.BracketedOutput.Text = "output [input]";
            this.BracketedOutput.UseVisualStyleBackColor = true;
            // 
            // ArrowedOutput
            // 
            this.ArrowedOutput.AutoSize = true;
            this.ArrowedOutput.Location = new System.Drawing.Point(19, 103);
            this.ArrowedOutput.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ArrowedOutput.Name = "ArrowedOutput";
            this.ArrowedOutput.Size = new System.Drawing.Size(237, 36);
            this.ArrowedOutput.TabIndex = 1;
            this.ArrowedOutput.Text = "input → output";
            this.ArrowedOutput.UseVisualStyleBackColor = true;
            // 
            // PlainOutput
            // 
            this.PlainOutput.AutoSize = true;
            this.PlainOutput.Checked = true;
            this.PlainOutput.Location = new System.Drawing.Point(19, 48);
            this.PlainOutput.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.PlainOutput.Name = "PlainOutput";
            this.PlainOutput.Size = new System.Drawing.Size(132, 36);
            this.PlainOutput.TabIndex = 0;
            this.PlainOutput.TabStop = true;
            this.PlainOutput.Text = "output";
            this.PlainOutput.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Categories, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Input, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.SoundChanges, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Rewrite, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 58);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(27, 24, 27, 24);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2299, 1141);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ApplyButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1374, 31);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(449, 1079);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.SyllabificationBox);
            this.groupBox2.Controls.Add(this.SyllabifyHelpButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 938);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 5, 8, 7);
            this.groupBox2.Size = new System.Drawing.Size(449, 141);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Syllabification";
            // 
            // SyllabificationBox
            // 
            this.SyllabificationBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.SyllabificationBox.AutoScrollMinSize = new System.Drawing.Size(962, 36);
            this.SyllabificationBox.BackBrush = null;
            this.SyllabificationBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SyllabificationBox.CharHeight = 36;
            this.SyllabificationBox.CharWidth = 20;
            this.SyllabificationBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SyllabificationBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.SyllabificationBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SyllabificationBox.IsReplaceMode = false;
            this.SyllabificationBox.Location = new System.Drawing.Point(8, 36);
            this.SyllabificationBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.SyllabificationBox.Multiline = false;
            this.SyllabificationBox.Name = "SyllabificationBox";
            this.SyllabificationBox.Paddings = new System.Windows.Forms.Padding(0);
            this.SyllabificationBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.SyllabificationBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("SyllabificationBox.ServiceColors")));
            this.SyllabificationBox.ShowLineNumbers = false;
            this.SyllabificationBox.ShowScrollBars = false;
            this.SyllabificationBox.Size = new System.Drawing.Size(433, 43);
            this.SyllabificationBox.TabIndex = 18;
            this.SyllabificationBox.Text = "(CC?)?V(?((?=CC$))CC|(?((?=CC))C|(?((?=C$))C|)))";
            this.SyllabificationBox.Zoom = 100;
            this.SyllabificationBox.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.SyllabificationBox_TextChanged);
            // 
            // SyllabifyHelpButton
            // 
            this.SyllabifyHelpButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SyllabifyHelpButton.Enabled = false;
            this.SyllabifyHelpButton.Location = new System.Drawing.Point(8, 79);
            this.SyllabifyHelpButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.SyllabifyHelpButton.Name = "SyllabifyHelpButton";
            this.SyllabifyHelpButton.Size = new System.Drawing.Size(433, 55);
            this.SyllabifyHelpButton.TabIndex = 19;
            this.SyllabifyHelpButton.Text = "Regex Help";
            this.SyllabifyHelpButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RewriteOnOutput);
            this.panel1.Controls.Add(this.ReportRules);
            this.panel1.Controls.Add(this.ShowChanges);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 324);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 614);
            this.panel1.TabIndex = 8;
            // 
            // RewriteOnOutput
            // 
            this.RewriteOnOutput.AutoSize = true;
            this.RewriteOnOutput.Checked = true;
            this.RewriteOnOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RewriteOnOutput.Location = new System.Drawing.Point(8, 119);
            this.RewriteOnOutput.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.RewriteOnOutput.Name = "RewriteOnOutput";
            this.RewriteOnOutput.Size = new System.Drawing.Size(275, 36);
            this.RewriteOnOutput.TabIndex = 2;
            this.RewriteOnOutput.Text = "Rewrite on output";
            this.RewriteOnOutput.UseVisualStyleBackColor = true;
            // 
            // ReportRules
            // 
            this.ReportRules.AutoSize = true;
            this.ReportRules.Location = new System.Drawing.Point(11, 64);
            this.ReportRules.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ReportRules.Name = "ReportRules";
            this.ReportRules.Size = new System.Drawing.Size(363, 36);
            this.ReportRules.TabIndex = 1;
            this.ReportRules.Text = "Report which rules apply";
            this.ReportRules.UseVisualStyleBackColor = true;
            // 
            // ShowChanges
            // 
            this.ShowChanges.AutoSize = true;
            this.ShowChanges.Location = new System.Drawing.Point(11, 10);
            this.ShowChanges.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ShowChanges.Name = "ShowChanges";
            this.ShowChanges.Size = new System.Drawing.Size(323, 36);
            this.ShowChanges.TabIndex = 0;
            this.ShowChanges.Text = "Show changed words";
            this.ShowChanges.UseVisualStyleBackColor = true;
            // 
            // SoundChanges
            // 
            this.SoundChanges.AcceptsTab = false;
            this.SoundChanges.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.SoundChanges.AutoIndent = false;
            this.SoundChanges.AutoIndentCharsPatterns = "";
            this.SoundChanges.AutoScrollMinSize = new System.Drawing.Size(0, 39);
            this.SoundChanges.BackBrush = null;
            this.SoundChanges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoundChanges.CharHeight = 39;
            this.SoundChanges.CharWidth = 20;
            this.SoundChanges.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SoundChanges.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.SoundChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SoundChanges.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.SoundChanges.IsReplaceMode = false;
            this.SoundChanges.LineInterval = 3;
            this.SoundChanges.Location = new System.Drawing.Point(484, 31);
            this.SoundChanges.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.SoundChanges.Name = "SoundChanges";
            this.SoundChanges.Paddings = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.SetRowSpan(this.SoundChanges, 2);
            this.SoundChanges.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.SoundChanges.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("SoundChanges.ServiceColors")));
            this.SoundChanges.ShowLineNumbers = false;
            this.SoundChanges.Size = new System.Drawing.Size(433, 1079);
            this.SoundChanges.TabIndex = 3;
            this.SoundChanges.WordWrap = true;
            this.SoundChanges.Zoom = 100;
            this.SoundChanges.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.SoundChanges_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Output);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1831, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel2.Name = "panel2";
            this.tableLayoutPanel1.SetRowSpan(this.panel2, 2);
            this.panel2.Size = new System.Drawing.Size(433, 1079);
            this.panel2.TabIndex = 6;
            // 
            // Output
            // 
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Output.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(0, 0);
            this.Output.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(431, 1077);
            this.Output.TabIndex = 7;
            this.Output.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "All files|*.esc;*.lex|exSCA files (*.esc)|*.esc|LEX files (*.lex)|*.lex";
            this.openFileDialog1.Multiselect = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "exSCA files (*.esc)|*.esc|LEX files (*.lex)|*.lex";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2299, 1199);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Main";
            this.Text = "exSCA";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Categories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rewrite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvancedRewrite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SyllabificationBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoundChanges)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private FastColoredTextBoxNS.FastColoredTextBox Categories;
        private FastColoredTextBoxNS.FastColoredTextBox Rewrite;
        private FastColoredTextBoxNS.FastColoredTextBox AdvancedRewrite;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem declinerToolStripMenuItem;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton BracketedOutput;
        private System.Windows.Forms.RadioButton ArrowedOutput;
        private System.Windows.Forms.RadioButton PlainOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FastColoredTextBoxNS.FastColoredTextBox SoundChanges;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ShowChanges;
        private System.Windows.Forms.CheckBox RewriteOnOutput;
        private System.Windows.Forms.CheckBox ReportRules;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem pythonEditorToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private FastColoredTextBoxNS.FastColoredTextBox SyllabificationBox;
        private System.Windows.Forms.Button SyllabifyHelpButton;
        public FastColoredTextBoxNS.FastColoredTextBox Input;
    }
}

