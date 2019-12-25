using SPPR;
using SPPR_Services.Interfaces;
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

        public int userId { get; set; }
        private readonly IUserService _serviceU;

        public Form_Start(IUserService serviceU)
        {
            _serviceU = serviceU;
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
            User user = _serviceU.GetElement(userId);
            form.user = user;
            form.Show();
        }

        private void добавитьПараметрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Form_AddParam>();
            form.userId = userId;
            form.Show();
        }

        private void списокПараметровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Form_Params>();
           form.userId = userId;
            form.Show();
        }

        private void выборToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Form_Analize>();
            form.userId = userId;
            form.Show();
        }

        private void прогнозToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Form_Predict>();
            form.userId = userId;
            form.Show();
        }

        private void вЫбратьПараметрыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Form_ChoosePar>();
           // form.userId = userId;
            form.Show();
        }

        private void Form_Start_Load(object sender, EventArgs e)
        {
            User user = _serviceU.GetElement(userId);
            if (user.Role != "admin")
            {
                добавитьПараметрToolStripMenuItem.Enabled = false;
                добавитьТелефонToolStripMenuItem.Enabled = false;
            }
        }

        private void графикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Form_Graf>();
            form.userId = userId;
            form.Show();
        }

        private void заполнитьОценкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Form_Marks>();
            form.userId = userId;
            form.Show();
        }
    }
}
