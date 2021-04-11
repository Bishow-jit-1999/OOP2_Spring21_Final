using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Insert_into_db
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ADDCOURSE(object sender, EventArgs e)
        {
            string c_name = tbName.Text;
            string c_code = tbCode.Text;

            var conn = Database.ConnectDB();
            conn.Open();
            string query = string.Format("insert into courses values ('{0}','{1}')", c_name, c_code);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Data inserted");
            }
            else
            {
                MessageBox.Show("Not inserted");
            }

            var list = Getcourses();
            dt_courses.DataSource = list;
            conn.Close();
        }

        private void load_the_data(object sender, EventArgs e)
        {
            var list = Getcourses();
            dt_courses.DataSource = list;
        }

        private List<COURSE> Getcourses()
        {
            var conn = Database.ConnectDB();
            conn.Open();
            string query = "select * from courses";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<COURSE> list = new List<COURSE>();
            while (reader.Read())
            {
                COURSE c = new COURSE();
                c.id = reader.GetInt32(reader.GetOrdinal("Id"));
                c.Course_Name = reader.GetString(reader.GetOrdinal("CourseName"));
                c.Course_Code = reader.GetString(reader.GetOrdinal("CourseCode"));

                list.Add(c);
            }
            conn.Close();
            return list;
            
        }

        private void LOAD_DATA(object sender, EventArgs e)
        {
            var list = Getcourses();
            dt_courses.DataSource = list;
        }
    }
}
