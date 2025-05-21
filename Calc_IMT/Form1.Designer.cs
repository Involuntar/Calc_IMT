namespace Calc_IMT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Gender = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gender
            // 
            this.Gender.BackColor = System.Drawing.Color.Transparent;
            this.Gender.Controls.Add(this.radioButton1);
            this.Gender.Controls.Add(this.radioButton2);
            this.Gender.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gender.Location = new System.Drawing.Point(28, 245);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(163, 83);
            this.Gender.TabIndex = 13;
            this.Gender.TabStop = false;
            this.Gender.Text = "Пол";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 38);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "М";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(104, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 38);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ж";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeightLabel.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightLabel.Location = new System.Drawing.Point(25, 133);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(68, 34);
            this.HeightLabel.TabIndex = 12;
            this.HeightLabel.Text = "Рост";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.WeightLabel.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeightLabel.Location = new System.Drawing.Point(25, 62);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(57, 34);
            this.WeightLabel.TabIndex = 11;
            this.WeightLabel.Text = "Вес";
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.Color.OrangeRed;
            this.Calculate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Calculate.FlatAppearance.BorderSize = 3;
            this.Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calculate.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculate.Location = new System.Drawing.Point(28, 351);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(198, 52);
            this.Calculate.TabIndex = 10;
            this.Calculate.Text = "Рассчитать";
            this.Calculate.UseVisualStyleBackColor = false;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightTextBox.Location = new System.Drawing.Point(100, 130);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(206, 40);
            this.HeightTextBox.TabIndex = 9;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeightTextBox.Location = new System.Drawing.Point(100, 59);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(206, 40);
            this.WeightTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.WeightTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Калькулятор ИМТ";
            this.Gender.ResumeLayout(false);
            this.Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gender;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
    }
}

