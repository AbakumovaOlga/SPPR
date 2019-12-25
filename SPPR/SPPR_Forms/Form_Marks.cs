using SPPR_Services.BindingModels;
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
    public partial class Form_Marks : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int userId { get; set; }

        private readonly IParametrService _serviceP;
        public Form_Marks(IParametrService serviceP)
        {
            _serviceP = serviceP;
            InitializeComponent();
        }

        private void Form_Marks_Load(object sender, EventArgs e)
        {
            List<ParametrBM> list = _serviceP.GetList();
            dataGridView_Params.DataSource = list;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (dataGridView_Params.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView_Params.SelectedRows[0].Cells[0].Value);
                try
                {
                    var form = Container.Resolve<Form_MarksParam>();
                    form.userId = userId;
                    form.paramId = id;
                    form.Show();
                 //   LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               // LoadData();
            }

        }
    }
}
