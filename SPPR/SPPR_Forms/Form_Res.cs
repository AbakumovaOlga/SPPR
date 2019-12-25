using SPPR_Services.BindingModels;
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
    public partial class Form_Res : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public List<TelephoneBM> list;
        BindingSource sourse;
        public Form_Res()
        {
            list = new List<TelephoneBM>();
            InitializeComponent();
        }

        private void Form_Res_Load(object sender, EventArgs e)
        {
            sourse = new BindingSource();
            sourse.DataSource = list;
            dataGridView1.DataSource = sourse;
        }
    }
}
