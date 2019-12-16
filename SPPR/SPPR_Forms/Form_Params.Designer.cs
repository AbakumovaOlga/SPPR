namespace SPPR_Forms
{
    partial class Form_Params
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
            this.dataGridView_Params = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Params)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(667, 406);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(91, 32);
            this.button_Del.TabIndex = 5;
            this.button_Del.Text = "Удалить";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(667, 24);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(100, 32);
            this.button_Add.TabIndex = 4;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // dataGridView_Params
            // 
            this.dataGridView_Params.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Params.Location = new System.Drawing.Point(34, 12);
            this.dataGridView_Params.Name = "dataGridView_Params";
            this.dataGridView_Params.RowHeadersWidth = 62;
            this.dataGridView_Params.RowTemplate.Height = 28;
            this.dataGridView_Params.Size = new System.Drawing.Size(596, 426);
            this.dataGridView_Params.TabIndex = 3;
            // 
            // Form_Params
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dataGridView_Params);
            this.Name = "Form_Params";
            this.Text = "Form_Params";
            this.Load += new System.EventHandler(this.Form_Params_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Params)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.DataGridView dataGridView_Params;
    }
}