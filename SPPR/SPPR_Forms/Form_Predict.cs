using SPPR;
using SPPR_Services;
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
    public partial class Form_Predict : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ITrendService _serviceTr;
        private readonly IParametrService _serviceP;
        private readonly ITelephoneService _serviceT;

        private readonly ITelepParamService _serviceTP;
        private readonly IMarkParamService _serviceMP;

        List<Tend> tends;
        List<ParamMark> paramMarks;

        BindingSource sourse;
        //  List<Marks> vrNech;
        public Form_Predict(ITrendService serviceTr, IParametrService serviceP, ITelepParamService serviceTP, IMarkParamService serviceMP, ITelephoneService serviceT)
        {
            _serviceP = serviceP;
            _serviceTP = serviceTP;
            _serviceTr = serviceTr;
            _serviceMP = serviceMP;
            _serviceT = serviceT;
            InitializeComponent();
        }

        private void Form_Predict_Load(object sender, EventArgs e)
        {
            tends = new List<Tend>();
            paramMarks = new List<ParamMark>();
            //заполняем tends
            foreach (Marks m1 in Enum.GetValues(typeof(Marks)))
            {
                foreach (Marks m2 in Enum.GetValues(typeof(Marks)))
                {
                    foreach (Marks m3 in Enum.GetValues(typeof(Marks)))
                    {
                        Tend t = new Tend(m1, m2, m3);
                        if (m1 < m3)
                        {
                            t.name = "рост";
                        }
                        if (m1 == m3)
                        {
                            t.name = "стабильность";
                        }
                        if (m1 > m3)
                        {
                            t.name = "спад";
                        }
                        tends.Add(t);
                    }
                }
            }

            List<TelephoneBM> telephones = _serviceT.GetSortList();

            foreach (ParametrBM parametr in _serviceP.GetList())
            {
                List<Marks> vrNech = new List<Marks>(); ;
                foreach (var tel in telephones)
                {
                    List<TelepParamBM> telepParamBMs = _serviceTP.GetList();
                    var telpar = _serviceTP.GetElement(parametr.Id, tel.Id);
                    try
                    {
                        vrNech.Add(GetMarky(parametr, telpar.Value));
                    }
                    catch { }
                }

                for (int i = 0; i < vrNech.Count - 2; i++)
                {
                    foreach (var trend in tends)
                    {
                        if (vrNech[i] == trend.first && vrNech[i + 1] == trend.second && vrNech[i + 2] == trend.third)
                        {
                            trend.count++;
                        }
                    }
                }
                Marks first = vrNech[vrNech.Count - 2];
                Marks second = vrNech[vrNech.Count - 1];


                Marks mark = Marks.Средняя;
                int max = 0;
                foreach (var trend in tends)
                {
                    if (trend.first == first & trend.second == second)
                    {
                        if (trend.count > max)
                        {
                            mark = trend.third;
                            max = trend.count;
                        }
                    }
                }
                paramMarks.Add(new ParamMark
                {
                    par= parametr.Name,
                    Mark= mark
                });
            }
            sourse = new BindingSource();
            sourse.DataSource = paramMarks;
            dataGridView_Pred.DataSource = sourse;
        }
        public Marks GetMarky(ParametrBM parametr, int chislo)
        {
            Marks m = Marks.Средняя;
            int prin = 0;

            List<MarkParametrBM> markParametrs = _serviceMP.GetList(parametr);

            foreach (MarkParametrBM mp in markParametrs)
            {
                int down = mp.Down;
                int av = mp.Average;
                int up = mp.Up;
                int p = 0;
                if (chislo <= av)
                {
                    if (down == 0)
                    {
                        p = 0;
                    }
                    else
                    {
                        p = chislo / down;
                    }
                }
                else
                {
                    p = 1 - chislo / up;
                }
                if (p > prin)
                {
                    prin = p;
                    m = mp.Mark;
                }

            }

            return m;
        }
    }
}
