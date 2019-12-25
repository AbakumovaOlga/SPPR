using SPPR;
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

namespace SPPR_Forms
{
    public partial class Form_AddMarkParam : Form
    {

        public int userId { get; set; }
        public int paramId { get; set; }
        public MarkParametr model { set; get; }
        public Form_AddMarkParam()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                model = new MarkParametr
                {
                    Mark = (Marks)comboBox_Mark.SelectedValue,
                    Down=(int)numericUpDown_MalDown.Value,
                    Average=(int)numericUpDown_MalAr.Value,
                    Up=(int)numericUpDown_MalUp.Value,
                    UserId=userId,
                    ParametrId=paramId

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

        private void Form_AddMarkParam_Load(object sender, EventArgs e)
        {
            comboBox_Mark.DataSource = Enum.GetValues(typeof(Marks));
        }
    }
}
