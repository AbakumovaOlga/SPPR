namespace SPPR_Forms
{
    partial class Form_Marks
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
            this.dataGridView_Params = new System.Windows.Forms.DataGridView();
            this.button_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Params)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Params
            // 
            this.dataGridView_Params.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Params.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Params.Name = "dataGridView_Params";
            this.dataGridView_Params.RowHeadersWidth = 62;
            this.dataGridView_Params.RowTemplate.Height = 28;
            this.dataGridView_Params.Size = new System.Drawing.Size(596, 426);
            this.dataGridView_Params.TabIndex = 4;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(635, 12);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(110, 32);
            this.button_Add.TabIndex = 5;
            this.button_Add.Text = "Заполнить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // Form_Marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dataGridView_Params);
            this.Name = "Form_Marks";
            this.Text = "Form_Marks";
            this.Load += new System.EventHandler(this.Form_Marks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Params)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Params;
        private System.Windows.Forms.Button button_Add;
    }
}