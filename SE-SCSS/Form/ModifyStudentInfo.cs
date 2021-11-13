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

    public partial class ModifyStudentInfo : Form
    {
        private string sno;
        public ModifyStudentInfo(string sno)
        {
            this.sno = sno;
            InitializeComponent();
        }

        private void ModifyStudentInfo_Load(object sender, EventArgs e)
        {
            string sql = $"select sno,sname,ssex,sbirth,sphone,saddress from student where sno = {sno}";
            var dr = DbUtil.DataReader(sql);
            while (dr.Read())
            {
                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                textBox4.Text = dr[3].ToString();
                textBox5.Text = dr[4].ToString();
                textBox6.Text = dr[5].ToString();

            }
        }
    }
}
