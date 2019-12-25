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
    public partial class Form_MarksParam : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int userId { get; set; }
        public int Id { get; set; }

        private readonly IParametrService _serviceP;
        private readonly IMarkParamService _serviceMP;

        List<MarkParametr> markParametrs;
        public Form_MarksParam(IParametrService serviceP, IMarkParamService serviceMP)
        {
            _serviceP = serviceP;
            _serviceMP = serviceMP;
            InitializeComponent();
        }

        private void Form_MarksParam_Load(object sender, EventArgs e)
        {
            ParametrBM parametr = _serviceP.GetElement(Id, userId);

            textBox_Name.Text = parametr.Name;
            markParametrs = new List<MarkParametr>();
            markParametrs = parametr.MarkParametrs;
           // dataGridView_MarkParams.DataSource = parametr.MarkParametrs;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Form_AddMarkParam>();
            form.userId = userId;
            form.paramId = Id;
            if (form.ShowDialog() == DialogResult.OK)
            {
                markParametrs.Add(form.model);
            }
            dataGridView_MarkParams.DataSource = null;
            dataGridView_MarkParams.DataSource = markParametrs;
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            if (dataGridView_MarkParams.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        MarkParametrBM marks = _serviceMP.GetElement((int)dataGridView_MarkParams.SelectedRows[0].Cells[1].Value);
                        markParametrs.RemoveAt(dataGridView_MarkParams.SelectedRows[0].Cells[0].RowIndex);
                        _serviceMP.DelElement(marks);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {

            foreach (var marks in markParametrs)
            {
                _serviceMP.CreateElement(marks);
            }
        }
    }
}
