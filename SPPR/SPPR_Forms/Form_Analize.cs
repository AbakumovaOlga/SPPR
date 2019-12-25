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
    public partial class Form_Analize : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ITelephoneService _serviceT;
        private readonly IParametrService _serviceP;
        private readonly IMarkParamService _serviceMP;

        public int userId { get; set; }
        public int Id { set { id = value; } }
        private int? id;

        private List<TrebParam> TrebParams;

        public Form_Analize(ITelephoneService serviceT, IParametrService serviceP, IMarkParamService serviceMP)
        {
            _serviceT = serviceT;
            _serviceP = serviceP;
            _serviceMP = serviceMP;
            InitializeComponent();
            TrebParams = new List<TrebParam>();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            
            var form = Container.Resolve<Form_ParamTreb>();
            form.userId = userId;
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.model != null)
                {
                    if (id.HasValue)
                    {
                        form.model.Id = id.Value;
                    }
                    TrebParams.Add(form.model);
                }
                LoadData();
            }
        }

        private void LoadData()
        {
            try
            {
                if (TrebParams != null)
                {
                    dataGridView_Treb.DataSource = null;
                    dataGridView_Treb.DataSource = TrebParams;
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
            if (dataGridView_Treb.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        TrebParams.RemoveAt(dataGridView_Treb.SelectedRows[0].Cells[0].RowIndex);
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
            List<TelephoneBM> tels = _serviceT.GetList();
            foreach(var treb in TrebParams) //требования
            {
                for(int i=0;i< tels.Count; i++ )
                {
                    foreach(var par in tels[i].TelepParams)
                    {
                        ParametrBM param = _serviceP.GetElement(par.ParametrId);
                        if(par.ParametrId==treb.ParametrId)
                        {
                            if (GetMarky(param, par.Value) != treb.Mark)
                            {
                                tels.Remove(tels[i]);
                                i--;
                            }
                        }
                    }
                }
            }

            var form = Container.Resolve<Form_Res>();
            form.list = tels;
            form.Show();
        }

        public Marks GetMarky(ParametrBM parametr, int chislo)
        {
            Marks m = Marks.Средняя;
            double prin = -100;

            List<MarkParametrBM> markParametrs = _serviceMP.GetList(parametr,userId);

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
    }
}
