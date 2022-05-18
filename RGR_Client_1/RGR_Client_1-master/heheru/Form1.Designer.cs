namespace heheru
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
            this.Area = new System.Windows.Forms.TextBox();
            this.Vacancy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Area
            // 
            this.Area.Location = new System.Drawing.Point(236, 34);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(189, 20);
            this.Area.TabIndex = 0;
            // 
            // Vacancy
            // 
            this.Vacancy.Location = new System.Drawing.Point(236, 61);
            this.Vacancy.Name = "Vacancy";
            this.Vacancy.Size = new System.Drawing.Size(189, 20);
            this.Vacancy.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Регион";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название вакансии";
            // 
            // fill
            // 
            this.fill.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fill.Location = new System.Drawing.Point(16, 113);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(435, 130);
            this.fill.TabIndex = 4;
            this.fill.Text = "Добавить данные";
            this.fill.UseVisualStyleBackColor = true;
            this.fill.Click += new System.EventHandler(this.fill_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 255);
            this.Controls.Add(this.fill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vacancy);
            this.Controls.Add(this.Area);
            this.Name = "Form1";
            this.Text = "RGR_1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Area;
        private System.Windows.Forms.TextBox Vacancy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fill;
    }
}

