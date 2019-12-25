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
    public partial class Form_AddUser : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IUserService _serviceU;
        public Form_AddUser(IUserService serviceU)
        {
            _serviceU = serviceU;
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                _serviceU.CreateUser(new User
                {
                    Login = textBox_Login.Text,
                    Password = textBox_Pwd.Text,
                    FIO = textBox_FIO.Text,
                    Role = textBox_Role.Text
                });

                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
