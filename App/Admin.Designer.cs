
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
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберете Работника";
            // 
            // ChooseEmployer
            // 
            this.ChooseEmployer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseEmployer.FormattingEnabled = true;
            this.ChooseEmployer.Location = new System.Drawing.Point(12, 66);
            this.ChooseEmployer.Name = "ChooseEmployer";
            this.ChooseEmployer.Size = new System.Drawing.Size(166, 28);
            this.ChooseEmployer.TabIndex = 2;
            // 
            // Btn_AddEmp
            // 
            this.Btn_AddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_AddEmp.Location = new System.Drawing.Point(644, 12);
            this.Btn_AddEmp.Name = "Btn_AddEmp";
            this.Btn_AddEmp.Size = new System.Drawing.Size(143, 29);
            this.Btn_AddEmp.TabIndex = 4;
            this.Btn_AddEmp.Text = "Добавить сотрудника";
            this.Btn_AddEmp.UseVisualStyleBackColor = true;
            this.Btn_AddEmp.Click += new System.EventHandler(this.Btn_AddEmp_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Refresh.Location = new System.Drawing.Point(215, 66);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(131, 28);
            this.Btn_Refresh.TabIndex = 5;
            this.Btn_Refresh.Text = "Обновить";
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 543);
            this.Controls.Add(this.Btn_Refresh);
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
        private System.Windows.Forms.Button Btn_Refresh;
    }
}