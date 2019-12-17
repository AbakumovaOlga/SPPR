namespace SPPR_Forms
{
    partial class Form_Start
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.загрузитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТелефонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокТелефоновToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьПараметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПараметрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вЫбратьПараметрыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПараметровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прогнозToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьДанныеToolStripMenuItem,
            this.выбратьПараметрыToolStripMenuItem,
            this.анализToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // загрузитьДанныеToolStripMenuItem
            // 
            this.загрузитьДанныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьТелефонToolStripMenuItem,
            this.списокТелефоновToolStripMenuItem});
            this.загрузитьДанныеToolStripMenuItem.Name = "загрузитьДанныеToolStripMenuItem";
            this.загрузитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.загрузитьДанныеToolStripMenuItem.Text = "Телефоны";
            // 
            // добавитьТелефонToolStripMenuItem
            // 
            this.добавитьТелефонToolStripMenuItem.Name = "добавитьТелефонToolStripMenuItem";
            this.добавитьТелефонToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            this.добавитьТелефонToolStripMenuItem.Text = "Добавить телефон";
            this.добавитьТелефонToolStripMenuItem.Click += new System.EventHandler(this.добавитьТелефонToolStripMenuItem_Click);
            // 
            // списокТелефоновToolStripMenuItem
            // 
            this.списокТелефоновToolStripMenuItem.Name = "списокТелефоновToolStripMenuItem";
            this.списокТелефоновToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            this.списокТелефоновToolStripMenuItem.Text = "Список телефонов";
            this.списокТелефоновToolStripMenuItem.Click += new System.EventHandler(this.списокТелефоновToolStripMenuItem_Click);
            // 
            // выбратьПараметрыToolStripMenuItem
            // 
            this.выбратьПараметрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПараметрToolStripMenuItem,
            this.вЫбратьПараметрыToolStripMenuItem1,
            this.списокПараметровToolStripMenuItem});
            this.выбратьПараметрыToolStripMenuItem.Name = "выбратьПараметрыToolStripMenuItem";
            this.выбратьПараметрыToolStripMenuItem.Size = new System.Drawing.Size(123, 29);
            this.выбратьПараметрыToolStripMenuItem.Text = "Параметры";
            // 
            // добавитьПараметрToolStripMenuItem
            // 
            this.добавитьПараметрToolStripMenuItem.Name = "добавитьПараметрToolStripMenuItem";
            this.добавитьПараметрToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.добавитьПараметрToolStripMenuItem.Text = "Добавить параметр";
            this.добавитьПараметрToolStripMenuItem.Click += new System.EventHandler(this.добавитьПараметрToolStripMenuItem_Click);
            // 
            // вЫбратьПараметрыToolStripMenuItem1
            // 
            this.вЫбратьПараметрыToolStripMenuItem1.Name = "вЫбратьПараметрыToolStripMenuItem1";
            this.вЫбратьПараметрыToolStripMenuItem1.Size = new System.Drawing.Size(280, 34);
            this.вЫбратьПараметрыToolStripMenuItem1.Text = "Выбрать параметры";
            this.вЫбратьПараметрыToolStripMenuItem1.Click += new System.EventHandler(this.вЫбратьПараметрыToolStripMenuItem1_Click);
            // 
            // списокПараметровToolStripMenuItem
            // 
            this.списокПараметровToolStripMenuItem.Name = "списокПараметровToolStripMenuItem";
            this.списокПараметровToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.списокПараметровToolStripMenuItem.Text = "Список параметров";
            this.списокПараметровToolStripMenuItem.Click += new System.EventHandler(this.списокПараметровToolStripMenuItem_Click);
            // 
            // анализToolStripMenuItem
            // 
            this.анализToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выборToolStripMenuItem,
            this.прогнозToolStripMenuItem,
            this.графикToolStripMenuItem});
            this.анализToolStripMenuItem.Name = "анализToolStripMenuItem";
            this.анализToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.анализToolStripMenuItem.Text = "Анализ";
            // 
            // выборToolStripMenuItem
            // 
            this.выборToolStripMenuItem.Name = "выборToolStripMenuItem";
            this.выборToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.выборToolStripMenuItem.Text = "Выбор";
            this.выборToolStripMenuItem.Click += new System.EventHandler(this.выборToolStripMenuItem_Click);
            // 
            // прогнозToolStripMenuItem
            // 
            this.прогнозToolStripMenuItem.Name = "прогнозToolStripMenuItem";
            this.прогнозToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.прогнозToolStripMenuItem.Text = "Прогноз";
            this.прогнозToolStripMenuItem.Click += new System.EventHandler(this.прогнозToolStripMenuItem_Click);
            // 
            // графикToolStripMenuItem
            // 
            this.графикToolStripMenuItem.Name = "графикToolStripMenuItem";
            this.графикToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.графикToolStripMenuItem.Text = "График";
            this.графикToolStripMenuItem.Click += new System.EventHandler(this.графикToolStripMenuItem_Click);
            // 
            // Form_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 422);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Start";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Start_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьПараметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПараметрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вЫбратьПараметрыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выборToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прогнозToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьТелефонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокТелефоновToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПараметровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикToolStripMenuItem;
    }
}

