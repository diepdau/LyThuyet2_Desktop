namespace BaiTap_T48
{
	partial class Form1
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.biafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bai12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bai13ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bài112ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bài113ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
			this.bài14ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biafToolStripMenuItem,
            this.toolStripComboBox1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(129, 450);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// biafToolStripMenuItem
			// 
			this.biafToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bai12ToolStripMenuItem,
            this.bai13ToolStripMenuItem,
            this.bài14ToolStripMenuItem});
			this.biafToolStripMenuItem.Name = "biafToolStripMenuItem";
			this.biafToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
			this.biafToolStripMenuItem.Text = "Bai 1";
			this.biafToolStripMenuItem.Click += new System.EventHandler(this.biafToolStripMenuItem_Click);
			// 
			// bai12ToolStripMenuItem
			// 
			this.bai12ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bài112ToolStripMenuItem});
			this.bai12ToolStripMenuItem.Name = "bai12ToolStripMenuItem";
			this.bai12ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.bai12ToolStripMenuItem.Text = "Bai 1.2";
			// 
			// bai13ToolStripMenuItem
			// 
			this.bai13ToolStripMenuItem.Name = "bai13ToolStripMenuItem";
			this.bai13ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.bai13ToolStripMenuItem.Text = "Bai 1.3";
			// 
			// bài112ToolStripMenuItem
			// 
			this.bài112ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bài113ToolStripMenuItem});
			this.bài112ToolStripMenuItem.Name = "bài112ToolStripMenuItem";
			this.bài112ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.bài112ToolStripMenuItem.Text = "Bài 1.1.2";
			// 
			// bài113ToolStripMenuItem
			// 
			this.bài113ToolStripMenuItem.Name = "bài113ToolStripMenuItem";
			this.bài113ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.bài113ToolStripMenuItem.Text = "Bài 1.1.3";
			// 
			// toolStripComboBox1
			// 
			this.toolStripComboBox1.Name = "toolStripComboBox1";
			this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
			this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
			// 
			// bài14ToolStripMenuItem
			// 
			this.bài14ToolStripMenuItem.Name = "bài14ToolStripMenuItem";
			this.bài14ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.bài14ToolStripMenuItem.Text = "Bài 1.4";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Click += new System.EventHandler(this.toolStripComboBox1_Click);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem biafToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bai12ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bai13ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bài112ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bài113ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bài14ToolStripMenuItem;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
	}
}

