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
    public partial class TeacherMainForm : Form
    {
        private string tno;
        public TeacherMainForm(string tno)
        {
            this.tno = tno;
            InitializeComponent();
        }

        private void RefreshTable()
        {
            dataGridView1.Rows.Clear();
            string sql = $"select course.cno,course.cname,scourse.sno,student.sname,scourse.score from " +
               $"tcourse,course,scourse,student where " +
               $"tcourse.cno = course.cno = scourse.cno and scourse.sno = student.sno and tcourse.tno = {tno}";
            var dr = DbUtil.DataReader(sql);
            while (dr.Read())
            {
                string a, b, c, d, e1;
                a = dr[0].ToString();
                b = dr[1].ToString();
                c = dr[2].ToString();
                d = dr[3].ToString();
                e1 = dr[4].ToString();
                string[] str = { a, b, c, d, e1 };
                dataGridView1.Rows.Add(str);
            }
        }

        private void TeacherMainForm_Load(object sender, EventArgs e)
        {
            string sql = $"select tname from teacher where tno = {tno}";
            var dr = DbUtil.DataReader(sql);
            dr.Read();
            toolStripStatusLabel1.Text = "欢迎 " + dr[0].ToString() + " 老师";
            RefreshTable();
            //string sno = dr["sno"].ToString();
            //MessageBox.Show(sno);
        }

        private void 修改成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int a = dataGridView1.SelectedRows
            string sno = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ModifyStudentScore modifyStudentScore = new ModifyStudentScore(sno);
            modifyStudentScore.ShowDialog();


        }

        private void 刷新成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
