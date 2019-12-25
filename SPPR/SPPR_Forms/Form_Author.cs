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
    public partial class Form_Author : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private string login;
        private string password;

        private readonly IUserService _serviceU;
        private User user;

        public Form_Author(IUserService serviceU)
        {
            _serviceU = serviceU;
            InitializeComponent();
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            login = textbox_Login.Text;
            password = texbox_Password.Text;

            try
            {
                user = _serviceU.Author(login, password);


                if (user != null)
                {
                    var form = Container.Resolve<Form_Start>();
                    form.userId = user.Id;
                  //  form.logger = logger;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_CrUser_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Form_AddUser>();
            form.Show();
        }

        private void Form_Author_Load(object sender, EventArgs e)
        {

        }
    }
}
