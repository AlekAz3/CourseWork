
namespace App
{
    partial class LogIn
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
            this.label_Log = new System.Windows.Forms.Label();
            this.Text_Login = new System.Windows.Forms.TextBox();
            this.label_Pass = new System.Windows.Forms.Label();
            this.Text_Password = new System.Windows.Forms.TextBox();
            this.Btn_Enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Log
            // 
            this.label_Log.AutoSize = true;
            this.label_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Log.Location = new System.Drawing.Point(8, 40);
            this.label_Log.Name = "label_Log";
            this.label_Log.Size = new System.Drawing.Size(64, 24);
            this.label_Log.TabIndex = 0;
            this.label_Log.Text = "Логин";
            // 
            // Text_Login
            // 
            this.Text_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Login.Location = new System.Drawing.Point(12, 67);
            this.Text_Login.Name = "Text_Login";
            this.Text_Login.Size = new System.Drawing.Size(250, 29);
            this.Text_Login.TabIndex = 1;
            // 
            // label_Pass
            // 
            this.label_Pass.AutoSize = true;
            this.label_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Pass.Location = new System.Drawing.Point(8, 99);
            this.label_Pass.Name = "label_Pass";
            this.label_Pass.Size = new System.Drawing.Size(76, 24);
            this.label_Pass.TabIndex = 2;
            this.label_Pass.Text = "Пароль";
            // 
            // Text_Password
            // 
            this.Text_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Password.Location = new System.Drawing.Point(12, 126);
            this.Text_Password.Name = "Text_Password";
            this.Text_Password.Size = new System.Drawing.Size(250, 29);
            this.Text_Password.TabIndex = 3;
            // 
            // Btn_Enter
            // 
            this.Btn_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Enter.Location = new System.Drawing.Point(12, 161);
            this.Btn_Enter.Name = "Btn_Enter";
            this.Btn_Enter.Size = new System.Drawing.Size(250, 34);
            this.Btn_Enter.TabIndex = 4;
            this.Btn_Enter.Text = "Войти";
            this.Btn_Enter.UseVisualStyleBackColor = true;
            this.Btn_Enter.Click += new System.EventHandler(this.Btn_Enter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Вход";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 210);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Enter);
            this.Controls.Add(this.Text_Password);
            this.Controls.Add(this.label_Pass);
            this.Controls.Add(this.Text_Login);
            this.Controls.Add(this.label_Log);
            this.Name = "LogIn";
            this.Text = "Вход ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Log;
        private System.Windows.Forms.TextBox Text_Login;
        private System.Windows.Forms.Label label_Pass;
        private System.Windows.Forms.TextBox Text_Password;
        private System.Windows.Forms.Button Btn_Enter;
        private System.Windows.Forms.Label label1;
    }
}

