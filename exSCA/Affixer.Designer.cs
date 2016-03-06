namespace exSCA
{
    partial class Affixer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Prefixes = new System.Windows.Forms.TextBox();
            this.Stems = new System.Windows.Forms.TextBox();
            this.Suffixes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Preview = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.Cancel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.OK, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Prefixes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Stems, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Suffixes, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Preview, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(455, 269);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Cancel
            // 
            this.Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancel.Location = new System.Drawing.Point(305, 240);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(147, 26);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OK.Location = new System.Drawing.Point(154, 240);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(145, 26);
            this.OK.TabIndex = 7;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(305, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Suffixes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(154, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stems";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Prefixes
            // 
            this.Prefixes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Prefixes.Location = new System.Drawing.Point(3, 19);
            this.Prefixes.Multiline = true;
            this.Prefixes.Name = "Prefixes";
            this.Prefixes.Size = new System.Drawing.Size(145, 215);
            this.Prefixes.TabIndex = 0;
            this.Prefixes.Text = "*";
            // 
            // Stems
            // 
            this.Stems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Stems.Location = new System.Drawing.Point(154, 19);
            this.Stems.Multiline = true;
            this.Stems.Name = "Stems";
            this.Stems.Size = new System.Drawing.Size(145, 215);
            this.Stems.TabIndex = 1;
            // 
            // Suffixes
            // 
            this.Suffixes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Suffixes.Location = new System.Drawing.Point(305, 19);
            this.Suffixes.Multiline = true;
            this.Suffixes.Name = "Suffixes";
            this.Suffixes.Size = new System.Drawing.Size(147, 215);
            this.Suffixes.TabIndex = 2;
            this.Suffixes.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prefixes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Preview
            // 
            this.Preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Preview.Location = new System.Drawing.Point(3, 240);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(145, 26);
            this.Preview.TabIndex = 6;
            this.Preview.Text = "Preview";
            this.Preview.UseVisualStyleBackColor = true;
            this.Preview.Click += new System.EventHandler(this.Preview_Click);
            // 
            // Affixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 269);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Affixer";
            this.Text = "Decliner/Conjugator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Affixer_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Prefixes;
        private System.Windows.Forms.TextBox Stems;
        private System.Windows.Forms.TextBox Suffixes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Preview;
    }
}