
namespace lab3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxColor = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBoxRed = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxGreen = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxBlue = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemColor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "&Color";
            // 
            // toolStripMenuItemColor
            // 
            this.toolStripMenuItemColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxColor,
            this.toolStripTextBoxRed,
            this.toolStripTextBoxGreen,
            this.toolStripTextBoxBlue,
            this.toolStripSeparator1,
            this.toolStripMenuExit});
            this.toolStripMenuItemColor.Name = "toolStripMenuItemColor";
            this.toolStripMenuItemColor.Size = new System.Drawing.Size(59, 24);
            this.toolStripMenuItemColor.Text = "&Color";
            // 
            // toolStripComboBoxColor
            // 
            this.toolStripComboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxColor.Items.AddRange(new object[] {
            "Белый",
            "Красный",
            "Чёрный",
            "Синий",
            "Жёлтый"});
            this.toolStripComboBoxColor.Name = "toolStripComboBoxColor";
            this.toolStripComboBoxColor.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBoxColor.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // toolStripTextBoxRed
            // 
            this.toolStripTextBoxRed.Name = "toolStripTextBoxRed";
            this.toolStripTextBoxRed.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBoxRed.Text = "0";
            this.toolStripTextBoxRed.ToolTipText = "red";
            this.toolStripTextBoxRed.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripTextBoxGreen
            // 
            this.toolStripTextBoxGreen.Name = "toolStripTextBoxGreen";
            this.toolStripTextBoxGreen.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBoxGreen.Text = "0";
            this.toolStripTextBoxGreen.ToolTipText = "green";
            this.toolStripTextBoxGreen.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripTextBoxBlue
            // 
            this.toolStripTextBoxBlue.Name = "toolStripTextBoxBlue";
            this.toolStripTextBoxBlue.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBoxBlue.Text = "0";
            this.toolStripTextBoxBlue.ToolTipText = "blue";
            this.toolStripTextBoxBlue.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // toolStripMenuExit
            // 
            this.toolStripMenuExit.Name = "toolStripMenuExit";
            this.toolStripMenuExit.Size = new System.Drawing.Size(195, 26);
            this.toolStripMenuExit.Text = "E&xit";
            this.toolStripMenuExit.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripTextBox1,
            this.toolStripTextBox2,
            this.toolStripTextBox3,
            this.toolStripSeparator2,
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(114, 24);
            this.toolStripMenuItem1.Text = "&Color";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Белый",
            "Красный",
            "Чёрный",
            "Синий",
            "Жёлтый"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox1.TextChanged += new System.EventHandler(this.toolStripComboBox1_TextChanged);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "red";
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged_1);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "green";
            this.toolStripTextBox2.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged_1);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox3.Text = "0";
            this.toolStripTextBox3.ToolTipText = "blue";
            this.toolStripTextBox3.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(195, 26);
            this.toolStripMenuItem2.Text = "E&xit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemColor;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxColor;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxRed;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxGreen;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxBlue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemColors;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

