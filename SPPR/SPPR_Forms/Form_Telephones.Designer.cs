namespace SPPR_Forms
{
    partial class Form_Telephones
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
            this.dataGridView_Teleps = new System.Windows.Forms.DataGridView();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Teleps)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Teleps
            // 
            this.dataGridView_Teleps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Teleps.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Teleps.Name = "dataGridView_Teleps";
            this.dataGridView_Teleps.RowHeadersWidth = 62;
            this.dataGridView_Teleps.RowTemplate.Height = 28;
            this.dataGridView_Teleps.Size = new System.Drawing.Size(596, 426);
            this.dataGridView_Teleps.TabIndex = 0;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(645, 24);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(100, 32);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(645, 406);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(91, 32);
            this.button_Del.TabIndex = 2;
            this.button_Del.Text = "Удалить";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // Form_Telephones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dataGridView_Teleps);
            this.Name = "Form_Telephones";
            this.Text = "Form_Telephones";
            this.Load += new System.EventHandler(this.Form_Telephones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Teleps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Teleps;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Del;
    }
}