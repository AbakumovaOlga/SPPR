namespace SPPR_Forms
{
    partial class Form_AddMarkParam
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
            this.comboBox_Mark = new System.Windows.Forms.ComboBox();
            this.numericUpDown_MalUp = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_MalAr = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_MalDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MalUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MalAr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MalDown)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Mark
            // 
            this.comboBox_Mark.FormattingEnabled = true;
            this.comboBox_Mark.Location = new System.Drawing.Point(158, 79);
            this.comboBox_Mark.Name = "comboBox_Mark";
            this.comboBox_Mark.Size = new System.Drawing.Size(226, 28);
            this.comboBox_Mark.TabIndex = 0;
            // 
            // numericUpDown_MalUp
            // 
            this.numericUpDown_MalUp.Location = new System.Drawing.Point(390, 188);
            this.numericUpDown_MalUp.Name = "numericUpDown_MalUp";
            this.numericUpDown_MalUp.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_MalUp.TabIndex = 18;
            // 
            // numericUpDown_MalAr
            // 
            this.numericUpDown_MalAr.Location = new System.Drawing.Point(226, 188);
            this.numericUpDown_MalAr.Name = "numericUpDown_MalAr";
            this.numericUpDown_MalAr.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_MalAr.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Верхняя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Средняя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Нижняя";
            // 
            // numericUpDown_MalDown
            // 
            this.numericUpDown_MalDown.Location = new System.Drawing.Point(59, 188);
            this.numericUpDown_MalDown.Name = "numericUpDown_MalDown";
            this.numericUpDown_MalDown.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_MalDown.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Оценка";
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(453, 287);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(87, 30);
            this.button_OK.TabIndex = 20;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Form_AddMarkParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_MalUp);
            this.Controls.Add(this.numericUpDown_MalAr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_MalDown);
            this.Controls.Add(this.comboBox_Mark);
            this.Name = "Form_AddMarkParam";
            this.Text = "Form_AddMarkParam";
            this.Load += new System.EventHandler(this.Form_AddMarkParam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MalUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MalAr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MalDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Mark;
        private System.Windows.Forms.NumericUpDown numericUpDown_MalUp;
        private System.Windows.Forms.NumericUpDown numericUpDown_MalAr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_MalDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_OK;
    }
}