namespace SPPR_Forms
{
    partial class Form_AddTelepParam
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
            this.comboBox_Param = new System.Windows.Forms.ComboBox();
            this.button_Ok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Value = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox_Param
            // 
            this.comboBox_Param.FormattingEnabled = true;
            this.comboBox_Param.Location = new System.Drawing.Point(147, 27);
            this.comboBox_Param.Name = "comboBox_Param";
            this.comboBox_Param.Size = new System.Drawing.Size(329, 28);
            this.comboBox_Param.TabIndex = 17;
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(247, 122);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(102, 30);
            this.button_Ok.TabIndex = 16;
            this.button_Ok.Text = "Ок";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Значение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Параметр";
            // 
            // textBox_Value
            // 
            this.textBox_Value.Location = new System.Drawing.Point(147, 75);
            this.textBox_Value.Name = "textBox_Value";
            this.textBox_Value.Size = new System.Drawing.Size(330, 26);
            this.textBox_Value.TabIndex = 13;
            // 
            // Form_AddTelepParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 169);
            this.Controls.Add(this.comboBox_Param);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Value);
            this.Name = "Form_AddTelepParam";
            this.Text = "Form_AddTelepParam";
            this.Load += new System.EventHandler(this.Form_AddTelepParam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Param;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Value;
    }
}