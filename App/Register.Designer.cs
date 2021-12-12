
namespace App
{
    partial class Register
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
            this.Text_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_Surname = new System.Windows.Forms.TextBox();
            this.Text_Patronymic = new System.Windows.Forms.TextBox();
            this.Text_IndividualNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Text_Name
            // 
            this.Text_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Name.Location = new System.Drawing.Point(12, 78);
            this.Text_Name.Name = "Text_Name";
            this.Text_Name.Size = new System.Drawing.Size(221, 29);
            this.Text_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите ФИО";
            // 
            // Text_Surname
            // 
            this.Text_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Surname.Location = new System.Drawing.Point(12, 113);
            this.Text_Surname.Name = "Text_Surname";
            this.Text_Surname.Size = new System.Drawing.Size(221, 29);
            this.Text_Surname.TabIndex = 3;
            // 
            // Text_Patronymic
            // 
            this.Text_Patronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Patronymic.Location = new System.Drawing.Point(12, 148);
            this.Text_Patronymic.Name = "Text_Patronymic";
            this.Text_Patronymic.Size = new System.Drawing.Size(221, 29);
            this.Text_Patronymic.TabIndex = 4;
            // 
            // Text_IndividualNumber
            // 
            this.Text_IndividualNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_IndividualNumber.Location = new System.Drawing.Point(12, 233);
            this.Text_IndividualNumber.Name = "Text_IndividualNumber";
            this.Text_IndividualNumber.Size = new System.Drawing.Size(217, 30);
            this.Text_IndividualNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите Индивидуальный Номер";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Text_IndividualNumber);
            this.Controls.Add(this.Text_Patronymic);
            this.Controls.Add(this.Text_Surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Text_Name);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Text_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Text_Surname;
        private System.Windows.Forms.TextBox Text_Patronymic;
        private System.Windows.Forms.TextBox Text_IndividualNumber;
        private System.Windows.Forms.Label label3;
    }
}