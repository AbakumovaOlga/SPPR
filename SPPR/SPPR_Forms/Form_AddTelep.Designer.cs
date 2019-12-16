namespace SPPR_Forms
{
    partial class Form_AddTelep
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Params = new System.Windows.Forms.DataGridView();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Ok = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Params)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата";
            // 
            // dataGridView_Params
            // 
            this.dataGridView_Params.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Params.Location = new System.Drawing.Point(46, 178);
            this.dataGridView_Params.Name = "dataGridView_Params";
            this.dataGridView_Params.RowHeadersWidth = 62;
            this.dataGridView_Params.RowTemplate.Height = 28;
            this.dataGridView_Params.Size = new System.Drawing.Size(433, 260);
            this.dataGridView_Params.TabIndex = 2;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(513, 185);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(100, 39);
            this.button_Add.TabIndex = 3;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(513, 241);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(100, 38);
            this.button_Del.TabIndex = 4;
            this.button_Del.Text = "Удалить";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(688, 58);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(75, 44);
            this.button_Ok.TabIndex = 5;
            this.button_Ok.Text = "ОК";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(188, 67);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(200, 26);
            this.textBox_Name.TabIndex = 6;
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Location = new System.Drawing.Point(188, 109);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_Date.TabIndex = 7;
            // 
            // Form_AddTelep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dataGridView_Params);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_AddTelep";
            this.Text = "Form_AddTelep";
            this.Load += new System.EventHandler(this.Form_AddTelep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Params)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Params;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
    }
}