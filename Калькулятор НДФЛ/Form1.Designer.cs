namespace Калькулятор_НДФЛ
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
            this.calculatetax = new System.Windows.Forms.RadioButton();
            this.calculatepaymentandtax = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.differentrate = new System.Windows.Forms.RadioButton();
            this.dividends = new System.Windows.Forms.RadioButton();
            this.foreigners = new System.Windows.Forms.RadioButton();
            this.ordinaryincome = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.amounttobepaid = new System.Windows.Forms.TextBox();
            this.taxamount = new System.Windows.Forms.TextBox();
            this.totalamount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.interesttax = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.calculatetax.AutoSize = true;
            this.calculatetax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculatetax.Location = new System.Drawing.Point(3, 17);
            this.calculatetax.Name = "radioButton1";
            this.calculatetax.Size = new System.Drawing.Size(320, 21);
            this.calculatetax.TabIndex = 0;
            this.calculatetax.TabStop = true;
            this.calculatetax.Text = "Введена сумма к выплате. Посчитать налог.";
            this.calculatetax.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.calculatepaymentandtax.AutoSize = true;
            this.calculatepaymentandtax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculatepaymentandtax.Location = new System.Drawing.Point(3, 44);
            this.calculatepaymentandtax.Name = "radioButton2";
            this.calculatepaymentandtax.Size = new System.Drawing.Size(367, 21);
            this.calculatepaymentandtax.TabIndex = 1;
            this.calculatepaymentandtax.TabStop = true;
            this.calculatepaymentandtax.Text = "Введена общая сумма. Посчитать выплату и налог.";
            this.calculatepaymentandtax.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.calculatepaymentandtax);
            this.panel1.Controls.Add(this.calculatetax);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 73);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.differentrate);
            this.panel2.Controls.Add(this.dividends);
            this.panel2.Controls.Add(this.foreigners);
            this.panel2.Controls.Add(this.ordinaryincome);
            this.panel2.Location = new System.Drawing.Point(12, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 95);
            this.panel2.TabIndex = 9;
            // 
            // radioButton6
            // 
            this.differentrate.AutoSize = true;
            this.differentrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.differentrate.Location = new System.Drawing.Point(183, 55);
            this.differentrate.Name = "radioButton6";
            this.differentrate.Size = new System.Drawing.Size(121, 21);
            this.differentrate.TabIndex = 3;
            this.differentrate.TabStop = true;
            this.differentrate.Text = "Другая ставка";
            this.differentrate.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.dividends.AutoSize = true;
            this.dividends.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dividends.Location = new System.Drawing.Point(183, 14);
            this.dividends.Name = "radioButton5";
            this.dividends.Size = new System.Drawing.Size(126, 21);
            this.dividends.TabIndex = 2;
            this.dividends.TabStop = true;
            this.dividends.Text = "Дивиденды 9%";
            this.dividends.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.foreigners.AutoSize = true;
            this.foreigners.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foreigners.Location = new System.Drawing.Point(4, 55);
            this.foreigners.Name = "radioButton4";
            this.foreigners.Size = new System.Drawing.Size(140, 21);
            this.foreigners.TabIndex = 1;
            this.foreigners.TabStop = true;
            this.foreigners.Text = "Иностранцы 30%";
            this.foreigners.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.ordinaryincome.AutoSize = true;
            this.ordinaryincome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordinaryincome.Location = new System.Drawing.Point(4, 14);
            this.ordinaryincome.Name = "radioButton3";
            this.ordinaryincome.Size = new System.Drawing.Size(173, 21);
            this.ordinaryincome.TabIndex = 0;
            this.ordinaryincome.TabStop = true;
            this.ordinaryincome.Text = "Обычные доходы 13%";
            this.ordinaryincome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(183, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Сумма";
            // 
            // textBox1
            // 
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount.Location = new System.Drawing.Point(239, 122);
            this.Amount.Name = "textBox1";
            this.Amount.Size = new System.Drawing.Size(147, 26);
            this.Amount.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(46, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ставка налога в процентах";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(69, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 51);
            this.button1.TabIndex = 14;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Vichislenie);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(36, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Сумма к выплате физ. лицу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(66, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Сумма налога к уплате";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(128, 568);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Общая сумма";
            // 
            // textBox2
            // 
            this.amounttobepaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amounttobepaid.Location = new System.Drawing.Point(239, 492);
            this.amounttobepaid.Name = "textBox2";
            this.amounttobepaid.Size = new System.Drawing.Size(147, 26);
            this.amounttobepaid.TabIndex = 18;
            // 
            // textBox3
            // 
            this.taxamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taxamount.Location = new System.Drawing.Point(239, 527);
            this.taxamount.Name = "textBox3";
            this.taxamount.Size = new System.Drawing.Size(147, 26);
            this.taxamount.TabIndex = 19;
            // 
            // textBox4
            // 
            this.totalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalamount.Location = new System.Drawing.Point(239, 565);
            this.totalamount.Name = "textBox4";
            this.totalamount.Size = new System.Drawing.Size(147, 26);
            this.totalamount.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(140, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Выбор ставки налога";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(233, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 51);
            this.button2.TabIndex = 22;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Clear);
            // 
            // textBox5
            // 
            this.interesttax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.interesttax.Location = new System.Drawing.Point(239, 320);
            this.interesttax.Name = "textBox5";
            this.interesttax.Size = new System.Drawing.Size(147, 26);
            this.interesttax.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 617);
            this.Controls.Add(this.interesttax);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalamount);
            this.Controls.Add(this.taxamount);
            this.Controls.Add(this.amounttobepaid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Расчёт НДФЛ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton calculatetax;
        private System.Windows.Forms.RadioButton calculatepaymentandtax;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton differentrate;
        private System.Windows.Forms.RadioButton dividends;
        private System.Windows.Forms.RadioButton foreigners;
        private System.Windows.Forms.RadioButton ordinaryincome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amounttobepaid;
        private System.Windows.Forms.TextBox taxamount;
        private System.Windows.Forms.TextBox totalamount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox interesttax;
    }
}

