
namespace ISLab
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.officeButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SteadButton = new System.Windows.Forms.Button();
			this.HouseButton = new System.Windows.Forms.Button();
			this.ApartmentButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// officeButton
			// 
			this.officeButton.Location = new System.Drawing.Point(90, 276);
			this.officeButton.Name = "officeButton";
			this.officeButton.Size = new System.Drawing.Size(229, 88);
			this.officeButton.TabIndex = 0;
			this.officeButton.Text = "Офис";
			this.officeButton.UseVisualStyleBackColor = true;
			this.officeButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(480, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Подбор Недвижимости";
			// 
			// SteadButton
			// 
			this.SteadButton.Location = new System.Drawing.Point(90, 428);
			this.SteadButton.Name = "SteadButton";
			this.SteadButton.Size = new System.Drawing.Size(228, 88);
			this.SteadButton.TabIndex = 2;
			this.SteadButton.Text = "Земельный участок";
			this.SteadButton.UseVisualStyleBackColor = true;
			this.SteadButton.Click += new System.EventHandler(this.SteadButton_Click);
			// 
			// HouseButton
			// 
			this.HouseButton.Location = new System.Drawing.Point(794, 428);
			this.HouseButton.Name = "HouseButton";
			this.HouseButton.Size = new System.Drawing.Size(228, 88);
			this.HouseButton.TabIndex = 4;
			this.HouseButton.Text = "Дом";
			this.HouseButton.UseVisualStyleBackColor = true;
			this.HouseButton.Click += new System.EventHandler(this.HouseButton_Click);
			// 
			// ApartmentButton
			// 
			this.ApartmentButton.Location = new System.Drawing.Point(794, 276);
			this.ApartmentButton.Name = "ApartmentButton";
			this.ApartmentButton.Size = new System.Drawing.Size(229, 88);
			this.ApartmentButton.TabIndex = 3;
			this.ApartmentButton.Text = "Квартира";
			this.ApartmentButton.UseVisualStyleBackColor = true;
			this.ApartmentButton.Click += new System.EventHandler(this.ApartmentButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1083, 709);
			this.Controls.Add(this.HouseButton);
			this.Controls.Add(this.ApartmentButton);
			this.Controls.Add(this.SteadButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.officeButton);
			this.Name = "MainForm";
			this.Text = "Подбор недвижимости";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button officeButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button SteadButton;
		private System.Windows.Forms.Button HouseButton;
		private System.Windows.Forms.Button ApartmentButton;
	}
}

