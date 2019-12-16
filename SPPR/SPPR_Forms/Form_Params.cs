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
    public partial class Form_Params : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IParametrService _serviceP;
        public Form_Params(IParametrService serviceP)
        {
            _serviceP = serviceP;
            InitializeComponent();
        }

        private void Form_Params_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<ParametrBM> list = _serviceP.GetList();
                if (list != null)
                {
                    dataGridView_Params.DataSource = list;
                    //   dataGridView_Params.Columns[0].Visible = false;
                    //  F_GoodsList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Form_AddParam>();
            form.Show();
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            if (dataGridView_Params.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView_Params.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        _serviceP.DelElement(id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }
    }
}
