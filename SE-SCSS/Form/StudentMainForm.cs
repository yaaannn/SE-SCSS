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
    public partial class StudentMainForm : Form
    {
        private string sno;
        public StudentMainForm(string sno)
        {
            this.sno = sno;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string sql = "select course.cno ,cname,ccredit,ctime,tname ,croom from tcourse,teacher,course ";
            var dr = DbUtil.DataReader(sql);
            while (dr.Read())
            {
                string a, b, c, d, e1, f;
                a = dr[0].ToString();
                b = dr[1].ToString();
                c = dr[2].ToString();
                d = dr[3].ToString();
                e1 = dr[4].ToString();
                f = dr[5].ToString();
                string[] str = { a, b, c, d, e1, f };
                dataGridView1.Rows.Add(str);
            }
            //var adp = DbUtil.DataAdapter(sql);
            //DataSet ds = new DataSet();
            //adp.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void 修改信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyStudentInfo modifyStudentInfo = new ModifyStudentInfo(sno);
            modifyStudentInfo.ShowDialog();
        }

        private void 退出toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_SelectCourse_Click(object sender, EventArgs e)
        {
            string cno = dataGridView1.SelectedCells[0].Value.ToString();
            string sql = $"select * from scourse where " +
                $"sno = '{sno}' and cno = '{cno}'";
            var dr = DbUtil.DataReader(sql);
            if (!dr.Read())
            {
                string sql1 = $"insert into scourse values('{sno}','{cno}',null)";
                if (DbUtil.AppandData(sql1))
                    MessageBox.Show("选课成功", "成功");
                else
                    MessageBox.Show("选课失败", "失败");
            }
            else
            {
                MessageBox.Show("不允许重复选课", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //MessageBox.Show(cno);
        }

        private void 我的课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyCourseForm myCourseForm = new MyCourseForm(sno);
            //this.Hide();
            myCourseForm.ShowDialog();

        }

        private void 我的成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyScoreForm myScoreForm = new MyScoreForm(sno);
            myScoreForm.ShowDialog();
        }
    }
}
