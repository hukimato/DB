using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace lab5
{
    


    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlBuilder = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataSet = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_FULL.Class". При необходимости она может быть перемещена или удалена.
            this.classTableAdapter.Fill(this.dB_FULL.Class);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_FULL.Faculty". При необходимости она может быть перемещена или удалена.
            this.facultyTableAdapter.Fill(this.dB_FULL.Faculty);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_FULL.St_Group". При необходимости она может быть перемещена или удалена.
            this.st_GroupTableAdapter.Fill(this.dB_FULL.St_Group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_FULL.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter2.Fill(this.dB_FULL.Student);


            List<String> Group_nums = new List<String>();
            List<int> Group_students = new List<int>();
            try
            {
                sqlConnection = new SqlConnection(@"Data Source=HUKIMATO-MI-N;Initial Catalog=lab2;Integrated Security=True");
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM St_Group ", sqlConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Group_nums.Add(reader.GetString(reader.GetOrdinal("Num")));
                    Group_students.Add(reader.GetByte(reader.GetOrdinal("Students")));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            chart3.Series.Clear();
            // Добавить и форматировать заголовок
            chart3.Titles.Add("Кол-во студентов");
            chart3.Titles[0].Font = new Font("Utopia", 16);

            chart3.Series.Add(new Series("Groups")
            {
                //ChartType = SeriesChartType.Pie
            });

            // Salary series data
            int[] yValues = Group_students.ToArray();
            String[] xValues = Group_nums.ToArray();
            chart3.Series["Groups"].Points.DataBindXY(xValues, yValues);




            List<String> Faculty_title = new List<String>();
            List<int> Places = new List<int>();
            for(int i = 0; i < yValues.Length; i++)
            {
                Places.Add(0);
                Faculty_title.Add(xValues[i]);
            }
            try
            {
                sqlConnection = new SqlConnection(@"Data Source=HUKIMATO-MI-N;Initial Catalog=lab2;Integrated Security=True");
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Faculty ", sqlConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Faculty_title.Add(reader.GetString(reader.GetOrdinal("Short_title")));
                    Places.Add(reader.GetInt32(reader.GetOrdinal("Places")));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
            // Добавить и форматировать заголовок

            chart3.Series.Add(new Series("Faculties")
            {
                //ChartType = SeriesChartType.Pie
            });

            // Salary series data
            int[] yValues1 = Places.ToArray();
            String[] xValues1 = Faculty_title.ToArray();
            chart3.Series["Faculties"].Points.DataBindXY(xValues1, yValues1);

            chart3.ChartAreas[0].AxisX.Interval = 1;

            //---------------------------------------------char4-----------------------------------------------------



            chart4.Series.Clear();
            List<Student> students = new List<Student>();
            try
            {
                sqlConnection = new SqlConnection(@"Data Source=HUKIMATO-MI-N;Initial Catalog=lab2;Integrated Security=True");
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Student", sqlConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    students.Add(new Student(
                        reader.GetString(reader.GetOrdinal("FIO")),
                        reader.GetInt32(reader.GetOrdinal("Year"))
                        ));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int[] yValues2 = { 0, 0, 0, 0 };
            for (int i = 0; i < students.Count; i++)
            {
                yValues2[students[i].Year-1] += 1;
            }

            chart4.Titles.Add("Отношение кол-ва студентов разных курсов");
            chart4.Titles[0].Font = new Font("Utopia", 12);

            chart4.Series.Add(new Series("Series1")
            {
                ChartType = SeriesChartType.Pie
            });
            
            String[] xValues2 = {"1 Курс", "2 Курс", "3 Курс", "4 Курс" };
            chart4.Series["Series1"].Points.DataBindXY(xValues2, yValues2);
        }
    }
}