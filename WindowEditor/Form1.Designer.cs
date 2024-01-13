namespace WindowEditor
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.renameButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.newWindowTitleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.windowTitleTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.renameButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.newWindowTitleTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.windowTitleTextBox);
            this.groupBox2.Controls.Add(this.closeButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 129);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменение заголовка или закрытие приложения";
            // 
            // renameButton
            // 
            this.renameButton.Location = new System.Drawing.Point(10, 100);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(104, 23);
            this.renameButton.TabIndex = 8;
            this.renameButton.Text = "Переименовать";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Новый заголовок";
            // 
            // newWindowTitleTextBox
            // 
            this.newWindowTitleTextBox.Location = new System.Drawing.Point(121, 59);
            this.newWindowTitleTextBox.Name = "newWindowTitleTextBox";
            this.newWindowTitleTextBox.Size = new System.Drawing.Size(295, 20);
            this.newWindowTitleTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Заголовок окна";
            // 
            // windowTitleTextBox
            // 
            this.windowTitleTextBox.Location = new System.Drawing.Point(121, 24);
            this.windowTitleTextBox.Name = "windowTitleTextBox";
            this.windowTitleTextBox.Size = new System.Drawing.Size(295, 20);
            this.windowTitleTextBox.TabIndex = 4;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(341, 100);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 153);
            this.Controls.Add(this.groupBox2);
            this.MaximumSize = new System.Drawing.Size(462, 192);
            this.MinimumSize = new System.Drawing.Size(462, 192);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Переименователь окон";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox windowTitleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newWindowTitleTextBox;
        private System.Windows.Forms.Button renameButton;
    }
}

