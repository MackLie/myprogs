namespace CountOfSymbolsWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblString = new System.Windows.Forms.Label();
            this.tbFirstString = new System.Windows.Forms.TextBox();
            this.lblSymbols = new System.Windows.Forms.Label();
            this.tbSymbols = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Location = new System.Drawing.Point(12, 22);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(120, 17);
            this.lblString.TabIndex = 0;
            this.lblString.Text = "Исходная строка";
            // 
            // tbFirstString
            // 
            this.tbFirstString.Location = new System.Drawing.Point(163, 17);
            this.tbFirstString.Name = "tbFirstString";
            this.tbFirstString.Size = new System.Drawing.Size(459, 22);
            this.tbFirstString.TabIndex = 1;
            // 
            // lblSymbols
            // 
            this.lblSymbols.AutoSize = true;
            this.lblSymbols.Location = new System.Drawing.Point(12, 61);
            this.lblSymbols.Name = "lblSymbols";
            this.lblSymbols.Size = new System.Drawing.Size(145, 17);
            this.lblSymbols.TabIndex = 2;
            this.lblSymbols.Text = "Символы для поиска";
            // 
            // tbSymbols
            // 
            this.tbSymbols.Location = new System.Drawing.Point(163, 58);
            this.tbSymbols.Name = "tbSymbols";
            this.tbSymbols.Size = new System.Drawing.Size(459, 22);
            this.tbSymbols.TabIndex = 3;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(15, 98);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Пуск";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(163, 130);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResult.Size = new System.Drawing.Size(290, 111);
            this.tbResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 253);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.tbSymbols);
            this.Controls.Add(this.lblSymbols);
            this.Controls.Add(this.tbFirstString);
            this.Controls.Add(this.lblString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.TextBox tbFirstString;
        private System.Windows.Forms.Label lblSymbols;
        private System.Windows.Forms.TextBox tbSymbols;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox tbResult;
    }
}

