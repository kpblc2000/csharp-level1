namespace Task02
{
	partial class frmMain
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
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
			this.groupBoxEvents = new System.Windows.Forms.GroupBox();
			this.numericUpDown = new System.Windows.Forms.NumericUpDown();
			this.textBox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxBack = new System.Windows.Forms.TextBox();
			this.numericUpDownBack = new System.Windows.Forms.NumericUpDown();
			this.groupBoxEvents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownBack)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBoxEvents
			// 
			this.groupBoxEvents.Controls.Add(this.numericUpDown);
			this.groupBoxEvents.Controls.Add(this.textBox);
			this.groupBoxEvents.Location = new System.Drawing.Point(12, 12);
			this.groupBoxEvents.Name = "groupBoxEvents";
			this.groupBoxEvents.Size = new System.Drawing.Size(143, 78);
			this.groupBoxEvents.TabIndex = 2;
			this.groupBoxEvents.TabStop = false;
			this.groupBoxEvents.Text = "Events from Num to Text";
			// 
			// numericUpDown
			// 
			this.numericUpDown.Location = new System.Drawing.Point(10, 19);
			this.numericUpDown.Name = "numericUpDown";
			this.numericUpDown.Size = new System.Drawing.Size(127, 20);
			this.numericUpDown.TabIndex = 3;
			this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
			// 
			// textBox
			// 
			this.textBox.Enabled = false;
			this.textBox.Location = new System.Drawing.Point(10, 45);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(127, 20);
			this.textBox.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericUpDownBack);
			this.groupBox1.Controls.Add(this.textBoxBack);
			this.groupBox1.Location = new System.Drawing.Point(161, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(141, 100);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Events from Text to Num";
			// 
			// textBoxBack
			// 
			this.textBoxBack.Location = new System.Drawing.Point(7, 20);
			this.textBoxBack.Name = "textBoxBack";
			this.textBoxBack.Size = new System.Drawing.Size(128, 20);
			this.textBoxBack.TabIndex = 0;
			this.textBoxBack.TextChanged += new System.EventHandler(this.textBoxBack_TextChanged);
			this.textBoxBack.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBack_KeyPress);
			// 
			// numericUpDownBack
			// 
			this.numericUpDownBack.Enabled = false;
			this.numericUpDownBack.Location = new System.Drawing.Point(7, 47);
			this.numericUpDownBack.Name = "numericUpDownBack";
			this.numericUpDownBack.Size = new System.Drawing.Size(128, 20);
			this.numericUpDownBack.TabIndex = 1;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBoxEvents);
			this.Name = "frmMain";
			this.Text = "Form1";
			this.groupBoxEvents.ResumeLayout(false);
			this.groupBoxEvents.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownBack)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxEvents;
		private System.Windows.Forms.NumericUpDown numericUpDown;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown numericUpDownBack;
		private System.Windows.Forms.TextBox textBoxBack;
	}
}

