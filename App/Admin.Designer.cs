
namespace App
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ChooseEmployer = new System.Windows.Forms.ComboBox();
            this.Label_FIO = new System.Windows.Forms.Label();
            this.Num_Reprimands = new System.Windows.Forms.NumericUpDown();
            this.Num_Penalty = new System.Windows.Forms.NumericUpDown();
            this.Num_Day = new System.Windows.Forms.NumericUpDown();
            this.Num_Sickleave = new System.Windows.Forms.NumericUpDown();
            this.Num_Reteperhour = new System.Windows.Forms.NumericUpDown();
            this.Num_Last = new System.Windows.Forms.NumericUpDown();
            this.Num_Years = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.L_salary = new System.Windows.Forms.Label();
            this.L_Tax = new System.Windows.Forms.Label();
            this.L_Pay = new System.Windows.Forms.Label();
            this.L_ndfl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьРаботникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Reprimands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Penalty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Sickleave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Reteperhour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Last)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Years)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберете Работника";
            // 
            // ChooseEmployer
            // 
            this.ChooseEmployer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseEmployer.FormattingEnabled = true;
            this.ChooseEmployer.Location = new System.Drawing.Point(12, 54);
            this.ChooseEmployer.Name = "ChooseEmployer";
            this.ChooseEmployer.Size = new System.Drawing.Size(170, 28);
            this.ChooseEmployer.TabIndex = 2;
            this.ChooseEmployer.SelectedIndexChanged += new System.EventHandler(this.ChooseEmployer_SelectedIndexChanged);
            // 
            // Label_FIO
            // 
            this.Label_FIO.AutoSize = true;
            this.Label_FIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_FIO.Location = new System.Drawing.Point(9, 85);
            this.Label_FIO.Name = "Label_FIO";
            this.Label_FIO.Size = new System.Drawing.Size(54, 24);
            this.Label_FIO.TabIndex = 8;
            this.Label_FIO.Text = "ФИО";
            // 
            // Num_Reprimands
            // 
            this.Num_Reprimands.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num_Reprimands.Location = new System.Drawing.Point(246, 138);
            this.Num_Reprimands.Name = "Num_Reprimands";
            this.Num_Reprimands.Size = new System.Drawing.Size(120, 26);
            this.Num_Reprimands.TabIndex = 9;
            // 
            // Num_Penalty
            // 
            this.Num_Penalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num_Penalty.Location = new System.Drawing.Point(246, 202);
            this.Num_Penalty.Name = "Num_Penalty";
            this.Num_Penalty.Size = new System.Drawing.Size(120, 26);
            this.Num_Penalty.TabIndex = 10;
            // 
            // Num_Day
            // 
            this.Num_Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num_Day.Location = new System.Drawing.Point(246, 266);
            this.Num_Day.Name = "Num_Day";
            this.Num_Day.Size = new System.Drawing.Size(120, 26);
            this.Num_Day.TabIndex = 12;
            // 
            // Num_Sickleave
            // 
            this.Num_Sickleave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num_Sickleave.Location = new System.Drawing.Point(246, 234);
            this.Num_Sickleave.Name = "Num_Sickleave";
            this.Num_Sickleave.Size = new System.Drawing.Size(120, 26);
            this.Num_Sickleave.TabIndex = 11;
            // 
            // Num_Reteperhour
            // 
            this.Num_Reteperhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num_Reteperhour.Location = new System.Drawing.Point(246, 168);
            this.Num_Reteperhour.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Num_Reteperhour.Name = "Num_Reteperhour";
            this.Num_Reteperhour.Size = new System.Drawing.Size(120, 26);
            this.Num_Reteperhour.TabIndex = 15;
            // 
            // Num_Last
            // 
            this.Num_Last.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num_Last.Location = new System.Drawing.Point(246, 330);
            this.Num_Last.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Num_Last.Name = "Num_Last";
            this.Num_Last.Size = new System.Drawing.Size(120, 26);
            this.Num_Last.TabIndex = 14;
            // 
            // Num_Years
            // 
            this.Num_Years.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num_Years.Location = new System.Drawing.Point(246, 298);
            this.Num_Years.Name = "Num_Years";
            this.Num_Years.Size = new System.Drawing.Size(120, 26);
            this.Num_Years.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Выговоры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Почасовая ставка ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Больничные";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Штрафы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(9, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "ЗП в прошлом месяце ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(9, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Стаж";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(9, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Отработаннеы дни в месяце ";
            // 
            // L_salary
            // 
            this.L_salary.AutoSize = true;
            this.L_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_salary.Location = new System.Drawing.Point(8, 358);
            this.L_salary.Name = "L_salary";
            this.L_salary.Size = new System.Drawing.Size(88, 20);
            this.L_salary.TabIndex = 23;
            this.L_salary.Text = "Зарплата ";
            // 
            // L_Tax
            // 
            this.L_Tax.AutoSize = true;
            this.L_Tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Tax.Location = new System.Drawing.Point(8, 390);
            this.L_Tax.Name = "L_Tax";
            this.L_Tax.Size = new System.Drawing.Size(139, 20);
            this.L_Tax.TabIndex = 24;
            this.L_Tax.Text = "Налоги составят";
            // 
            // L_Pay
            // 
            this.L_Pay.AutoSize = true;
            this.L_Pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Pay.Location = new System.Drawing.Point(8, 452);
            this.L_Pay.Name = "L_Pay";
            this.L_Pay.Size = new System.Drawing.Size(136, 20);
            this.L_Pay.TabIndex = 25;
            this.L_Pay.Text = "Итого к выплате";
            // 
            // L_ndfl
            // 
            this.L_ndfl.AutoSize = true;
            this.L_ndfl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_ndfl.Location = new System.Drawing.Point(8, 421);
            this.L_ndfl.Name = "L_ndfl";
            this.L_ndfl.Size = new System.Drawing.Size(206, 20);
            this.L_ndfl.TabIndex = 26;
            this.L_ndfl.Text = "Выплата НДФЛ составит";
            this.L_ndfl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаToolStripMenuItem,
            this.добавитьРаботникаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(374, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.программаToolStripMenuItem.Text = "Выйти";
            this.программаToolStripMenuItem.Click += new System.EventHandler(this.программаToolStripMenuItem_Click);
            // 
            // добавитьРаботникаToolStripMenuItem
            // 
            this.добавитьРаботникаToolStripMenuItem.Name = "добавитьРаботникаToolStripMenuItem";
            this.добавитьРаботникаToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.добавитьРаботникаToolStripMenuItem.Text = "Добавить работника";
            this.добавитьРаботникаToolStripMenuItem.Click += new System.EventHandler(this.добавитьРаботникаToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(374, 479);
            this.Controls.Add(this.L_ndfl);
            this.Controls.Add(this.L_Pay);
            this.Controls.Add(this.L_Tax);
            this.Controls.Add(this.L_salary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Num_Reteperhour);
            this.Controls.Add(this.Num_Last);
            this.Controls.Add(this.Num_Years);
            this.Controls.Add(this.Num_Day);
            this.Controls.Add(this.Num_Sickleave);
            this.Controls.Add(this.Num_Penalty);
            this.Controls.Add(this.Num_Reprimands);
            this.Controls.Add(this.Label_FIO);
            this.Controls.Add(this.ChooseEmployer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.Num_Reprimands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Penalty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Sickleave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Reteperhour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Last)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Years)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ChooseEmployer;
        private System.Windows.Forms.Label Label_FIO;
        private System.Windows.Forms.NumericUpDown Num_Reprimands;
        private System.Windows.Forms.NumericUpDown Num_Penalty;
        private System.Windows.Forms.NumericUpDown Num_Day;
        private System.Windows.Forms.NumericUpDown Num_Sickleave;
        private System.Windows.Forms.NumericUpDown Num_Reteperhour;
        private System.Windows.Forms.NumericUpDown Num_Last;
        private System.Windows.Forms.NumericUpDown Num_Years;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label L_salary;
        private System.Windows.Forms.Label L_Tax;
        private System.Windows.Forms.Label L_Pay;
        private System.Windows.Forms.Label L_ndfl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьРаботникаToolStripMenuItem;
    }
}