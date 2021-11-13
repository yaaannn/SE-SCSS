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

        private void Button_Login_Click(object sender, EventArgs e)
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
                    string sno = dr["sno"].ToString();
                    StudentMainForm studentMainForm = new StudentMainForm(sno);
                    MessageBox.Show(sno);
                    studentMainForm.ShowDialog();
                }
            }
            else if (role == "教师")
            {
                string sql = $"select tno, tpwd from teacher where tno = '{id}' and tpwd = '{pwd}'";
                var dr = DbUtil.DataReader(sql);
                if (dr.Read())
                {
                    string tno = dr["tno"].ToString();
                    TeacherMainForm teacherMainForm = new TeacherMainForm(tno);
                    MessageBox.Show(tno);
                    teacherMainForm.ShowDialog();

                }
            }
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
