namespace SPPR_Forms
{
    partial class Form_Analize
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
            this.dataGridView_Treb = new System.Windows.Forms.DataGridView();
            this.button_Ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Treb)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(479, 75);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(100, 38);
            this.button_Del.TabIndex = 7;
            this.button_Del.Text = "Удалить";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(479, 19);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(100, 39);
            this.button_Add.TabIndex = 6;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // dataGridView_Treb
            // 
            this.dataGridView_Treb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Treb.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Treb.Name = "dataGridView_Treb";
            this.dataGridView_Treb.RowHeadersWidth = 62;
            this.dataGridView_Treb.RowTemplate.Height = 28;
            this.dataGridView_Treb.Size = new System.Drawing.Size(433, 260);
            this.dataGridView_Treb.TabIndex = 5;
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(487, 214);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(81, 32);
            this.button_Ok.TabIndex = 8;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // Form_Analize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 294);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dataGridView_Treb);
            this.Name = "Form_Analize";
            this.Text = "Form_Analize";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Treb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.DataGridView dataGridView_Treb;
        private System.Windows.Forms.Button button_Ok;
    }
}