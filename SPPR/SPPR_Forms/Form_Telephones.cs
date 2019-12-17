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
    public partial class Form_Telephones : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ITelephoneService _serviceT;
        public Form_Telephones(ITelephoneService serviceT)
        {
            _serviceT = serviceT;
            InitializeComponent();
        }

        private void Form_Telephones_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<TelephoneBM> list = _serviceT.GetList();
                if (list != null)
                {
                    dataGridView_Teleps.DataSource = list;
                    //   dataGridView_Teleps.Columns[0].Visible = false;
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
            var form = Container.Resolve<Form_AddTelep>();
            form.Show();
            LoadData();
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            if (dataGridView_Teleps.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView_Teleps.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        _serviceT.DelElement(id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void dataGridView_Teleps_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView_Teleps.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<Form_AddTelep>();
                form.Id = Convert.ToInt32(dataGridView_Teleps.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
