namespace SPPR_Forms
{
    partial class Form_Author
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_CrUser = new System.Windows.Forms.Button();
            this.button_Enter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.texbox_Password = new System.Windows.Forms.TextBox();
            this.textbox_Login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Абакумова Ольга";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(518, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "система анализа и прогнозирования рынка мобильных телефонов";
            // 
            // button_CrUser
            // 
            this.button_CrUser.Location = new System.Drawing.Point(666, 353);
            this.button_CrUser.Name = "button_CrUser";
            this.button_CrUser.Size = new System.Drawing.Size(122, 40);
            this.button_CrUser.TabIndex = 53;
            this.button_CrUser.Text = "CreateUser";
            this.button_CrUser.UseVisualStyleBackColor = true;
            this.button_CrUser.Click += new System.EventHandler(this.button_CrUser_Click);
            // 
            // button_Enter
            // 
            this.button_Enter.Location = new System.Drawing.Point(346, 162);
            this.button_Enter.Name = "button_Enter";
            this.button_Enter.Size = new System.Drawing.Size(98, 44);
            this.button_Enter.TabIndex = 52;
            this.button_Enter.Text = "Enter";
            this.button_Enter.UseVisualStyleBackColor = true;
            this.button_Enter.Click += new System.EventHandler(this.button_Enter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Login";
            // 
            // texbox_Password
            // 
            this.texbox_Password.Location = new System.Drawing.Point(211, 104);
            this.texbox_Password.Name = "texbox_Password";
            this.texbox_Password.PasswordChar = '*';
            this.texbox_Password.Size = new System.Drawing.Size(405, 26);
            this.texbox_Password.TabIndex = 49;
            // 
            // textbox_Login
            // 
            this.textbox_Login.Location = new System.Drawing.Point(211, 58);
            this.textbox_Login.Name = "textbox_Login";
            this.textbox_Login.Size = new System.Drawing.Size(405, 26);
            this.textbox_Login.TabIndex = 48;
            // 
            // Form_Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_CrUser);
            this.Controls.Add(this.button_Enter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texbox_Password);
            this.Controls.Add(this.textbox_Login);
            this.Name = "Form_Author";
            this.Text = "Form_Author";
            this.Load += new System.EventHandler(this.Form_Author_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_CrUser;
        private System.Windows.Forms.Button button_Enter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texbox_Password;
        private System.Windows.Forms.TextBox textbox_Login;
    }
}