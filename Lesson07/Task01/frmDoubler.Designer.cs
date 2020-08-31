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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuMultiRange = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuPlay = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.lblPlayInfo = new System.Windows.Forms.Label();
			this.lblPlayNum = new System.Windows.Forms.Label();
			this.lblMinSteps = new System.Windows.Forms.Label();
			this.lblUserSteps = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblNumber
			// 
			this.lblNumber.AutoSize = true;
			this.lblNumber.Location = new System.Drawing.Point(21, 35);
			this.lblNumber.Name = "lblNumber";
			this.lblNumber.Size = new System.Drawing.Size(35, 13);
			this.lblNumber.TabIndex = 0;
			this.lblNumber.Text = "label1";
			// 
			// btnPlus
			// 
			this.btnPlus.Location = new System.Drawing.Point(24, 51);
			this.btnPlus.Name = "btnPlus";
			this.btnPlus.Size = new System.Drawing.Size(75, 23);
			this.btnPlus.TabIndex = 1;
			this.btnPlus.Text = "+ 1";
			this.btnPlus.UseVisualStyleBackColor = true;
			this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
			// 
			// btnDouble
			// 
			this.btnDouble.Location = new System.Drawing.Point(24, 80);
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
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сервисToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(384, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// сервисToolStripMenuItem
			// 
			this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMultiRange,
            this.mnuPlay,
            this.mnuExit});
			this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
			this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.сервисToolStripMenuItem.Text = "Сервис";
			// 
			// mnuMultiRange
			// 
			this.mnuMultiRange.Name = "mnuMultiRange";
			this.mnuMultiRange.Size = new System.Drawing.Size(233, 22);
			this.mnuMultiRange.Text = "Количество нажатий на \"x 2\"";
			this.mnuMultiRange.Click += new System.EventHandler(this.mnuMultiRange_Click);
			// 
			// mnuPlay
			// 
			this.mnuPlay.Name = "mnuPlay";
			this.mnuPlay.Size = new System.Drawing.Size(233, 22);
			this.mnuPlay.Text = "Играть";
			this.mnuPlay.Click += new System.EventHandler(this.mnuPlay_Click);
			// 
			// mnuExit
			// 
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.Size = new System.Drawing.Size(233, 22);
			this.mnuExit.Text = "Выход";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// lblPlayInfo
			// 
			this.lblPlayInfo.AutoSize = true;
			this.lblPlayInfo.Location = new System.Drawing.Point(24, 110);
			this.lblPlayInfo.Name = "lblPlayInfo";
			this.lblPlayInfo.Size = new System.Drawing.Size(167, 13);
			this.lblPlayInfo.TabIndex = 5;
			this.lblPlayInfo.Text = "Вам необходимо достичь числа";
			// 
			// lblPlayNum
			// 
			this.lblPlayNum.AutoSize = true;
			this.lblPlayNum.Location = new System.Drawing.Point(198, 109);
			this.lblPlayNum.Name = "lblPlayNum";
			this.lblPlayNum.Size = new System.Drawing.Size(35, 13);
			this.lblPlayNum.TabIndex = 6;
			this.lblPlayNum.Text = "label1";
			// 
			// lblMinSteps
			// 
			this.lblMinSteps.AutoSize = true;
			this.lblMinSteps.Location = new System.Drawing.Point(24, 160);
			this.lblMinSteps.Name = "lblMinSteps";
			this.lblMinSteps.Size = new System.Drawing.Size(35, 13);
			this.lblMinSteps.TabIndex = 7;
			this.lblMinSteps.Text = "label1";
			// 
			// lblUserSteps
			// 
			this.lblUserSteps.AutoSize = true;
			this.lblUserSteps.Location = new System.Drawing.Point(24, 133);
			this.lblUserSteps.Name = "lblUserSteps";
			this.lblUserSteps.Size = new System.Drawing.Size(35, 13);
			this.lblUserSteps.TabIndex = 8;
			this.lblUserSteps.Text = "label1";
			// 
			// frmDoubler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 281);
			this.Controls.Add(this.lblUserSteps);
			this.Controls.Add(this.lblMinSteps);
			this.Controls.Add(this.lblPlayNum);
			this.Controls.Add(this.lblPlayInfo);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnDouble);
			this.Controls.Add(this.btnPlus);
			this.Controls.Add(this.lblNumber);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(400, 320);
			this.MinimumSize = new System.Drawing.Size(200, 160);
			this.Name = "frmDoubler";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Удвоитель";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label lblNumber;
		private System.Windows.Forms.Button btnPlus;
		private System.Windows.Forms.Button btnDouble;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuMultiRange;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.Label lblPlayInfo;
		private System.Windows.Forms.Label lblPlayNum;
		private System.Windows.Forms.ToolStripMenuItem mnuPlay;
		private System.Windows.Forms.Label lblMinSteps;
		private System.Windows.Forms.Label lblUserSteps;
	}
}

