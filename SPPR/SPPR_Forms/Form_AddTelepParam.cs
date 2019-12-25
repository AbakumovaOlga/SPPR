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
    public partial class Form_AddTelepParam : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IParametrService _serviceP;

        public TelepParam model { set; get; }
        public int userId { get; set; }
        public Form_AddTelepParam(IParametrService serviceP)
        {
            _serviceP = serviceP;
            InitializeComponent();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Value.Text))
            {
                MessageBox.Show("Заполните поле значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Convert.ToInt32(textBox_Value.Text);
            }
            catch
            {
                MessageBox.Show("значение должно быть целым числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox_Value.Text.Length > 10)
            {
                MessageBox.Show("Слишком большое число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox_Param.SelectedValue == null)
            {
                MessageBox.Show("Выберите параметр", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                model = new TelepParam
                {
                    ParametrId = Convert.ToInt32(comboBox_Param.SelectedValue),
                    Value = Convert.ToInt32(textBox_Value.Text)
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

        private void Form_AddTelepParam_Load(object sender, EventArgs e)
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
        }
    }
}
