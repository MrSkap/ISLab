
namespace ISLab
{
	partial class ResultForm
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
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.BackButton = new System.Windows.Forms.Button();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.Controls.Add(this.richTextBox1);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1000, 700);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(3, 3);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(939, 694);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.BackButton);
			this.panel1.Location = new System.Drawing.Point(937, -2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(153, 700);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.flowLayoutPanel1);
			this.panel2.Location = new System.Drawing.Point(-1, -1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1000, 700);
			this.panel2.TabIndex = 2;
			// 
			// BackButton
			// 
			this.BackButton.Location = new System.Drawing.Point(10, 606);
			this.BackButton.Name = "BackButton";
			this.BackButton.Size = new System.Drawing.Size(132, 82);
			this.BackButton.TabIndex = 0;
			this.BackButton.Text = "Назад";
			this.BackButton.UseVisualStyleBackColor = true;
			this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
			// 
			// ResultForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1091, 698);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Name = "ResultForm";
			this.Text = "Подходящие варианты";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button BackButton;
	}
}