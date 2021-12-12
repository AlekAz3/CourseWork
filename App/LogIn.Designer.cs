
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
            this.Btn_Reg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Log
            // 
            this.label_Log.AutoSize = true;
            this.label_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Log.Location = new System.Drawing.Point(129, 50);
            this.label_Log.Name = "label_Log";
            this.label_Log.Size = new System.Drawing.Size(64, 24);
            this.label_Log.TabIndex = 0;
            this.label_Log.Text = "Логин";
            // 
            // Text_Login
            // 
            this.Text_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Login.Location = new System.Drawing.Point(133, 77);
            this.Text_Login.Name = "Text_Login";
            this.Text_Login.Size = new System.Drawing.Size(163, 29);
            this.Text_Login.TabIndex = 1;
            // 
            // label_Pass
            // 
            this.label_Pass.AutoSize = true;
            this.label_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Pass.Location = new System.Drawing.Point(129, 129);
            this.label_Pass.Name = "label_Pass";
            this.label_Pass.Size = new System.Drawing.Size(76, 24);
            this.label_Pass.TabIndex = 2;
            this.label_Pass.Text = "Пароль";
            // 
            // Text_Password
            // 
            this.Text_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Password.Location = new System.Drawing.Point(133, 156);
            this.Text_Password.Name = "Text_Password";
            this.Text_Password.Size = new System.Drawing.Size(163, 29);
            this.Text_Password.TabIndex = 3;
            // 
            // Btn_Enter
            // 
            this.Btn_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Enter.Location = new System.Drawing.Point(133, 202);
            this.Btn_Enter.Name = "Btn_Enter";
            this.Btn_Enter.Size = new System.Drawing.Size(163, 34);
            this.Btn_Enter.TabIndex = 4;
            this.Btn_Enter.Text = "Войти";
            this.Btn_Enter.UseVisualStyleBackColor = true;
            // 
            // Btn_Reg
            // 
            this.Btn_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Reg.Location = new System.Drawing.Point(133, 385);
            this.Btn_Reg.Name = "Btn_Reg";
            this.Btn_Reg.Size = new System.Drawing.Size(163, 33);
            this.Btn_Reg.TabIndex = 5;
            this.Btn_Reg.Text = "Регистрация";
            this.Btn_Reg.UseVisualStyleBackColor = true;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 461);
            this.Controls.Add(this.Btn_Reg);
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
        private System.Windows.Forms.Button Btn_Reg;
    }
}

