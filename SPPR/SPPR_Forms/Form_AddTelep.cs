using SPPR;
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
    public partial class Form_AddTelep : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ITelephoneService _serviceT;
        private readonly IParametrService _serviceP;

        public int Id { set { id = value; } }
        private int? id;

        private List<TelepParam> TelepParams;


        public Form_AddTelep(ITelephoneService serviceT, IParametrService serviceP)
        {
            _serviceT = serviceT;
            _serviceP = serviceP;
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Form_AddTelepParam>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.model != null)
                {
                    if (id.HasValue)
                    {
                        form.model.Id = id.Value;
                    }
                    TelepParams.Add(form.model);
                }
                LoadData();
            }
        }

        private void LoadData()
        {
            



            try
            {
                if (TelepParams != null)
                {
                    dataGridView_Params.DataSource = null;
                    dataGridView_Params.DataSource = TelepParams;
                    //F_Products.Columns[0].Visible = false;
                    //  F_Products.Columns[1].Visible = false;
                    //   F_Products.Columns[2].Visible = false;
                    // F_Products.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            if (dataGridView_Params.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        TelepParams.RemoveAt(dataGridView_Params.SelectedRows[0].Cells[0].RowIndex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                List<TelepParam> TelepParamBMs = new List<TelepParam>();
                for (int i = 0; i < TelepParams.Count; ++i)
                {
                    TelepParamBMs.Add(new TelepParam
                    {
                        Id = TelepParams[i].Id,
                        ParametrId = TelepParams[i].ParametrId,
                        TelephoneId = TelepParams[i].TelephoneId,
                        Value = TelepParams[i].Value
                    });
                }
                if (TelepParamBMs.Count == 0)
                {
                    MessageBox.Show("Список продуктов пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _serviceT.CreateElement(new TelephoneBM
                {
                    ///////////////
                    Date = dateTimePicker_Date.Value,
                    Name=textBox_Name.Text,
                    TelepParams = TelepParamBMs
                });
                //  }
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_AddTelep_Load(object sender, EventArgs e)
        {

            if (id.HasValue)
            {
                try
                {
                    TelephoneBM view = _serviceT.GetElement(id.Value);
                    if (view != null)
                    {
                        dateTimePicker_Date.Value = view.Date;
                        textBox_Name.Text = view.Name;
                        TelepParams = view.TelepParams;
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                  TelepParams = new List<TelepParam>();
            }
            LoadData();
        }
    }
}
