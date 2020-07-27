namespace Task01
{
	partial class frmDoubler
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
			this.lblNumber = new System.Windows.Forms.Label();
			this.btnPlus = new System.Windows.Forms.Button();
			this.btnDouble = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblNumber
			// 
			this.lblNumber.AutoSize = true;
			this.lblNumber.Location = new System.Drawing.Point(13, 13);
			this.lblNumber.Name = "lblNumber";
			this.lblNumber.Size = new System.Drawing.Size(35, 13);
			this.lblNumber.TabIndex = 0;
			this.lblNumber.Text = "label1";
			// 
			// btnPlus
			// 
			this.btnPlus.Location = new System.Drawing.Point(16, 29);
			this.btnPlus.Name = "btnPlus";
			this.btnPlus.Size = new System.Drawing.Size(75, 23);
			this.btnPlus.TabIndex = 1;
			this.btnPlus.Text = "+ 1";
			this.btnPlus.UseVisualStyleBackColor = true;
			this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
			// 
			// btnDouble
			// 
			this.btnDouble.Location = new System.Drawing.Point(16, 58);
			this.btnDouble.Name = "btnDouble";
			this.btnDouble.Size = new System.Drawing.Size(75, 23);
			this.btnDouble.TabIndex = 2;
			this.btnDouble.Text = "x 2";
			this.btnDouble.UseVisualStyleBackColor = true;
			this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnOK.Location = new System.Drawing.Point(299, 248);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// frmDoubler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 281);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnDouble);
			this.Controls.Add(this.btnPlus);
			this.Controls.Add(this.lblNumber);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximumSize = new System.Drawing.Size(400, 320);
			this.MinimumSize = new System.Drawing.Size(200, 0);
			this.Name = "frmDoubler";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Удвоитель";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label lblNumber;
		private System.Windows.Forms.Button btnPlus;
		private System.Windows.Forms.Button btnDouble;
		private System.Windows.Forms.Button btnOK;
	}
}

