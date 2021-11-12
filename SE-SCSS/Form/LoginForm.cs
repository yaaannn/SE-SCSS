using MySql.Data.MySqlClient;
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

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text.Trim();
            string pwd = textBox_pwd.Text.Trim();
            string role = comboBox_role.Text.Trim();

            //MessageBox.Show(role);

            if (role == "学生")
            {
                string sql = $"select sno, spwd from student where sno = '{id}' and spwd = '{pwd}'";
                var dr = DbUtil.DataReader(sql);
                if (dr.Read())
                {
                    string SNO = dr["sno"].ToString();
                    StudentMainForm studentMainForm = new StudentMainForm(SNO);
                    MessageBox.Show(SNO);
                    studentMainForm.ShowDialog();
                }
            }
            else if (role == "教师")
            {
                string sql = string.Format("select tno, tpwd from teacher " +
                    "where tno = '{0}' and tpwd = '{1}'"
                    , id, pwd);
                var dr = DbUtil.DataReader(sql);
                if (dr.Read())
                {

                    //StudentMainForm studentMainForm = new StudentMainForm();
                    //studentMainForm.ShowDialog();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
