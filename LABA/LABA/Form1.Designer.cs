namespace AudioGuess
{
    partial class Form1
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
            this.folderButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(44, 23);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(189, 23);
            this.folderButton.TabIndex = 0;
            this.folderButton.Text = "Выбор папки";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.SelectFilesButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(44, 66);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(189, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(305, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(231, 97);
            this.button3.TabIndex = 2;
            this.button3.Text = "Воспроизвести ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(44, 340);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(153, 76);
            this.a1.TabIndex = 3;
            this.a1.Text = "button4";
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.ObChooseButtonPressed);
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(343, 340);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(153, 76);
            this.a2.TabIndex = 4;
            this.a2.Text = "button5";
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.ObChooseButtonPressed);
            // 
            // a3
            // 
            this.a3.Location = new System.Drawing.Point(635, 340);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(153, 76);
            this.a3.TabIndex = 5;
            this.a3.Text = "button6";
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.ObChooseButtonPressed);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(44, 96);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(44, 16);
            this.pathLabel.TabIndex = 6;
            this.pathLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.folderButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosedForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Label pathLabel;
    }
}

