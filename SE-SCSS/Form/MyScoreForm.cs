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
    public partial class MyScoreForm : Form
    {
        private string sno;
        public MyScoreForm(string sno)
        {
            this.sno = sno;
            InitializeComponent();
        }

        private void MyScoreForm_Load(object sender, EventArgs e)
        {
            int sum = 0, avg = 0;
            string sql = $"select distinct course.cno,cname,ccredit,score from scourse,course where " +
                $"scourse.cno = course.cno and sno = {sno}";
            var dr = DbUtil.DataReader(sql);
            while (dr.Read())
            {
                string a, b, c, d;
                a = dr[0].ToString();
                b = dr[1].ToString();
                c = dr[2].ToString();
                d = dr[3].ToString();

                dataGridView1.Rows.Add(a, b, c, d);
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string num = dataGridView1.Rows[i].Cells[3].Value.ToString();
                int.TryParse(num, out int temp);
                sum += temp;
            }
            avg = sum / dataGridView1.Rows.Count;
            textBox1.Text = avg.ToString();
        }
    }
}
