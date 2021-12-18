
namespace App
{
    partial class AddEmployer
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
            this.Btn_Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Text_Post = new System.Windows.Forms.TextBox();
            this.Label_Passport = new System.Windows.Forms.Label();
            this.Text_Passport = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление работника";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Text_Name
            // 
            this.Text_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Name.Location = new System.Drawing.Point(12, 78);
            this.Text_Name.Name = "Text_Name";
            this.Text_Name.Size = new System.Drawing.Size(231, 29);
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
            this.Text_Patronymic.Size = new System.Drawing.Size(231, 29);
            this.Text_Patronymic.TabIndex = 4;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Add.Location = new System.Drawing.Point(12, 332);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(232, 37);
            this.Btn_Add.TabIndex = 9;
            this.Btn_Add.Text = "Добавить";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Должность";
            // 
            // Text_Post
            // 
            this.Text_Post.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Post.Location = new System.Drawing.Point(12, 284);
            this.Text_Post.Name = "Text_Post";
            this.Text_Post.Size = new System.Drawing.Size(231, 29);
            this.Text_Post.TabIndex = 11;
            // 
            // Label_Passport
            // 
            this.Label_Passport.AutoSize = true;
            this.Label_Passport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Passport.Location = new System.Drawing.Point(8, 190);
            this.Label_Passport.Name = "Label_Passport";
            this.Label_Passport.Size = new System.Drawing.Size(235, 24);
            this.Label_Passport.TabIndex = 7;
            this.Label_Passport.Text = "Серия и Номер паспорта";
            // 
            // Text_Passport
            // 
            this.Text_Passport.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Passport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Passport.Location = new System.Drawing.Point(12, 220);
            this.Text_Passport.Name = "Text_Passport";
            this.Text_Passport.Size = new System.Drawing.Size(232, 29);
            this.Text_Passport.TabIndex = 8;
            // 
            // AddEmployer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 379);
            this.Controls.Add(this.Text_Post);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Text_Passport);
            this.Controls.Add(this.Label_Passport);
            this.Controls.Add(this.Text_Patronymic);
            this.Controls.Add(this.Text_Surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Text_Name);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployer";
            this.Text = "Добавление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Text_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Text_Surname;
        private System.Windows.Forms.TextBox Text_Patronymic;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Text_Post;
        private System.Windows.Forms.Label Label_Passport;
        private System.Windows.Forms.TextBox Text_Passport;
    }
}