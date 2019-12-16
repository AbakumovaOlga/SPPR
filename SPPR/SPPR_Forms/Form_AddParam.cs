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
    public partial class Form_AddParam : Form
    {

        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IMarkParamService _serviceMP;
        private readonly IParametrService _serviceP;
        List<MarkParametr> markParametrs;
        public Form_AddParam(IParametrService serviceP, IMarkParamService serviceMP)
        {
            _serviceP = serviceP;
            _serviceMP = serviceMP;
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            markParametrs = new List<MarkParametr>();

            markParametrs.Add(new MarkParametr
            {
                Mark = Marks.Низкая,
                Down = (int)numericUpDown_MalDown.Value,
                Average = (int)numericUpDown_MalAr.Value,
                Up = (int)numericUpDown_MalUp.Value
            });
            markParametrs.Add(new MarkParametr
            {
                Mark = Marks.Средняя,
                Down = (int)numericUpDown_ArDow.Value,
                Average = (int)numericUpDown_ArAr.Value,
                Up = (int)numericUpDown_ArUp.Value
            });
            markParametrs.Add(new MarkParametr
            {
                Mark = Marks.Высокая,
                Down = (int)numericUpDown_BigDown.Value,
                Average = (int)numericUpDown_BigAr.Value,
                Up = (int)numericUpDown_BigUp.Value
            });

            _serviceP.CreateElement(new ParametrBM
            {
                Name=textBox_Name.Text,
                MarkParametrs=markParametrs
            });
        }
    }
}
