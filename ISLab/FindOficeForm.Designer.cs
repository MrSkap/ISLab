
namespace ISLab
{
	partial class FindOfficeForm
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
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.CountOfWorkersComboBox = new System.Windows.Forms.ComboBox();
			this.ParkingCheckBox = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.FloorComboBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.CountOfRoomsComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.InfastuctureLabel = new System.Windows.Forms.Label();
			this.InfastuctureComboBox = new System.Windows.Forms.ComboBox();
			this.YearsLabel = new System.Windows.Forms.Label();
			this.YearsComboBox = new System.Windows.Forms.ComboBox();
			this.SquareLabel = new System.Windows.Forms.Label();
			this.SquareComboBox = new System.Windows.Forms.ComboBox();
			this.ChoosePriceLabel = new System.Windows.Forms.Label();
			this.PriceComboBox = new System.Windows.Forms.ComboBox();
			this.NextButton = new System.Windows.Forms.Button();
			this.GoBackButton = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.CountOfWorkersComboBox);
			this.panel1.Controls.Add(this.ParkingCheckBox);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.FloorComboBox);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.CountOfRoomsComboBox);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.InfastuctureLabel);
			this.panel1.Controls.Add(this.InfastuctureComboBox);
			this.panel1.Controls.Add(this.YearsLabel);
			this.panel1.Controls.Add(this.YearsComboBox);
			this.panel1.Controls.Add(this.SquareLabel);
			this.panel1.Controls.Add(this.SquareComboBox);
			this.panel1.Controls.Add(this.ChoosePriceLabel);
			this.panel1.Controls.Add(this.PriceComboBox);
			this.panel1.Location = new System.Drawing.Point(12, 15);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(552, 623);
			this.panel1.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(280, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(145, 17);
			this.label4.TabIndex = 18;
			this.label4.Text = "Месторасположение";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "В центре",
            "Не в центре"});
			this.comboBox1.Location = new System.Drawing.Point(280, 29);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(225, 24);
			this.comboBox1.TabIndex = 17;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// CountOfWorkersComboBox
			// 
			this.CountOfWorkersComboBox.FormattingEnabled = true;
			this.CountOfWorkersComboBox.Items.AddRange(new object[] {
            "до 10",
            "10 - 20",
            "20 - 50",
            "> 50"});
			this.CountOfWorkersComboBox.Location = new System.Drawing.Point(6, 431);
			this.CountOfWorkersComboBox.Name = "CountOfWorkersComboBox";
			this.CountOfWorkersComboBox.Size = new System.Drawing.Size(219, 24);
			this.CountOfWorkersComboBox.TabIndex = 16;
			this.CountOfWorkersComboBox.SelectedIndexChanged += new System.EventHandler(this.CountOfWorkersComboBox_SelectedIndexChanged);
			// 
			// ParkingCheckBox
			// 
			this.ParkingCheckBox.AutoSize = true;
			this.ParkingCheckBox.Location = new System.Drawing.Point(12, 349);
			this.ParkingCheckBox.Name = "ParkingCheckBox";
			this.ParkingCheckBox.Size = new System.Drawing.Size(93, 21);
			this.ParkingCheckBox.TabIndex = 15;
			this.ParkingCheckBox.Text = "Парковка";
			this.ParkingCheckBox.UseVisualStyleBackColor = true;
			this.ParkingCheckBox.CheckedChanged += new System.EventHandler(this.ParkingCheckBox_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 540);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 17);
			this.label3.TabIndex = 14;
			this.label3.Text = "Этаж";
			// 
			// FloorComboBox
			// 
			this.FloorComboBox.FormattingEnabled = true;
			this.FloorComboBox.Items.AddRange(new object[] {
            "1",
            "1-2",
            ">2"});
			this.FloorComboBox.Location = new System.Drawing.Point(9, 560);
			this.FloorComboBox.Name = "FloorComboBox";
			this.FloorComboBox.Size = new System.Drawing.Size(219, 24);
			this.FloorComboBox.TabIndex = 13;
			this.FloorComboBox.SelectedIndexChanged += new System.EventHandler(this.FloorComboBox_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 473);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(166, 17);
			this.label2.TabIndex = 12;
			this.label2.Text = "Количество помещений";
			// 
			// CountOfRoomsComboBox
			// 
			this.CountOfRoomsComboBox.FormattingEnabled = true;
			this.CountOfRoomsComboBox.Items.AddRange(new object[] {
            "1-2",
            "2-5",
            "5-10",
            ">10"});
			this.CountOfRoomsComboBox.Location = new System.Drawing.Point(9, 493);
			this.CountOfRoomsComboBox.Name = "CountOfRoomsComboBox";
			this.CountOfRoomsComboBox.Size = new System.Drawing.Size(219, 24);
			this.CountOfRoomsComboBox.TabIndex = 11;
			this.CountOfRoomsComboBox.SelectedIndexChanged += new System.EventHandler(this.CountOfRoomsComboBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 411);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 17);
			this.label1.TabIndex = 10;
			this.label1.Text = "Количество персонала";
			// 
			// InfastuctureLabel
			// 
			this.InfastuctureLabel.AutoSize = true;
			this.InfastuctureLabel.Location = new System.Drawing.Point(9, 251);
			this.InfastuctureLabel.Name = "InfastuctureLabel";
			this.InfastuctureLabel.Size = new System.Drawing.Size(119, 17);
			this.InfastuctureLabel.TabIndex = 7;
			this.InfastuctureLabel.Text = "Инфраструктура";
			// 
			// InfastuctureComboBox
			// 
			this.InfastuctureComboBox.FormattingEnabled = true;
			this.InfastuctureComboBox.Items.AddRange(new object[] {
            "Развитая",
            "Не развитая"});
			this.InfastuctureComboBox.Location = new System.Drawing.Point(9, 271);
			this.InfastuctureComboBox.Name = "InfastuctureComboBox";
			this.InfastuctureComboBox.Size = new System.Drawing.Size(219, 24);
			this.InfastuctureComboBox.TabIndex = 6;
			this.InfastuctureComboBox.SelectedIndexChanged += new System.EventHandler(this.InfastuctureComboBox_SelectedIndexChanged);
			// 
			// YearsLabel
			// 
			this.YearsLabel.AutoSize = true;
			this.YearsLabel.Location = new System.Drawing.Point(9, 170);
			this.YearsLabel.Name = "YearsLabel";
			this.YearsLabel.Size = new System.Drawing.Size(113, 17);
			this.YearsLabel.TabIndex = 5;
			this.YearsLabel.Text = "Возраст здания";
			// 
			// YearsComboBox
			// 
			this.YearsComboBox.FormattingEnabled = true;
			this.YearsComboBox.Items.AddRange(new object[] {
            "Еще строится",
            "меньше 10 лет",
            "10-15 лет",
            "15-30 лет",
            "больше 30 лет"});
			this.YearsComboBox.Location = new System.Drawing.Point(9, 190);
			this.YearsComboBox.Name = "YearsComboBox";
			this.YearsComboBox.Size = new System.Drawing.Size(219, 24);
			this.YearsComboBox.TabIndex = 4;
			this.YearsComboBox.SelectedIndexChanged += new System.EventHandler(this.YearsComboBox_SelectedIndexChanged);
			// 
			// SquareLabel
			// 
			this.SquareLabel.AutoSize = true;
			this.SquareLabel.Location = new System.Drawing.Point(6, 89);
			this.SquareLabel.Name = "SquareLabel";
			this.SquareLabel.Size = new System.Drawing.Size(68, 17);
			this.SquareLabel.TabIndex = 3;
			this.SquareLabel.Text = "Площадь";
			// 
			// SquareComboBox
			// 
			this.SquareComboBox.FormattingEnabled = true;
			this.SquareComboBox.Items.AddRange(new object[] {
            "< 50",
            "50 - 200",
            "> 200"});
			this.SquareComboBox.Location = new System.Drawing.Point(6, 109);
			this.SquareComboBox.Name = "SquareComboBox";
			this.SquareComboBox.Size = new System.Drawing.Size(222, 24);
			this.SquareComboBox.TabIndex = 2;
			this.SquareComboBox.SelectedIndexChanged += new System.EventHandler(this.SquareComboBox_SelectedIndexChanged);
			// 
			// ChoosePriceLabel
			// 
			this.ChoosePriceLabel.AutoSize = true;
			this.ChoosePriceLabel.Location = new System.Drawing.Point(3, 9);
			this.ChoosePriceLabel.Name = "ChoosePriceLabel";
			this.ChoosePriceLabel.Size = new System.Drawing.Size(59, 17);
			this.ChoosePriceLabel.TabIndex = 1;
			this.ChoosePriceLabel.Text = "Бюджет";
			// 
			// PriceComboBox
			// 
			this.PriceComboBox.FormattingEnabled = true;
			this.PriceComboBox.Items.AddRange(new object[] {
            "< 1000000",
            "1000000 - 3000000",
            "3000000 - 6000000",
            "> 6000000"});
			this.PriceComboBox.Location = new System.Drawing.Point(3, 29);
			this.PriceComboBox.Name = "PriceComboBox";
			this.PriceComboBox.Size = new System.Drawing.Size(225, 24);
			this.PriceComboBox.TabIndex = 0;
			this.PriceComboBox.SelectedIndexChanged += new System.EventHandler(this.PriceComboBox_SelectedIndexChanged_1);
			// 
			// NextButton
			// 
			this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NextButton.Location = new System.Drawing.Point(592, 15);
			this.NextButton.Name = "NextButton";
			this.NextButton.Size = new System.Drawing.Size(167, 69);
			this.NextButton.TabIndex = 5;
			this.NextButton.Text = "Далее";
			this.NextButton.UseVisualStyleBackColor = true;
			this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
			// 
			// GoBackButton
			// 
			this.GoBackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.GoBackButton.Location = new System.Drawing.Point(592, 503);
			this.GoBackButton.Name = "GoBackButton";
			this.GoBackButton.Size = new System.Drawing.Size(167, 69);
			this.GoBackButton.TabIndex = 3;
			this.GoBackButton.Text = "Назад";
			this.GoBackButton.UseVisualStyleBackColor = true;
			this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click_1);
			// 
			// FindOfficeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(771, 650);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.NextButton);
			this.Controls.Add(this.GoBackButton);
			this.Name = "FindOfficeForm";
			this.Text = "Подбор офиса";
			this.Load += new System.EventHandler(this.FindForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox FloorComboBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox CountOfRoomsComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label InfastuctureLabel;
		private System.Windows.Forms.ComboBox InfastuctureComboBox;
		private System.Windows.Forms.Label YearsLabel;
		private System.Windows.Forms.ComboBox YearsComboBox;
		private System.Windows.Forms.Label SquareLabel;
		private System.Windows.Forms.ComboBox SquareComboBox;
		private System.Windows.Forms.Label ChoosePriceLabel;
		private System.Windows.Forms.ComboBox PriceComboBox;
		private System.Windows.Forms.Button NextButton;
		private System.Windows.Forms.Button GoBackButton;
		private System.Windows.Forms.CheckBox ParkingCheckBox;
		private System.Windows.Forms.ComboBox CountOfWorkersComboBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}