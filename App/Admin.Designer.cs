
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
            this.Btn_Save = new System.Windows.Forms.Button();
            this.btn_salary = new System.Windows.Forms.Button();
            this.Label_FIO = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберете Работника";
            // 
            // ChooseEmployer
            // 
            this.ChooseEmployer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseEmployer.FormattingEnabled = true;
            this.ChooseEmployer.Location = new System.Drawing.Point(12, 35);
            this.ChooseEmployer.Name = "ChooseEmployer";
            this.ChooseEmployer.Size = new System.Drawing.Size(170, 28);
            this.ChooseEmployer.TabIndex = 2;
            // 
            // Btn_AddEmp
            // 
            this.Btn_AddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_AddEmp.Location = new System.Drawing.Point(188, 4);
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
            this.Btn_Show.Location = new System.Drawing.Point(188, 35);
            this.Btn_Show.Name = "Btn_Show";
            this.Btn_Show.Size = new System.Drawing.Size(170, 28);
            this.Btn_Show.TabIndex = 5;
            this.Btn_Show.Text = "Вывести";
            this.Btn_Show.UseVisualStyleBackColor = true;
            this.Btn_Show.Click += new System.EventHandler(this.Btn_Show_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Save.Location = new System.Drawing.Point(12, 419);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(170, 30);
            this.Btn_Save.TabIndex = 6;
            this.Btn_Save.Text = "Сохранить и выйти";
            this.Btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_salary
            // 
            this.btn_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_salary.Location = new System.Drawing.Point(253, 419);
            this.btn_salary.Name = "btn_salary";
            this.btn_salary.Size = new System.Drawing.Size(219, 30);
            this.btn_salary.TabIndex = 7;
            this.btn_salary.Text = "Рассчитать зарплату";
            this.btn_salary.UseVisualStyleBackColor = true;
            // 
            // Label_FIO
            // 
            this.Label_FIO.AutoSize = true;
            this.Label_FIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_FIO.Location = new System.Drawing.Point(12, 83);
            this.Label_FIO.Name = "Label_FIO";
            this.Label_FIO.Size = new System.Drawing.Size(54, 24);
            this.Label_FIO.TabIndex = 8;
            this.Label_FIO.Text = "ФИО";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_refresh.Location = new System.Drawing.Point(397, 4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 28);
            this.btn_refresh.TabIndex = 9;
            this.btn_refresh.Text = "обновить";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.Label_FIO);
            this.Controls.Add(this.btn_salary);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Show);
            this.Controls.Add(this.Btn_AddEmp);
            this.Controls.Add(this.ChooseEmployer);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ChooseEmployer;
        private System.Windows.Forms.Button Btn_AddEmp;
        private System.Windows.Forms.Button Btn_Show;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button btn_salary;
        private System.Windows.Forms.Label Label_FIO;
        private System.Windows.Forms.Button btn_refresh;
    }
}