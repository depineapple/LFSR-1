﻿
namespace LFSR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.Z = new System.Windows.Forms.TextBox();
            this.Coefficient = new System.Windows.Forms.TextBox();
            this.initialization = new System.Windows.Forms.TextBox();
            this.OriginalMessage = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RezultDecod = new System.Windows.Forms.TextBox();
            this.ZDecod = new System.Windows.Forms.TextBox();
            this.CoefficientDecod = new System.Windows.Forms.TextBox();
            this.initializationDecod = new System.Windows.Forms.TextBox();
            this.Сryptogram = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Result);
            this.groupBox1.Controls.Add(this.Z);
            this.groupBox1.Controls.Add(this.Coefficient);
            this.groupBox1.Controls.Add(this.initialization);
            this.groupBox1.Controls.Add(this.OriginalMessage);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Зашифрование";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Результат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Z";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вектор инициализации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вектор коэффициентов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Исходное сообщение";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(518, 172);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(252, 27);
            this.Result.TabIndex = 4;
            this.Result.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // Z
            // 
            this.Z.Location = new System.Drawing.Point(518, 139);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(252, 27);
            this.Z.TabIndex = 3;
            this.Z.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // Coefficient
            // 
            this.Coefficient.Location = new System.Drawing.Point(178, 60);
            this.Coefficient.Name = "Coefficient";
            this.Coefficient.Size = new System.Drawing.Size(252, 27);
            this.Coefficient.TabIndex = 2;
            this.Coefficient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // initialization
            // 
            this.initialization.Location = new System.Drawing.Point(178, 93);
            this.initialization.Name = "initialization";
            this.initialization.Size = new System.Drawing.Size(252, 27);
            this.initialization.TabIndex = 1;
            this.initialization.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // OriginalMessage
            // 
            this.OriginalMessage.Location = new System.Drawing.Point(178, 27);
            this.OriginalMessage.Name = "OriginalMessage";
            this.OriginalMessage.Size = new System.Drawing.Size(252, 27);
            this.OriginalMessage.TabIndex = 0;
            this.OriginalMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.RezultDecod);
            this.groupBox2.Controls.Add(this.ZDecod);
            this.groupBox2.Controls.Add(this.CoefficientDecod);
            this.groupBox2.Controls.Add(this.initializationDecod);
            this.groupBox2.Controls.Add(this.Сryptogram);
            this.groupBox2.Location = new System.Drawing.Point(12, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Расшифрование";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Расшифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Результат";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(493, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Z";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-1, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Вектор инициализации";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Вектор коэффициентов";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Шифрограмма";
            // 
            // RezultDecod
            // 
            this.RezultDecod.Location = new System.Drawing.Point(518, 167);
            this.RezultDecod.Name = "RezultDecod";
            this.RezultDecod.Size = new System.Drawing.Size(252, 27);
            this.RezultDecod.TabIndex = 14;
            this.RezultDecod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // ZDecod
            // 
            this.ZDecod.Location = new System.Drawing.Point(518, 134);
            this.ZDecod.Name = "ZDecod";
            this.ZDecod.Size = new System.Drawing.Size(252, 27);
            this.ZDecod.TabIndex = 13;
            this.ZDecod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // CoefficientDecod
            // 
            this.CoefficientDecod.Location = new System.Drawing.Point(178, 62);
            this.CoefficientDecod.Name = "CoefficientDecod";
            this.CoefficientDecod.Size = new System.Drawing.Size(252, 27);
            this.CoefficientDecod.TabIndex = 12;
            this.CoefficientDecod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // initializationDecod
            // 
            this.initializationDecod.Location = new System.Drawing.Point(178, 95);
            this.initializationDecod.Name = "initializationDecod";
            this.initializationDecod.Size = new System.Drawing.Size(252, 27);
            this.initializationDecod.TabIndex = 11;
            this.initializationDecod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // Сryptogram
            // 
            this.Сryptogram.Location = new System.Drawing.Point(178, 29);
            this.Сryptogram.Name = "Сryptogram";
            this.Сryptogram.Size = new System.Drawing.Size(252, 27);
            this.Сryptogram.TabIndex = 10;
            this.Сryptogram.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "LFSR";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.TextBox Z;
        private System.Windows.Forms.TextBox Coefficient;
        private System.Windows.Forms.TextBox initialization;
        private System.Windows.Forms.TextBox OriginalMessage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox RezultDecod;
        private System.Windows.Forms.TextBox ZDecod;
        private System.Windows.Forms.TextBox CoefficientDecod;
        private System.Windows.Forms.TextBox initializationDecod;
        private System.Windows.Forms.TextBox Сryptogram;
    }
}

