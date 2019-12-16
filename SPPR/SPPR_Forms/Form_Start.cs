using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace SPPR_Forms
{
    public partial class Form_Start : Form
    {

        [Dependency]
        public new IUnityContainer Container { get; set; }
        public Form_Start()
        {
            InitializeComponent();
        }

        private void добавитьТелефонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Form_AddTelep>();
            form.Show();
        }

        private void списокТелефоновToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Form_Telephones>();
            form.Show();
        }

        private void добавитьПараметрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Form_AddParam>();
            form.Show();
        }

        private void списокПараметровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Form_Params>();
            form.Show();
        }

        private void выборToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Form_Analize>();
            form.Show();
        }

        private void прогнозToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Form_Predict>();
            form.Show();
        }

        private void вЫбратьПараметрыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Form_ChoosePar>();
            form.Show();
        }

        private void Form_Start_Load(object sender, EventArgs e)
        {
            
        }
    }
}
