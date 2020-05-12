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
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class AddTeacherForm : Form
    {
        MySqlConnection mysql_connection;
        public AddTeacherForm()
        {
            InitializeComponent();
            mysql_connection = connectDataBase();
            ListCK.HorizontalScrollbar = true;
            createToolTip(TextString3, "Дата повинна мати формат: дд.мм.рррр");
        }

        private void createToolTip(Control controlForToolTip, string toolTipText)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Active = true;
            toolTip.SetToolTip(controlForToolTip, toolTipText);
            toolTip.IsBalloon = true;
        }


        public MySqlConnection connectDataBase()
        {
            string host = "localhost"; // Имя хоста
            string database = "hrtk_teachers"; // Имя базы данных
            string user = "root"; // Имя пользователя
            string password = "root"; // Пароль пользователя
            string Connect = "Database=" + database + ";Datasource=" + host + ";User=" + user + ";Password=" + password + ";CharSet=utf8";
            MySqlConnection mysql_connection = new MySqlConnection(Connect);
            return mysql_connection;
        }

        MySqlCommand uploadingData(MySqlConnection mysql_connection, string command)
        {
            MySqlCommand mysql_query = mysql_connection.CreateCommand();
            mysql_query.CommandText = command; //Объект MySqlConnection — соединение с базой данных. Следующим шагом мы создаем объект MySqlCommand с именем mysql_query используя текущее подключение создаем SQL запрос, который будет храниться в mysql_query. Объект MySqlCommand — выполняет SQL команд.
            return mysql_query;
        }

        private void UploadingToDropMenu(MySqlConnection mysql_connection, MySqlCommand mysql_query)
        {
            ListCK.Items.Clear();
            mysql_connection.Open(); // Дальше для подключение и соединения с базой данных нужно вызвать метод .Open():
            MySqlDataReader mysql_result; // Теперь, чтобы увидеть обработанный запрос нужно создать объект MySqlDataReader:
            mysql_result = mysql_query.ExecuteReader(); //
            if (mysql_result.HasRows)
            {
                while (mysql_result.Read())
                {
                    ListCK.Items.Add(mysql_result.GetString(1));
                }
            }
            mysql_result.Close();
            mysql_connection.Close();
        }

        private void AddForm_Activated(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            if (main.LabelTeachers.ForeColor == Color.Aqua)
            {
                LabelString1.Text = "Циклова комісія";
                LabelString1.ForeColor = Color.LightGray;
                //TextString1.Text = "Циклова комісія";
                //TextString1.ForeColor = Color.LightGray;
                TextString2.Text = "Викладач";
                TextString2.ForeColor = Color.LightGray;
                TextString3.Text = "Дата народження";
                TextString3.ForeColor = Color.LightGray;
                TextString4.Text = "Заклад освіти";
                TextString4.ForeColor = Color.LightGray;
                TextString5.Text = "Спеціалізація за фахом";
                TextString5.ForeColor = Color.LightGray;
                TextString6.Text = "Основний предмет";
                TextString6.ForeColor = Color.LightGray;
                TextString7.Text = "Дата останньої атестації";
                TextString7.ForeColor = Color.LightGray;
            }
        }

        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void ArrowList_Click(object sender, EventArgs e)
        {
            UploadingToDropMenu(mysql_connection, uploadingData(mysql_connection, "Select * from c_komisiya"));
            ListCK.Visible = true;
            ArrowList.Visible = false;
            ListIconActive.Visible = true;
        }
        private void ListIconActive_Click(object sender, EventArgs e)
        {
            ListCK.Visible = false;
            ArrowList.Visible = true;
            ListIconActive.Visible = false;
        }
        private void ListCK_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelString1.Text = ListCK.SelectedItem.ToString();
            //TextString1.Text = ListCK.SelectedItem.ToString();
            //TextString1.Enabled = false;                        
        }
        // ck// Замена с текстстринг на лейблстринг
        /*
        private void TextString1_Enter(object sender, EventArgs e)
        {
            if (TextString1.Text == "Циклова комісія")
            {
                TextString1.Text = "";
            }
        }

        private void TextString1_Leave(object sender, EventArgs e)
        {
            if (TextString1.Text == "")
            {
                TextString1.Text = "Циклова комісія";
                TextString1.ForeColor = Color.LightGray;
            }
        }
        */
        // teacher
        private void TextString2_Enter(object sender, EventArgs e)
        {
            if (TextString2.Text == "Викладач")
            {
                TextString2.Text = "";
            }
        }

        private void TextString2_Leave(object sender, EventArgs e)
        {
            if (TextString2.Text == "")
            {
                TextString2.Text = "Викладач";
                TextString2.ForeColor = Color.LightGray;
            }
        }
        // Дата народження
        private void TextString3_Enter(object sender, EventArgs e)
        {
            if (TextString3.Text == "Дата народження")
            {
                TextString3.Text = "";
            }
        }

        private void TextString3_Leave(object sender, EventArgs e)
        {
            if (TextString3.Text == "")
            {
                TextString3.Text = "Дата народження";
                TextString3.ForeColor = Color.LightGray;
            }
        }
        // Zakl osviti
        private void TextString4_Enter(object sender, EventArgs e)
        {
            if (TextString4.Text == "Заклад освіти")
            {
                TextString4.Text = "";
            }
        }

        private void TextString4_Leave(object sender, EventArgs e)
        {
            if (TextString4.Text == "")
            {
                TextString4.Text = "Заклад освіти";
                TextString4.ForeColor = Color.LightGray;
            }
        }
        // Спеціалізація за фахом
        private void TextString5_Enter(object sender, EventArgs e)
        {
            if (TextString5.Text == "Спеціалізація за фахом")
            {
                TextString5.Text = "";
            }
        }

        private void TextString5_Leave(object sender, EventArgs e)
        {
            if (TextString5.Text == "")
            {
                TextString5.Text = "Спеціалізація за фахом";
                TextString5.ForeColor = Color.LightGray;
            }
        }
        // Основний предмет
        private void TextString6_Enter(object sender, EventArgs e)
        {
            if (TextString6.Text == "Основний предмет")
            {
                TextString6.Text = "";
            }
        }

        private void TextString6_Leave(object sender, EventArgs e)
        {
            if (TextString6.Text == "")
            {
                TextString6.Text = "Основний предмет";
                TextString6.ForeColor = Color.LightGray;
            }
        }
        // Дата останньої атестації
        private void TextString7_Enter(object sender, EventArgs e)
        {
            if (TextString7.Text == "Дата останньої атестації")
            {
                TextString7.Text = "";
            }
        }

        private void TextString7_Leave(object sender, EventArgs e)
        {
            if (TextString7.Text == "")
            {
                TextString7.Text = "Дата останньої атестації";
                TextString7.ForeColor = Color.LightGray;
            }
        }
        // Icon calendar
        private void CalendarNonActive_Click(object sender, EventArgs e)
        {
            CalendarNonActive.Visible = false;
            CalendarActive.Visible = true;
            Calendar.Visible = true;
        }
        // Icon calendar
        private void CalendarActive_Click(object sender, EventArgs e)
        {
            CalendarNonActive.Visible = true;
            CalendarActive.Visible = false;
            Calendar.Visible = false;
        }
        //Calendar
        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            TextString3.Text = String.Format( Calendar.SelectionStart.ToShortDateString());
        }
    }
}
// TEST
