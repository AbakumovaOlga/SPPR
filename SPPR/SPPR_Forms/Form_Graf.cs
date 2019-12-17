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
    public partial class Form_Graf : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IParametrService _serviceP;
        private readonly ITelephoneService _serviceT;
        private readonly IMarkParamService _serviceMP;
        private readonly ITelepParamService _serviceTP;
        public Form_Graf(IParametrService serviceP, ITelepParamService serviceTP, IMarkParamService serviceMP, ITelephoneService serviceT)

        {
            _serviceP = serviceP;
            _serviceTP = serviceTP;
            _serviceMP = serviceMP;
            _serviceT = serviceT;
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                return;
            }
            List<TelephoneBM> telephones = _serviceT.GetSortList();
            int parId = Convert.ToInt32(comboBox1.SelectedValue);
            ParametrBM par = _serviceP.GetElement(parId);
            List<Marks> vrNech = new List<Marks>();
            Console.WriteLine("_______");
            foreach (var tel in telephones)
            {
                Console.WriteLine(tel.Date + "");
                List<TelepParamBM> telepParamBMs = _serviceTP.GetList();
                var telpar = _serviceTP.GetElement(parId, tel.Id);
                try
                {
                    Marks m = GetMarky(par, telpar.Value);
                    Console.WriteLine(m.ToString());
                    vrNech.Add(m);
                }
                catch { }
            }
            chart_Grap.Series.Clear();
            int k = 0;
            foreach (Marks mar in vrNech)
            {

                chart_Grap.Series.Add(k + "");
                switch (mar)
                {
                    case Marks.Низкая:
                        {
                            chart_Grap.Series[k + ""].Points.AddY(10);
                            break;
                        }
                    case Marks.Средняя:
                        {
                            chart_Grap.Series[k + ""].Points.AddY(50);
                            break;
                        }
                    case Marks.Высокая:
                        {
                            chart_Grap.Series[k + ""].Points.AddY(100);
                            break;
                        }
                }
                k++;
                // chart_Grap.Series[mar.ToString()].Points.AddY();
            }


        }

        public Marks GetMarky(ParametrBM parametr, int chislo)
        {
            Marks m = Marks.Средняя;
            double prin = -100;

            List<MarkParametrBM> markParametrs = _serviceMP.GetList(parametr);

            foreach (MarkParametrBM mp in markParametrs)
            {
                double down = mp.Down;
                double av = mp.Average;
                double up = mp.Up;
                double p = -100;
                if (chislo < av)
                {
                    if (down == 0)
                    {
                        p = 0;
                    }
                    else
                    {
                        p = (chislo - down) / down;
                    }
                }
                else if (chislo == av)
                {
                    p = 1;
                }
                else
                {
                    p = 2 - (chislo / av);
                }
                if (p > prin)
                {
                    prin = p;
                    m = mp.Mark;
                }

            }

            return m;
        }

        private void Form_Graf_Load(object sender, EventArgs e)
        {
            try
            {
                List<ParametrBM> list = _serviceP.GetList();
                if (list != null)
                {
                    comboBox1.DisplayMember = "Name";
                    comboBox1.ValueMember = "Id";
                    comboBox1.DataSource = list;
                    comboBox1.SelectedItem = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
