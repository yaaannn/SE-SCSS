using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_SCSS
{

    public partial class ModifyStudentScore : Form
    {
        private string sno;

        public ModifyStudentScore(string sno)
        {
            this.sno = sno;

            InitializeComponent();
        }

        private void Button_ModifyScore_Click(object sender, EventArgs e)
        {
            string score = textBox2.Text.ToString();
            string sql = $"update scourse set score = {score} where sno = {sno}";
            if (DbUtil.AppandData(sql))
            {
                MessageBox.Show("ok");

            }
            else
            {
                MessageBox.Show("false");
            }
        }

        private void ModifyStudentScore_Load(object sender, EventArgs e)
        {
            string sql = $"select score from scourse where sno = {sno}";
            var dr = DbUtil.DataReader(sql);
            dr.Read();
            textBox1.Text = dr[0].ToString();
        }
    }
}
