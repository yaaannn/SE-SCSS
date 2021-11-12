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
    public partial class MyCourseForm : Form
    {
        string sno;
        public MyCourseForm(string sno)
        {
            this.sno = sno;
            InitializeComponent();
        }

        private void MyCourseForm_Load(object sender, EventArgs e)
        {
            string sql1 = $"select * from scourse where sno = {sno}";
            var dr1 = DbUtil.DataReader(sql1);

            while (dr1.Read())
            {
                string cno = dr1["cno"].ToString();
                string sql2 = $"select * from course where cno = '{cno}'";
                var dr2 = DbUtil.DataReader(sql2);
                while (dr2.Read())
                {
                    string a, b, c, d, e1;
                    a = dr2[0].ToString();
                    b = dr2[1].ToString();
                    c = dr2[2].ToString();
                    d = dr2[3].ToString();
                    e1 = dr2[4].ToString();
                    string[] str = { a, b, c, d, e1 };
                    dataGridView1.Rows.Add(str);
                }
            }
        }

        private void MyCourseForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
