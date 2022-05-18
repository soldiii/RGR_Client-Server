namespace heheru_client
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
            this.label1 = new System.Windows.Forms.Label();
            this.vacId = new System.Windows.Forms.TextBox();
            this.vacDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vacName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.currency = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vacsalary_from = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vacsalary_to = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.snipreq = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.snipres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vacarea = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.vacexp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.vacskills = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.vacspec = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.POST = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.PUT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID вакансии";
            // 
            // vacId
            // 
            this.vacId.Location = new System.Drawing.Point(16, 30);
            this.vacId.Name = "vacId";
            this.vacId.Size = new System.Drawing.Size(100, 20);
            this.vacId.TabIndex = 1;
            // 
            // vacDescription
            // 
            this.vacDescription.Location = new System.Drawing.Point(122, 30);
            this.vacDescription.Name = "vacDescription";
            this.vacDescription.Size = new System.Drawing.Size(100, 20);
            this.vacDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание вакансии";
            // 
            // vacName
            // 
            this.vacName.Location = new System.Drawing.Point(228, 30);
            this.vacName.Name = "vacName";
            this.vacName.Size = new System.Drawing.Size(100, 20);
            this.vacName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Название вакансии";
            // 
            // currency
            // 
            this.currency.Location = new System.Drawing.Point(334, 30);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(100, 20);
            this.currency.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Валюта";
            // 
            // vacsalary_from
            // 
            this.vacsalary_from.Location = new System.Drawing.Point(440, 30);
            this.vacsalary_from.Name = "vacsalary_from";
            this.vacsalary_from.Size = new System.Drawing.Size(100, 20);
            this.vacsalary_from.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Нижняя граница зп";
            // 
            // vacsalary_to
            // 
            this.vacsalary_to.Location = new System.Drawing.Point(546, 30);
            this.vacsalary_to.Name = "vacsalary_to";
            this.vacsalary_to.Size = new System.Drawing.Size(100, 20);
            this.vacsalary_to.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Верхняя граница зп";
            // 
            // snipreq
            // 
            this.snipreq.Location = new System.Drawing.Point(16, 73);
            this.snipreq.Name = "snipreq";
            this.snipreq.Size = new System.Drawing.Size(100, 20);
            this.snipreq.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Требования";
            // 
            // snipres
            // 
            this.snipres.Location = new System.Drawing.Point(122, 73);
            this.snipres.Name = "snipres";
            this.snipres.Size = new System.Drawing.Size(100, 20);
            this.snipres.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Обязанности";
            // 
            // vacarea
            // 
            this.vacarea.Location = new System.Drawing.Point(228, 73);
            this.vacarea.Name = "vacarea";
            this.vacarea.Size = new System.Drawing.Size(100, 20);
            this.vacarea.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(225, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Зона";
            // 
            // vacexp
            // 
            this.vacexp.Location = new System.Drawing.Point(334, 73);
            this.vacexp.Name = "vacexp";
            this.vacexp.Size = new System.Drawing.Size(100, 20);
            this.vacexp.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Опыт работы";
            // 
            // vacskills
            // 
            this.vacskills.Location = new System.Drawing.Point(440, 73);
            this.vacskills.Name = "vacskills";
            this.vacskills.Size = new System.Drawing.Size(100, 20);
            this.vacskills.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(437, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Умения";
            // 
            // vacspec
            // 
            this.vacspec.Location = new System.Drawing.Point(546, 73);
            this.vacspec.Name = "vacspec";
            this.vacspec.Size = new System.Drawing.Size(100, 20);
            this.vacspec.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(543, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Специализация";
            // 
            // POST
            // 
            this.POST.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.POST.Location = new System.Drawing.Point(16, 99);
            this.POST.Name = "POST";
            this.POST.Size = new System.Drawing.Size(206, 92);
            this.POST.TabIndex = 24;
            this.POST.Text = "Добавить";
            this.POST.UseVisualStyleBackColor = true;
            this.POST.Click += new System.EventHandler(this.POST_Click);
            // 
            // DELETE
            // 
            this.DELETE.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DELETE.Location = new System.Drawing.Point(429, 99);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(217, 92);
            this.DELETE.TabIndex = 25;
            this.DELETE.Text = "Удалить";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // PUT
            // 
            this.PUT.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PUT.Location = new System.Drawing.Point(228, 99);
            this.PUT.Name = "PUT";
            this.PUT.Size = new System.Drawing.Size(195, 92);
            this.PUT.TabIndex = 26;
            this.PUT.Text = "Обновить";
            this.PUT.UseVisualStyleBackColor = true;
            this.PUT.Click += new System.EventHandler(this.PUT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 207);
            this.Controls.Add(this.PUT);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.POST);
            this.Controls.Add(this.vacspec);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.vacskills);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.vacexp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.vacarea);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.snipres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.snipreq);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vacsalary_to);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vacsalary_from);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.currency);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vacName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vacDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vacId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RGR_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vacId;
        private System.Windows.Forms.TextBox vacDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vacName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox currency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vacsalary_from;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vacsalary_to;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox snipreq;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox snipres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox vacarea;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox vacexp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox vacskills;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox vacspec;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button POST;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button PUT;
    }
}

