namespace Task03
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuNewFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSaveFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.numCounter = new System.Windows.Forms.NumericUpDown();
			this.chkIsTrue = new System.Windows.Forms.CheckBox();
			this.textQuest = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCounter)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mnuFile
			// 
			this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewFile,
            this.mnuOpenFile,
            this.mnuSaveFile,
            this.toolStripSeparator1,
            this.mnuExit});
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size(48, 20);
			this.mnuFile.Text = "Файл";
			// 
			// mnuNewFile
			// 
			this.mnuNewFile.Name = "mnuNewFile";
			this.mnuNewFile.Size = new System.Drawing.Size(180, 22);
			this.mnuNewFile.Text = "Новый файл";
			this.mnuNewFile.Click += new System.EventHandler(this.mnuNewFile_Click);
			// 
			// mnuOpenFile
			// 
			this.mnuOpenFile.Name = "mnuOpenFile";
			this.mnuOpenFile.Size = new System.Drawing.Size(180, 22);
			this.mnuOpenFile.Text = "Открыть...";
			this.mnuOpenFile.Click += new System.EventHandler(this.mnuOpenFile_Click);
			// 
			// mnuSaveFile
			// 
			this.mnuSaveFile.Name = "mnuSaveFile";
			this.mnuSaveFile.Size = new System.Drawing.Size(180, 22);
			this.mnuSaveFile.Text = "Сохранить...";
			this.mnuSaveFile.Click += new System.EventHandler(this.mnuSaveFile_Click);
			// 
			// mnuExit
			// 
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.Size = new System.Drawing.Size(180, 22);
			this.mnuExit.Text = "Выход";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAdd.Location = new System.Drawing.Point(335, 416);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(177, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Добавить вопрос";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnRemove.Location = new System.Drawing.Point(518, 416);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(189, 23);
			this.btnRemove.TabIndex = 5;
			this.btnRemove.Text = "Удалить вопрос";
			this.btnRemove.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSave.Location = new System.Drawing.Point(713, 416);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Сохранить...";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// numCounter
			// 
			this.numCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.numCounter.Location = new System.Drawing.Point(83, 415);
			this.numCounter.Name = "numCounter";
			this.numCounter.Size = new System.Drawing.Size(120, 20);
			this.numCounter.TabIndex = 50;
			this.numCounter.ValueChanged += new System.EventHandler(this.numCounter_ValueChanged);
			// 
			// chkIsTrue
			// 
			this.chkIsTrue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.chkIsTrue.AutoSize = true;
			this.chkIsTrue.Location = new System.Drawing.Point(13, 416);
			this.chkIsTrue.Name = "chkIsTrue";
			this.chkIsTrue.Size = new System.Drawing.Size(64, 17);
			this.chkIsTrue.TabIndex = 2;
			this.chkIsTrue.Text = "Правда";
			this.chkIsTrue.UseVisualStyleBackColor = true;
			this.chkIsTrue.CheckedChanged += new System.EventHandler(this.chkIsTrue_CheckedChanged);
			// 
			// textQuest
			// 
			this.textQuest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textQuest.Location = new System.Drawing.Point(13, 28);
			this.textQuest.Multiline = true;
			this.textQuest.Name = "textQuest";
			this.textQuest.Size = new System.Drawing.Size(775, 382);
			this.textQuest.TabIndex = 1;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textQuest);
			this.Controls.Add(this.chkIsTrue);
			this.Controls.Add(this.numCounter);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMain";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCounter)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mnuFile;
		private System.Windows.Forms.ToolStripMenuItem mnuNewFile;
		private System.Windows.Forms.ToolStripMenuItem mnuOpenFile;
		private System.Windows.Forms.ToolStripMenuItem mnuSaveFile;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.NumericUpDown numCounter;
		private System.Windows.Forms.CheckBox chkIsTrue;
		private System.Windows.Forms.TextBox textQuest;
	}
}

