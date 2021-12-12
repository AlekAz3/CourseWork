
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
            this.Label_Ind = new System.Windows.Forms.Label();
            this.Label_Passport = new System.Windows.Forms.Label();
            this.Text_Passport = new System.Windows.Forms.TextBox();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.Check_Adm = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Text_Name
            // 
            this.Text_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Name.Location = new System.Drawing.Point(12, 78);
            this.Text_Name.Name = "Text_Name";
            this.Text_Name.Size = new System.Drawing.Size(232, 29);
            this.Text_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ФИО";
            // 
            // Text_Surname
            // 
            this.Text_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Surname.Location = new System.Drawing.Point(12, 113);
            this.Text_Surname.Name = "Text_Surname";
            this.Text_Surname.Size = new System.Drawing.Size(232, 29);
            this.Text_Surname.TabIndex = 3;
            // 
            // Text_Patronymic
            // 
            this.Text_Patronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Patronymic.Location = new System.Drawing.Point(12, 148);
            this.Text_Patronymic.Name = "Text_Patronymic";
            this.Text_Patronymic.Size = new System.Drawing.Size(232, 29);
            this.Text_Patronymic.TabIndex = 4;
            // 
            // Text_IndividualNumber
            // 
            this.Text_IndividualNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_IndividualNumber.Location = new System.Drawing.Point(13, 209);
            this.Text_IndividualNumber.Name = "Text_IndividualNumber";
            this.Text_IndividualNumber.Size = new System.Drawing.Size(231, 29);
            this.Text_IndividualNumber.TabIndex = 5;
            // 
            // Label_Ind
            // 
            this.Label_Ind.AutoSize = true;
            this.Label_Ind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Ind.Location = new System.Drawing.Point(8, 180);
            this.Label_Ind.Name = "Label_Ind";
            this.Label_Ind.Size = new System.Drawing.Size(230, 24);
            this.Label_Ind.TabIndex = 6;
            this.Label_Ind.Text = "Индивидуальный Номер";
            // 
            // Label_Passport
            // 
            this.Label_Passport.AutoSize = true;
            this.Label_Passport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Passport.Location = new System.Drawing.Point(9, 241);
            this.Label_Passport.Name = "Label_Passport";
            this.Label_Passport.Size = new System.Drawing.Size(235, 24);
            this.Label_Passport.TabIndex = 7;
            this.Label_Passport.Text = "Серия и Номер паспорта";
            // 
            // Text_Passport
            // 
            this.Text_Passport.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Passport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Passport.Location = new System.Drawing.Point(13, 268);
            this.Text_Passport.Name = "Text_Passport";
            this.Text_Passport.Size = new System.Drawing.Size(232, 29);
            this.Text_Passport.TabIndex = 8;
            // 
            // Btn_Register
            // 
            this.Btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Register.Location = new System.Drawing.Point(12, 338);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(233, 37);
            this.Btn_Register.TabIndex = 9;
            this.Btn_Register.Text = "Зарегистрироваться";
            this.Btn_Register.UseVisualStyleBackColor = true;
            // 
            // Check_Adm
            // 
            this.Check_Adm.AutoSize = true;
            this.Check_Adm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Check_Adm.Location = new System.Drawing.Point(12, 303);
            this.Check_Adm.Name = "Check_Adm";
            this.Check_Adm.Size = new System.Drawing.Size(153, 28);
            this.Check_Adm.TabIndex = 11;
            this.Check_Adm.Text = "Управляющий";
            this.Check_Adm.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 381);
            this.Controls.Add(this.Check_Adm);
            this.Controls.Add(this.Btn_Register);
            this.Controls.Add(this.Text_Passport);
            this.Controls.Add(this.Label_Passport);
            this.Controls.Add(this.Label_Ind);
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
        private System.Windows.Forms.Label Label_Ind;
        private System.Windows.Forms.Label Label_Passport;
        private System.Windows.Forms.TextBox Text_Passport;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.CheckBox Check_Adm;
    }
}