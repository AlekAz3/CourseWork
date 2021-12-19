
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
            this.Btn_AddEmp = new System.Windows.Forms.Button();
            this.Btn_Show = new System.Windows.Forms.Button();
            this.btn_salary = new System.Windows.Forms.Button();
            this.Label_FIO = new System.Windows.Forms.Label();
            this.Num_Reprimands = new System.Windows.Forms.NumericUpDown();
            this.Num_Penalty = new System.Windows.Forms.NumericUpDown();
            this.Num_Day = new System.Windows.Forms.NumericUpDown();
            this.Num_Sickleave = new System.Windows.Forms.NumericUpDown();
            this.Num_Reteperhour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.Num_Years = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Reprimands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Penalty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Sickleave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Reteperhour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Years)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберете Работника";
            // 
            // ChooseEmployer
            // 
            this.ChooseEmployer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseEmployer.FormattingEnabled = true;
            this.ChooseEmployer.Location = new System.Drawing.Point(13, 55);
            this.ChooseEmployer.Name = "ChooseEmployer";
            this.ChooseEmployer.Size = new System.Drawing.Size(170, 28);
            this.ChooseEmployer.TabIndex = 2;
            // 
            // Btn_AddEmp
            // 
            this.Btn_AddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_AddEmp.Location = new System.Drawing.Point(189, 24);
            this.Btn_AddEmp.Name = "Btn_AddEmp";
            this.Btn_AddEmp.Size = new System.Drawing.Size(170, 28);
            this.Btn_AddEmp.TabIndex = 4;
            this.Btn_AddEmp.Text = "Добавить сотрудника";
            this.Btn_AddEmp.UseVisualStyleBackColor = true;
            this.Btn_AddEmp.Click += new System.EventHandler(this.Btn_AddEmp_Click);
            // 
            // Btn_Show
            // 
            this.Btn_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Show.Location = new System.Drawing.Point(189, 54);
            this.Btn_Show.Name = "Btn_Show";
            this.Btn_Show.Size = new System.Drawing.Size(170, 28);
            this.Btn_Show.TabIndex = 5;
            this.Btn_Show.Text = "Вывести";
            this.Btn_Show.UseVisualStyleBackColor = true;
            this.Btn_Show.Click += new System.EventHandler(this.Btn_Show_Click);
            // 
            // btn_salary
            // 
            this.btn_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_salary.Location = new System.Drawing.Point(282, 419);
            this.btn_salary.Name = "btn_salary";
            this.btn_salary.Size = new System.Drawing.Size(190, 30);
            this.btn_salary.TabIndex = 7;
            this.btn_salary.Text = "Рассчитать выплату";
            this.btn_salary.UseVisualStyleBackColor = true;
            this.btn_salary.Click += new System.EventHandler(this.btn_salary_Click);
            // 
            // Label_FIO
            // 
            this.Label_FIO.AutoSize = true;
            this.Label_FIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_FIO.Location = new System.Drawing.Point(13, 103);
            this.Label_FIO.Name = "Label_FIO";
            this.Label_FIO.Size = new System.Drawing.Size(54, 24);
            this.Label_FIO.TabIndex = 8;
            this.Label_FIO.Text = "ФИО";
            // 
            // Num_Reprimands
            // 
            this.Num_Reprimands.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num_Reprimands.Location = new System.Drawing.Point(352, 144);
            this.Num_Reprimands.Name = "Num_Reprimands";
            this.Num_Reprimands.Size = new System.Drawing.Size(120, 24);
            this.Num_Reprimands.TabIndex = 9;
            // 
            // Num_Penalty
            // 
            this.Num_Penalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num_Penalty.Location = new System.Drawing.Point(352, 204);
            this.Num_Penalty.Name = "Num_Penalty";
            this.Num_Penalty.Size = new System.Drawing.Size(120, 24);
            this.Num_Penalty.TabIndex = 10;
            // 
            // Num_Day
            // 
            this.Num_Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num_Day.Location = new System.Drawing.Point(352, 264);
            this.Num_Day.Name = "Num_Day";
            this.Num_Day.Size = new System.Drawing.Size(120, 24);
            this.Num_Day.TabIndex = 12;
            // 
            // Num_Sickleave
            // 
            this.Num_Sickleave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num_Sickleave.Location = new System.Drawing.Point(352, 234);
            this.Num_Sickleave.Name = "Num_Sickleave";
            this.Num_Sickleave.Size = new System.Drawing.Size(120, 24);
            this.Num_Sickleave.TabIndex = 11;
            // 
            // Num_Reteperhour
            // 
            this.Num_Reteperhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num_Reteperhour.Location = new System.Drawing.Point(352, 174);
            this.Num_Reteperhour.Name = "Num_Reteperhour";
            this.Num_Reteperhour.Size = new System.Drawing.Size(120, 24);
            this.Num_Reteperhour.TabIndex = 15;
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown7.Location = new System.Drawing.Point(352, 324);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(120, 24);
            this.numericUpDown7.TabIndex = 14;
            // 
            // Num_Years
            // 
            this.Num_Years.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num_Years.Location = new System.Drawing.Point(352, 294);
            this.Num_Years.Name = "Num_Years";
            this.Num_Years.Size = new System.Drawing.Size(120, 24);
            this.Num_Years.TabIndex = 13;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Num_Reteperhour);
            this.Controls.Add(this.numericUpDown7);
            this.Controls.Add(this.Num_Years);
            this.Controls.Add(this.Num_Day);
            this.Controls.Add(this.Num_Sickleave);
            this.Controls.Add(this.Num_Penalty);
            this.Controls.Add(this.Num_Reprimands);
            this.Controls.Add(this.Label_FIO);
            this.Controls.Add(this.btn_salary);
            this.Controls.Add(this.Btn_Show);
            this.Controls.Add(this.Btn_AddEmp);
            this.Controls.Add(this.ChooseEmployer);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.Num_Reprimands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Penalty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Sickleave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Reteperhour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Years)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ChooseEmployer;
        private System.Windows.Forms.Button Btn_AddEmp;
        private System.Windows.Forms.Button Btn_Show;
        private System.Windows.Forms.Button btn_salary;
        private System.Windows.Forms.Label Label_FIO;
        private System.Windows.Forms.NumericUpDown Num_Reprimands;
        private System.Windows.Forms.NumericUpDown Num_Penalty;
        private System.Windows.Forms.NumericUpDown Num_Day;
        private System.Windows.Forms.NumericUpDown Num_Sickleave;
        private System.Windows.Forms.NumericUpDown Num_Reteperhour;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown Num_Years;
    }
}