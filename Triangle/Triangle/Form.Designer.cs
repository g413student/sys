namespace Triangle
{
    partial class Form
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitle.Location = new System.Drawing.Point(258, 80);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(548, 41);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Введите длины сторон треугольника";
            // 
            // tbA
            // 
            this.tbA.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbA.Location = new System.Drawing.Point(104, 184);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(168, 44);
            this.tbA.TabIndex = 2;
            // 
            // tbB
            // 
            this.tbB.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbB.Location = new System.Drawing.Point(429, 184);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(168, 44);
            this.tbB.TabIndex = 3;
            // 
            // tbC
            // 
            this.tbC.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbC.Location = new System.Drawing.Point(740, 184);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(168, 44);
            this.tbC.TabIndex = 4;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Yellow;
            this.btnCheck.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheck.Location = new System.Drawing.Point(398, 321);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(231, 65);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.ForeColor = System.Drawing.SystemColors.Control;
            this.labelResult.Location = new System.Drawing.Point(258, 470);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 41);
            this.labelResult.TabIndex = 6;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1079, 590);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form";
            this.Text = "Треугольник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label labelResult;
    }
}

