namespace SPPR_Forms
{
    partial class Form_Predict
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
            this.dataGridView_Pred = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pred)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Pred
            // 
            this.dataGridView_Pred.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Pred.Location = new System.Drawing.Point(35, 37);
            this.dataGridView_Pred.Name = "dataGridView_Pred";
            this.dataGridView_Pred.RowHeadersWidth = 62;
            this.dataGridView_Pred.RowTemplate.Height = 28;
            this.dataGridView_Pred.Size = new System.Drawing.Size(725, 377);
            this.dataGridView_Pred.TabIndex = 0;
            // 
            // Form_Predict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_Pred);
            this.Name = "Form_Predict";
            this.Text = "Form_Predict";
            this.Load += new System.EventHandler(this.Form_Predict_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pred)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Pred;
    }
}