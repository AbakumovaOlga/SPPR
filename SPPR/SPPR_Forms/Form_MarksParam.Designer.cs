namespace SPPR_Forms
{
    partial class Form_MarksParam
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
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.dataGridView_MarkParams = new System.Windows.Forms.DataGridView();
            this.button_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MarkParams)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(579, 309);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(100, 38);
            this.button_Del.TabIndex = 28;
            this.button_Del.Text = "Удалить";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(579, 87);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(100, 39);
            this.button_Add.TabIndex = 27;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // dataGridView_MarkParams
            // 
            this.dataGridView_MarkParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MarkParams.Location = new System.Drawing.Point(125, 87);
            this.dataGridView_MarkParams.Name = "dataGridView_MarkParams";
            this.dataGridView_MarkParams.RowHeadersWidth = 62;
            this.dataGridView_MarkParams.RowTemplate.Height = 28;
            this.dataGridView_MarkParams.Size = new System.Drawing.Size(433, 260);
            this.dataGridView_MarkParams.TabIndex = 26;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(279, 385);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(77, 31);
            this.button_OK.TabIndex = 25;
            this.button_OK.Text = "ОК";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Название параметра";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(326, 34);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(204, 26);
            this.textBox_Name.TabIndex = 23;
            // 
            // Form_MarksParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dataGridView_MarkParams);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Name);
            this.Name = "Form_MarksParam";
            this.Text = "Form_MarksParam";
            this.Load += new System.EventHandler(this.Form_MarksParam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MarkParams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.DataGridView dataGridView_MarkParams;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Name;
    }
}