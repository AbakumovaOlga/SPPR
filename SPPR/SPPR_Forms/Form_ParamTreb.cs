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
    public partial class Form_ParamTreb : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IParametrService _serviceP;

        public TrebParam model { set; get; }
        public Form_ParamTreb(IParametrService serviceP)
        {
            _serviceP = serviceP;
            InitializeComponent();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                model = new TrebParam
                {
                    ParametrId = Convert.ToInt32(comboBox_Param.SelectedValue),
                    Mark = (Marks)comboBox_Mark.SelectedValue
                };

                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_ParamTreb_Load(object sender, EventArgs e)
        {
            try
            {
                List<ParametrBM> list = _serviceP.GetList();
                if (list != null)
                {
                    comboBox_Param.DisplayMember = "Name";
                    comboBox_Param.ValueMember = "Id";
                    comboBox_Param.DataSource = list;
                    comboBox_Param.SelectedItem = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            comboBox_Mark.DataSource = Enum.GetValues(typeof(Marks));
        }
    }
}
