namespace SPPR_Forms
{
    partial class Form_ParamTreb
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
            this.comboBox_Mark = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox_Param
            // 
            this.comboBox_Param.FormattingEnabled = true;
            this.comboBox_Param.Location = new System.Drawing.Point(144, 21);
            this.comboBox_Param.Name = "comboBox_Param";
            this.comboBox_Param.Size = new System.Drawing.Size(329, 28);
            this.comboBox_Param.TabIndex = 22;
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(244, 116);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(102, 30);
            this.button_Ok.TabIndex = 21;
            this.button_Ok.Text = "Ок";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Значение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Параметр";
            // 
            // comboBox_Mark
            // 
            this.comboBox_Mark.FormattingEnabled = true;
            this.comboBox_Mark.Location = new System.Drawing.Point(144, 72);
            this.comboBox_Mark.Name = "comboBox_Mark";
            this.comboBox_Mark.Size = new System.Drawing.Size(329, 28);
            this.comboBox_Mark.TabIndex = 23;
            // 
            // Form_ParamTreb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 169);
            this.Controls.Add(this.comboBox_Mark);
            this.Controls.Add(this.comboBox_Param);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_ParamTreb";
            this.Text = "Form_ParamTreb";
            this.Load += new System.EventHandler(this.Form_ParamTreb_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Param;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Mark;
    }
}