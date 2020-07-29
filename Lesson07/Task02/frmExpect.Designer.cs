namespace Task02
{
	partial class frmExpect
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
			this.btnSetRandom = new System.Windows.Forms.Button();
			this.txtPlay = new System.Windows.Forms.TextBox();
			this.lblPlay = new System.Windows.Forms.Label();
			this.txtHistory = new System.Windows.Forms.TextBox();
			this.lblHistory = new System.Windows.Forms.Label();
			this.btnAccept = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSetRandom
			// 
			this.btnSetRandom.Location = new System.Drawing.Point(13, 13);
			this.btnSetRandom.Name = "btnSetRandom";
			this.btnSetRandom.Size = new System.Drawing.Size(130, 23);
			this.btnSetRandom.TabIndex = 0;
			this.btnSetRandom.Text = "Загадать число";
			this.btnSetRandom.UseVisualStyleBackColor = true;
			this.btnSetRandom.Click += new System.EventHandler(this.btnSetRandom_Click);
			// 
			// txtPlay
			// 
			this.txtPlay.Location = new System.Drawing.Point(103, 45);
			this.txtPlay.Name = "txtPlay";
			this.txtPlay.Size = new System.Drawing.Size(100, 20);
			this.txtPlay.TabIndex = 1;
			this.txtPlay.Visible = false;
			this.txtPlay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlay_KeyPress);
			// 
			// lblPlay
			// 
			this.lblPlay.AutoSize = true;
			this.lblPlay.Location = new System.Drawing.Point(13, 48);
			this.lblPlay.Name = "lblPlay";
			this.lblPlay.Size = new System.Drawing.Size(84, 13);
			this.lblPlay.TabIndex = 2;
			this.lblPlay.Text = "Введите число:";
			this.lblPlay.Visible = false;
			// 
			// txtHistory
			// 
			this.txtHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtHistory.Enabled = false;
			this.txtHistory.Location = new System.Drawing.Point(210, 45);
			this.txtHistory.Multiline = true;
			this.txtHistory.Name = "txtHistory";
			this.txtHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtHistory.Size = new System.Drawing.Size(586, 369);
			this.txtHistory.TabIndex = 3;
			this.txtHistory.Visible = false;
			// 
			// lblHistory
			// 
			this.lblHistory.AutoSize = true;
			this.lblHistory.Location = new System.Drawing.Point(210, 22);
			this.lblHistory.Name = "lblHistory";
			this.lblHistory.Size = new System.Drawing.Size(100, 13);
			this.lblHistory.TabIndex = 4;
			this.lblHistory.Text = "История действий";
			this.lblHistory.Visible = false;
			// 
			// btnAccept
			// 
			this.btnAccept.Location = new System.Drawing.Point(128, 71);
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.Size = new System.Drawing.Size(75, 23);
			this.btnAccept.TabIndex = 5;
			this.btnAccept.Text = "Принять";
			this.btnAccept.UseVisualStyleBackColor = true;
			this.btnAccept.Visible = false;
			this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnClose.Location = new System.Drawing.Point(720, 420);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Закрыть";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmExpect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(808, 455);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnAccept);
			this.Controls.Add(this.lblHistory);
			this.Controls.Add(this.txtHistory);
			this.Controls.Add(this.lblPlay);
			this.Controls.Add(this.txtPlay);
			this.Controls.Add(this.btnSetRandom);
			this.Name = "frmExpect";
			this.Text = "Угадывание числа";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSetRandom;
		private System.Windows.Forms.TextBox txtPlay;
		private System.Windows.Forms.Label lblPlay;
		private System.Windows.Forms.TextBox txtHistory;
		private System.Windows.Forms.Label lblHistory;
		private System.Windows.Forms.Button btnAccept;
		private System.Windows.Forms.Button btnClose;
	}
}

