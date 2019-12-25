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
        List<MarkParametrBM> markParametrs;

        public int userId { get; set; }

        public int Id { set { id = value; } }
        private int? id;

        public Form_AddParam(IParametrService serviceP, IMarkParamService serviceMP)
        {
            _serviceP = serviceP;
            _serviceMP = serviceMP;
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                List<MarkParametr> markParametrsBMs = new List<MarkParametr>();
                for (int i = 0; i < markParametrs.Count; ++i)
                {
                    markParametrsBMs.Add(new MarkParametr
                    {
                        Id = markParametrs[i].Id,
                      //  ParametrId = markParametrs[i].ParametrId,
                        Average= markParametrs[i].Average,
                        Down= markParametrs[i].Down,
                        Up= markParametrs[i].Up,
                        Mark= markParametrs[i].Mark,
                        UserId=userId
                    });
                }
                if (markParametrsBMs.Count == 0)
                {
                    MessageBox.Show("Список продуктов пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (id.HasValue)
                {
                    _serviceP.UpdElement(new ParametrBM
                    
                    {
                        Id=(int)id,
                        Name = textBox_Name.Text,
                        Choosing = true,
                        MarkParametrs = markParametrsBMs
                    }); 
                }
                else
                {
                    _serviceP.CreateElement(new ParametrBM
                    {
                        ///////////////
                        Name = textBox_Name.Text,
                        Choosing = true,
                        MarkParametrs = markParametrsBMs
                    });
                }
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /* markParametrs.Add(new MarkParametr
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
             if (id.HasValue)
             {
                 _serviceP.UpdElement(new ParametrBM
                 {
                     Id = id.Value,
                     MarkParametrs = markParametrs
                 });
             }
             else
             {
                 _serviceP.CreateElement(new ParametrBM
                 {
                     Name = textBox_Name.Text,
                     MarkParametrs = markParametrs,
                     UserId=userId
                 });
             }
            ParametrBM parametrBM = new ParametrBM
            {
                Name = textBox_Name.Text
            };
            _serviceP.CreateElement(parametrBM);
*/


        }

        private void Form_AddParam_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    ParametrBM view = _serviceP.GetElement(id.Value,userId);
                    if (view != null)
                    {
                        textBox_Name.Text = view.Name;
                       // markParametrs = view.MarkParametrs;
                        LoadData();
                    }
                    markParametrs = _serviceMP.GetList(view,userId);

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              //  button_OK.Enabled = false;
              //  button_Del.Enabled = false;
//button_Add.Enabled = false;
            }
            else
            {
                markParametrs = new List<MarkParametrBM>();
            }
            LoadData();

        }

        private void LoadData()
        {
            /* ParametrBM par = _serviceP.GetElement(id.Value);
            List<MarkParametrBM> markParametrs = _serviceMP.GetList(par);
           
            foreach (MarkParametrBM mp in markParametrs)
            {
                if (mp.Mark == Marks.Низкая)
                {
                    numericUpDown_MalDown.Value = mp.Down;
                    numericUpDown_MalAr.Value = mp.Average;
                    numericUpDown_MalUp.Value = mp.Up;
                }
                if (mp.Mark == Marks.Средняя)
                {
                    numericUpDown_ArDow.Value = mp.Down;
                    numericUpDown_ArAr.Value = mp.Average;
                    numericUpDown_ArUp.Value = mp.Up;
                }
                if (mp.Mark == Marks.Высокая)
                {
                    numericUpDown_BigDown.Value = mp.Down;
                    numericUpDown_BigAr.Value = mp.Average;
                    numericUpDown_BigUp.Value = mp.Up;
                }
            }*/
            /*
            try
            {
                if (markParametrs != null)
                {
                    dataGridView_MarkParams.DataSource = null;
                    dataGridView_MarkParams.DataSource = markParametrs;
                    //F_Products.Columns[0].Visible = false;
                    //  F_Products.Columns[1].Visible = false;
                    //   F_Products.Columns[2].Visible = false;
                    // F_Products.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

       

        private void button_Del_Click(object sender, EventArgs e)
        {/*
            if (dataGridView_MarkParams.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        markParametrs.RemoveAt(dataGridView_MarkParams.SelectedRows[0].Cells[0].RowIndex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _serviceP.CreateElement(new ParametrBM
            {
                ///////////////
                Name = textBox_Name.Text
            });
            MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }
    }
}
