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
    public partial class MainForm : Form
    {
      MySqlConnection mysql_connection;
        public MainForm()
        {
            InitializeComponent();
            mysql_connection = connectDataBase();
            updatingGridDefault(mysql_connection, uploadingData(mysql_connection, "SELECT * FROM teachers;"));
            SearchCategoties.SelectedIndex = 0;
            LabelTeachers.ForeColor = Color.Aqua;
            
        }
        // Connecting database
        MySqlConnection connectDataBase()
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

        void updatingGridDefault(MySqlConnection mysql_connection, MySqlCommand mysql_query)
        {
            // Sql Command to variable
            dataGridView1.Rows.Clear();
            mysql_connection.Open(); // Дальше для подключение и соединения с базой данных нужно вызвать метод .Open():
            MySqlDataReader mysql_result; // Теперь, чтобы увидеть обработанный запрос нужно создать объект MySqlDataReader:
            mysql_result = mysql_query.ExecuteReader(); //
            
            if (mysql_result.HasRows)
            {
                while (mysql_result.Read())
                {
                    dataGridView1.Rows.Add(mysql_result.GetString(2),
                        mysql_result.GetString(3).Substring(0, mysql_result.GetString(3).Length - (mysql_result.GetString(3).Length - 10)), // Отрезать 00.00
                        mysql_result.GetString(4),
                        mysql_result.GetString(5),
                        mysql_result.GetString(6),
                        mysql_result.GetString(7).Substring(0, mysql_result.GetString(7).Length - (mysql_result.GetString(7).Length - 10))); // Отрезать 00.00

                }
            }
            mysql_result.Close();
            mysql_connection.Close();
        }
        // Text box search enter mask
        private void TextBoxSearch_Enter(object sender, EventArgs e) 
        { 
             if (TextBoxSearch.Text == "Пошук")
             {
             TextBoxSearch.Text = "";
             TextBoxSearch.ForeColor = Color.LightGray;
            }
        }
        // Text box search leave mask
        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text == "")
            {
                TextBoxSearch.Text = "Пошук";
                TextBoxSearch.ForeColor = Color.LightGray;
                if (LabelTeachers.ForeColor == Color.Aqua)
                { 
                    MySqlCommand comm = uploadingData(mysql_connection, "SELECT * FROM teachers; "); 
                    updatingGridDefault(mysql_connection, comm);
                }
                if (LabelCKonissiya.ForeColor == Color.Aqua) 
                { 
                    MySqlCommand comm = uploadingData(mysql_connection, "SELECT * FROM c_komisiya;"); 
                    updatingGridCKom(mysql_connection, comm); 
                }
                if (LabelMetObesp.ForeColor == Color.Aqua) 
                { 
                    MySqlCommand comm = uploadingData(mysql_connection,
                        "SELECT metod_zab.mz_pred_name, metod_zab_type.mzt_type, metod_zab.mz_year, teachers.t_namesecname " +
                        "FROM metod_zab, metod_zab_type,teachers " +
                        "Where mz_t_id = teachers.t_id and  metod_zab_type.mzt_id = metod_zab.mz_type_id;"); // ПРАБЛЕМА ТУТЬ
                    updatingGridMetObesp(mysql_connection, comm); 
                }
                if (LabelMetObespType.ForeColor == Color.Aqua)
                { 
                    MySqlCommand comm = uploadingData(mysql_connection, "SELECT mzt_type FROM metod_zab_type;"); 
                    updatingGridMetObespType(mysql_connection, comm); 
                }
                if (LabelSertifictati.ForeColor == Color.Aqua) 
                {
                    MySqlCommand comm = uploadingData(mysql_connection, "SELECT s_zakl, s_temat, s_kol_god, s_data, teachers.t_namesecname " +
                    "FROM hrtk_teachers.sertificati, hrtk_teachers.teachers  where sertificati.s_t_id = teachers.t_id;"); 
                    updatingGridSertifictati(mysql_connection, comm);
                }
                if (LabelPubAndKonf.ForeColor == Color.Aqua) 
                {
                    MySqlCommand comm = uploadingData(mysql_connection,
                    "SELECT teachers.t_namesecname, pub_and_konf.pak_date, pub_and_konf.pak_city, pub_and_konf.pak_tematika, " +
                    "pub_and_konf.pac_name_doc, pub_and_konf.pac_type " +
                    "from pub_and_konf, teachers " +
                    "where teachers.t_id = pub_and_konf.pak_t_id"); 
                    updatingGridPubAndKonf(mysql_connection, comm);
                }
                if (LabelPovKval.ForeColor == Color.Aqua) 
                {
                     MySqlCommand comm = uploadingData(mysql_connection,
                     "Select teachers.t_namesecname, pov_kval.pk_zakl, pov_kval.pk_napravl,pov_kval.pk_year " +
                     "from teachers, pov_kval " +
                     "where teachers.t_id = pov_kval.pk_t_id;");
                     updatingGridPovKvalf(mysql_connection, comm);
                }
            }
        }

        private void TextBoxSearch_MouseClick(object sender, MouseEventArgs e)
        {
            CloseMenuWithMouse();// Закрытие меню при нажатии не на меню
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            CloseMenuWithMouse();// Закрытие меню при нажатии не на меню
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ClosingMenu()// Закрытие меню
        {
            MenuToolBox.Visible = false;
            LabelTableText.Visible = false;
            ArrowClose.Visible = false;
            IconTable0Current.Visible = false;
            IconTable1.Visible = false;
            IconTable2.Visible = false;
            IconTable3.Visible = false;
            IconTable4.Visible = false;
            IconTable5.Visible = false;
            IconTable6.Visible = false;
            LabelAppName.Visible = false;
            LabelAppVersion.Visible = false;
            LabelCKonissiya.Visible = false;
            LabelSertifictati.Visible = false;
            LabelMetObespType.Visible = false;
            LabelPubAndKonf.Visible = false;
            LabelPovKval.Visible = false;
            LabelTeachers.Visible = false;
            LabelMetObesp.Visible = false;
        }

        private void CloseMenuWithMouse () 
        {
            if (MenuToolBox.Visible == true)
            {
                //Получаем координаты курсора
                int CursorX = Cursor.Position.X;
                int MenuW = MenuToolBox.Width;
                if (CursorX >= MenuW)
                {
                    ClosingMenu();
                }
            }
        }

        private void SearchIconNonActive_MouseHover(object sender, EventArgs e)
        {
            SearchIconActive.Visible = true;
            SearchIconNonActive.Visible = false;
        }

        private void SearchIconActive_MouseLeave(object sender, EventArgs e)
        {
            SearchIconActive.Visible = false;
            SearchIconNonActive.Visible = true;
        }

        private void SearchIconActive_Click(object sender, EventArgs e)
        {
            CloseMenuWithMouse();// Закрытие меню при нажатии не на меню
            if (LabelTeachers.ForeColor == Color.Aqua) // Label teachers search logic icon update
                // teachers
            {
                MySqlCommand comm = uploadingData(mysql_connection, "SELECT * FROM teachers;");
                if (TextBoxSearch.Text != "" || TextBoxSearch.Text != "Пошук")
                {
                    if (SearchCategoties.SelectedIndex == 0)
                    {
                        comm = uploadingData(mysql_connection, "SELECT *" +
                            " from teachers where t_namesecname = \"" + TextBoxSearch.Text + "\";");
                    }
                    else if (SearchCategoties.SelectedIndex == 1)
                    {
                        comm = uploadingData(mysql_connection, "SELECT * " +
                            "from teachers where t_o_predmet = \"" + TextBoxSearch.Text + "\";");
                    }
                    else if (SearchCategoties.SelectedIndex == 2)
                    {
                        comm = uploadingData(mysql_connection, "SELECT *" +
                            " from teachers where t_zakl_obraz = \"" + TextBoxSearch.Text + "\";");
                    }
                    updatingGridDefault(mysql_connection, comm);
                }
            }
            // c komis
            if (LabelCKonissiya.ForeColor == Color.Aqua)
            {
                MySqlCommand comm = uploadingData(mysql_connection, "SELECT * FROM c_komisiya;");
                if (TextBoxSearch.Text != "" || TextBoxSearch.Text != "Пошук")
                {
                    if (SearchCategoties.SelectedIndex == 0)
                    {
                        comm = uploadingData(mysql_connection, "SELECT *" +
                            " from c_komisiya where ck_name = \"" + TextBoxSearch.Text + "\";");
                    }
                    else if (SearchCategoties.SelectedIndex == 1)
                    {
                        comm = uploadingData(mysql_connection, "SELECT * " +
                            "from c_komisiya where ck_zav = \"" + TextBoxSearch.Text + "\";");
                    }
                    updatingGridCKom(mysql_connection, comm);
                }
            }
            // met obesp color
            if (LabelMetObesp.ForeColor == Color.Aqua) 
            {
                MySqlCommand comm = uploadingData(mysql_connection, 
                    "SELECT metod_zab.mz_pred_name, metod_zab_type.mzt_type, metod_zab.mz_year, teachers.t_namesecname " +
                    "FROM metod_zab, metod_zab_type,teachers;"+
                    "Where mz_t_id = teachers.t_id and  metod_zab_type.mzt_id = metod_zab.mz_type_id;");
                if (TextBoxSearch.Text != "" || TextBoxSearch.Text != "Пошук")
                {
                    if (SearchCategoties.SelectedIndex == 0)
                    {
                        comm = uploadingData(mysql_connection, 
                            "SELECT metod_zab.mz_pred_name, metod_zab_type.mzt_type, metod_zab.mz_year, teachers.t_namesecname " +
                            "FROM metod_zab, metod_zab_type,teachers " +
                            "where mz_t_id = teachers.t_id and  metod_zab_type.mzt_id = metod_zab.mz_type_id and mz_pred_name = \"" + TextBoxSearch.Text + "\";");
                    }
                    else if (SearchCategoties.SelectedIndex == 1)
                    {
                        comm = uploadingData(mysql_connection,
                            "SELECT metod_zab.mz_pred_name, metod_zab_type.mzt_type, metod_zab.mz_year, teachers.t_namesecname " +
                            "FROM metod_zab, metod_zab_type,teachers " +
                            "where  mz_t_id = teachers.t_id and  metod_zab_type.mzt_id = metod_zab.mz_type_id and mz_year = \"" + TextBoxSearch.Text + "\";");
                    }
                    else if (SearchCategoties.SelectedIndex == 2)
                    {
                        comm = uploadingData(mysql_connection,
                            "SELECT metod_zab.mz_pred_name, metod_zab_type.mzt_type, metod_zab.mz_year, teachers.t_namesecname " +
                            "FROM metod_zab, metod_zab_type,teachers " +
                            "where  mz_t_id = teachers.t_id and  metod_zab_type.mzt_id = metod_zab.mz_type_id and teachers.t_namesecname = \"" + TextBoxSearch.Text + "\";");
                    }
                    updatingGridMetObesp(mysql_connection, comm);
                }
            }
            //  Metod obespecheniye type
            if (LabelMetObespType.ForeColor == Color.Aqua) 
            {
                MySqlCommand comm = uploadingData(mysql_connection, "SELECT mzt_type FROM metod_zab_type;");
                if (TextBoxSearch.Text != "" || TextBoxSearch.Text != "Пошук")
                {
                    if (SearchCategoties.SelectedIndex == 0)
                    {
                        comm = uploadingData(mysql_connection, "SELECT mzt_type " +
                            " from metod_zab_type where mzt_type = \"" + TextBoxSearch.Text + "\";");
                    }
                    updatingGridMetObespType(mysql_connection, comm);
                }
            }
            // Sertifictati
            if (LabelSertifictati.ForeColor == Color.Aqua) 
            {
                MySqlCommand comm = uploadingData(mysql_connection, "SELECT s_zakl, s_temat, s_kol_god, s_data, teachers.t_namesecname " +
                    "FROM hrtk_teachers.sertificati, hrtk_teachers.teachers  where sertificati.s_t_id = teachers.t_id;");
                if (TextBoxSearch.Text != "" || TextBoxSearch.Text != "Пошук")
                {
                    if (SearchCategoties.SelectedIndex == 0)
                    {
                        comm = uploadingData(mysql_connection, "SELECT s_zakl, s_temat, s_kol_god, s_data, teachers.t_namesecname" +
                            " FROM hrtk_teachers.sertificati, hrtk_teachers.teachers  where sertificati.s_t_id = teachers.t_id " +
                            "and sertificati.s_zakl = \"" + TextBoxSearch.Text + "\";");
                    }
                    else if (SearchCategoties.SelectedIndex == 1)
                    {
                        comm = uploadingData(mysql_connection, "SELECT sertificati.s_zakl, sertificati.s_temat, sertificati.s_kol_god, sertificati.s_data, teachers.t_namesecname " +
                            "FROM hrtk_teachers.sertificati, hrtk_teachers.teachers  " +
                            "where sertificati.s_t_id = teachers.t_id and sertificati.s_temat = \""+ TextBoxSearch.Text + "\";");
                    }
                    else if (SearchCategoties.SelectedIndex == 2)
                    {
                        comm = uploadingData(mysql_connection, "SELECT s_zakl, s_temat, s_kol_god, s_data, teachers.t_namesecname " +
                            "from hrtk_teachers.sertificati, teachers where sertificati.s_t_id = teachers.t_id " +
                            "and teachers.t_namesecname = \"" + TextBoxSearch.Text + "\";");
                    }
                    updatingGridSertifictati(mysql_connection, comm);
                }
            }
            // pub and konf search
            if (LabelPubAndKonf.ForeColor == Color.Aqua) 
            {
                MySqlCommand comm = uploadingData(mysql_connection,
                "SELECT teachers.t_namesecname, pub_and_konf.pak_date, pub_and_konf.pak_city, pub_and_konf.pak_tematika, pub_and_konf.pac_name_doc, pub_and_konf.pac_type " +
                "from pub_and_konf, teachers " +
                "where teachers.t_id = pub_and_konf.pak_t_id");
                if (TextBoxSearch.Text != "" || TextBoxSearch.Text != "Пошук")
                {
                    if (SearchCategoties.SelectedIndex == 0)
                    {
                        comm = uploadingData(mysql_connection, "SELECT teachers.t_namesecname, pub_and_konf.pak_date, pub_and_konf.pak_city, " +
                            "pub_and_konf.pak_tematika, pub_and_konf.pac_name_doc, pub_and_konf.pac_type " +
                            "from pub_and_konf, teachers " +
                            "where teachers.t_id = pub_and_konf.pak_t_id and teachers.t_namesecname = \"" + TextBoxSearch.Text + "\";");
                    }
                    else if (SearchCategoties.SelectedIndex == 1)
                    {
                        comm = uploadingData(mysql_connection, "SELECT teachers.t_namesecname, pub_and_konf.pak_date, pub_and_konf.pak_city, " +
                            "pub_and_konf.pak_tematika, pub_and_konf.pac_name_doc, pub_and_konf.pac_type " +
                            "from pub_and_konf, teachers " +
                            "where teachers.t_id = pub_and_konf.pak_t_id and pub_and_konf.pak_date = \"" + TextBoxSearch.Text + "\";");
                    }
                    else if (SearchCategoties.SelectedIndex == 2)
                    {
                        comm = uploadingData(mysql_connection, "SELECT teachers.t_namesecname, pub_and_konf.pak_date, pub_and_konf.pak_city, " +
                            "pub_and_konf.pak_tematika, pub_and_konf.pac_name_doc, pub_and_konf.pac_type " +
                            "from pub_and_konf, teachers " +
                            "where teachers.t_id = pub_and_konf.pak_t_id and pub_and_konf.pak_city = \"" + TextBoxSearch.Text + "\";");
                    }
                    else if (SearchCategoties.SelectedIndex == 3)
                    {
                        comm = uploadingData(mysql_connection, "SELECT teachers.t_namesecname, pub_and_konf.pak_date, pub_and_konf.pak_city, " +
                            "pub_and_konf.pak_tematika, pub_and_konf.pac_name_doc, pub_and_konf.pac_type " +
                            "from pub_and_konf, teachers " +
                            "where teachers.t_id = pub_and_konf.pak_t_id and pub_and_konf.pak_tematika = \"" + TextBoxSearch.Text + "\";");
                    }
                    else if (SearchCategoties.SelectedIndex == 4)
                    {
                        comm = uploadingData(mysql_connection, "SELECT teachers.t_namesecname, pub_and_konf.pak_date, pub_and_konf.pak_city, " +
                            "pub_and_konf.pak_tematika, pub_and_konf.pac_name_doc, pub_and_konf.pac_type " +
                            "from pub_and_konf, teachers " +
                            "where teachers.t_id = pub_and_konf.pak_t_id and pub_and_konf.pac_name_doc = \"" + TextBoxSearch.Text + "\";");
                    }
                    else if (SearchCategoties.SelectedIndex == 5)
                    {
                        comm = uploadingData(mysql_connection, "SELECT teachers.t_namesecname, pub_and_konf.pak_date, pub_and_konf.pak_city, " +
                            "pub_and_konf.pak_tematika, pub_and_konf.pac_name_doc, pub_and_konf.pac_type " +
                            "from pub_and_konf, teachers " +
                            "where teachers.t_id = pub_and_konf.pak_t_id and pub_and_konf.pac_type = \"" + TextBoxSearch.Text + "\";");
                    }
                    updatingGridPubAndKonf(mysql_connection, comm);
                }
            }
            // Pov Kval search
            if (LabelPovKval.ForeColor == Color.Aqua) 
            {
                MySqlCommand comm = uploadingData(mysql_connection,
                "Select teachers.t_namesecname, pov_kval.pk_zakl, pov_kval.pk_napravl,pov_kval.pk_year " +
                "from teachers, pov_kval " +
                "where teachers.t_id = pov_kval.pk_t_id;");
                if (TextBoxSearch.Text != "" || TextBoxSearch.Text != "Пошук")
                {
                    if (SearchCategoties.SelectedIndex == 0) 
                    {
                        comm = uploadingData(mysql_connection,
                        "Select teachers.t_namesecname, pov_kval.pk_zakl, pov_kval.pk_napravl,pov_kval.pk_year " +
                        "from teachers, pov_kval " +
                        "where teachers.t_id = pov_kval.pk_t_id and teachers.t_namesecname = \"" + TextBoxSearch.Text + "\";");
                    }
                    else if(SearchCategoties.SelectedIndex == 1)
                    {
                        comm = uploadingData(mysql_connection,
                       "Select teachers.t_namesecname, pov_kval.pk_zakl, pov_kval.pk_napravl,pov_kval.pk_year " +
                       "from teachers, pov_kval " +
                       "where teachers.t_id = pov_kval.pk_t_id and pov_kval.pk_zakl = \"" + TextBoxSearch.Text + "\";");
                    }
                    else if (SearchCategoties.SelectedIndex == 2)
                    {
                        comm = uploadingData(mysql_connection,
                       "Select teachers.t_namesecname, pov_kval.pk_zakl, pov_kval.pk_napravl,pov_kval.pk_year " +
                       "from teachers, pov_kval " +
                       "where teachers.t_id = pov_kval.pk_t_id and pov_kval.pk_year = \"" + TextBoxSearch.Text + "\";");
                    }
                }
                updatingGridPovKvalf(mysql_connection, comm);
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuToolBox.Visible = true;
            // Label Table Text
            LabelTableText.Visible = true;
            LabelTableText.BringToFront();
            // Arrow
            ArrowClose.Visible = true;
            ArrowClose.BringToFront();
            // Icon 1
            IconTable0Current.Visible = true;
            LabelTeachers.Visible = true;
            IconTable0Current.BringToFront();
            LabelTeachers.BringToFront();
            // Icon 2
            IconTable1.Visible = true;
            LabelCKonissiya.Visible = true;
            IconTable1.BringToFront();
            LabelCKonissiya.BringToFront();
            // Icon 3
            IconTable2.Visible = true;
            LabelMetObesp.Visible = true;
            IconTable2.BringToFront();
            LabelMetObesp.BringToFront();
            // Icon 4
            IconTable3.Visible = true;
            LabelMetObespType.Visible = true;
            IconTable3.BringToFront();
            LabelMetObespType.BringToFront();
            // Icon 5
            IconTable4.Visible = true;
            LabelSertifictati.Visible = true;
            IconTable4.BringToFront();
            LabelSertifictati.BringToFront();
            // Icon 6
            IconTable5.Visible = true;
            LabelPubAndKonf.Visible = true;
            IconTable5.BringToFront();
            LabelPubAndKonf.BringToFront();
            // Icon 7
            IconTable6.Visible = true;
            LabelPovKval.Visible = true;
            IconTable6.BringToFront();
            LabelPovKval.BringToFront();
            // Label app Name
            LabelAppName.Visible = true;
            LabelAppName.BringToFront();
            // Label version
            LabelAppVersion.Visible = true;
            LabelAppVersion.BringToFront();
        }

        private void ArrowClose_Click(object sender, EventArgs e)
        {
            ClosingMenu();
        }
        //------------------------------------Меню-------------------------------------------------
        // Teacher click procedure 
        private void LabelTeachers_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            SearchCategoties.Items.Clear();
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "ПІБ Викладача";
            dataGridView1.Columns[1].Name = "Дата Народження";
            dataGridView1.Columns[2].Name = "Заклад освіти";
            dataGridView1.Columns[3].Name = "Спеціалізація за фахом";
            dataGridView1.Columns[4].Name = "Основний предмет";
            dataGridView1.Columns[5].Name = "Дата останньої атестації";
            MySqlCommand comm = uploadingData(mysql_connection, "SELECT * FROM teachers;");
            updatingGridDefault(mysql_connection, comm);
            SearchCategoties.Items.Add("За ПІБ");
            SearchCategoties.Items.Add("За основним предметом");
            SearchCategoties.Items.Add("За закладом, що закінчив(ла)");
            LabelCKonissiya.ForeColor = Color.White;
            LabelTeachers.ForeColor = Color.Aqua;
            LabelMetObesp.ForeColor = Color.White;
            LabelMetObespType.ForeColor = Color.White;
            LabelSertifictati.ForeColor = Color.White;
            LabelPubAndKonf.ForeColor = Color.White;
            LabelPovKval.ForeColor = Color.White;
            SearchCategoties.SelectedIndex = 0;
        }

        // grid updating for ciklovaya komissiya
        void updatingGridCKom(MySqlConnection mysql_connection, MySqlCommand mysql_query)
        {
            dataGridView1.Rows.Clear();
            mysql_connection.Open(); // Дальше для подключение и соединения с базой данных нужно вызвать метод .Open():
            MySqlDataReader mysql_result; // Теперь, чтобы увидеть обработанный запрос нужно создать объект MySqlDataReader:
            mysql_result = mysql_query.ExecuteReader(); //

            if (mysql_result.HasRows)
            {
                while (mysql_result.Read())
                {
                    dataGridView1.Rows.Add(mysql_result.GetString(1), mysql_result.GetString(2));
                }
            }
            mysql_result.Close();
            mysql_connection.Close();
        }
        // C kom click proczedure
        private void LabelCKonissiya_Click(object sender, EventArgs e)
        {
            SearchCategoties.Items.Clear();
            MySqlCommand comm = uploadingData(mysql_connection, "SELECT * FROM c_komisiya;");
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Назва циклової комісії";
            dataGridView1.Columns[1].Name = "Завідувач комісії";
            updatingGridCKom(mysql_connection, comm);
            SearchCategoties.Items.Add("За назвою ЦК");
            SearchCategoties.Items.Add("За ПІБ завідувача");
            LabelCKonissiya.ForeColor = Color.Aqua;
            LabelTeachers.ForeColor = Color.White;
            LabelMetObesp.ForeColor = Color.White;
            LabelMetObespType.ForeColor = Color.White;
            LabelSertifictati.ForeColor = Color.White;
            LabelPubAndKonf.ForeColor = Color.White;
            LabelPovKval.ForeColor = Color.White;
            SearchCategoties.SelectedIndex = 0;
        }

        void updatingGridMetObesp(MySqlConnection mysql_connection, MySqlCommand mysql_query)
        {
            dataGridView1.Rows.Clear();
            mysql_connection.Open(); // Дальше для подключение и соединения с базой данных нужно вызвать метод .Open():
            MySqlDataReader mysql_result; // Теперь, чтобы увидеть обработанный запрос нужно создать объект MySqlDataReader:
            mysql_result = mysql_query.ExecuteReader(); //

            if (mysql_result.HasRows)
            {
                while (mysql_result.Read())
                {
                    dataGridView1.Rows.Add(mysql_result.GetString(0), mysql_result.GetString(1), mysql_result.GetString(2), mysql_result.GetString(3));
                }
            }
            mysql_result.Close();
            mysql_connection.Close();
        }

        private void LabelMetObesp_Click(object sender, EventArgs e)
        {
            SearchCategoties.Items.Clear();
            MySqlCommand comm = uploadingData(mysql_connection,
                "SELECT metod_zab.mz_pred_name, metod_zab_type.mzt_type, metod_zab.mz_year, teachers.t_namesecname " +
                "FROM metod_zab, metod_zab_type,teachers " +
                "Where mz_t_id = teachers.t_id and  metod_zab_type.mzt_id = metod_zab.mz_type_id;");
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Назва предмету";
            dataGridView1.Columns[1].Name = "Тип забазпечення";
            dataGridView1.Columns[2].Name = "Рік";
            dataGridView1.Columns[3].Name = "Викладач";
            updatingGridMetObesp(mysql_connection, comm);
            SearchCategoties.Items.Add("За Назвою предмету");
            SearchCategoties.Items.Add("За Роком");
            SearchCategoties.Items.Add("За ПІБ Викладача");
            LabelCKonissiya.ForeColor = Color.White;
            LabelTeachers.ForeColor = Color.White;
            LabelMetObesp.ForeColor = Color.Aqua;
            LabelMetObespType.ForeColor = Color.White;
            LabelSertifictati.ForeColor = Color.White;
            LabelPubAndKonf.ForeColor = Color.White;
            LabelPovKval.ForeColor = Color.White;
            SearchCategoties.SelectedIndex = 0;
        }

        void updatingGridMetObespType(MySqlConnection mysql_connection, MySqlCommand mysql_query)
        {
            dataGridView1.Rows.Clear();
            mysql_connection.Open(); // Дальше для подключение и соединения с базой данных нужно вызвать метод .Open():
            MySqlDataReader mysql_result; // Теперь, чтобы увидеть обработанный запрос нужно создать объект MySqlDataReader:
            mysql_result = mysql_query.ExecuteReader(); //

            if (mysql_result.HasRows)
            {
                while (mysql_result.Read())
                {
                    dataGridView1.Rows.Add(mysql_result.GetString(0));
                }
            }
            mysql_result.Close();
            mysql_connection.Close();
        }
        private void LabelMetObespType_Click(object sender, EventArgs e)
        {
            SearchCategoties.Items.Clear();
            MySqlCommand comm = uploadingData(mysql_connection, "SELECT mzt_type FROM metod_zab_type;");
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Name = "Тип забазпечення";
            updatingGridMetObespType(mysql_connection, comm);
            SearchCategoties.Items.Add("За типом забазпечення");
            LabelCKonissiya.ForeColor = Color.White;
            LabelTeachers.ForeColor = Color.White;
            LabelMetObesp.ForeColor = Color.White;
            LabelMetObespType.ForeColor = Color.Aqua;
            LabelSertifictati.ForeColor = Color.White;
            LabelPubAndKonf.ForeColor = Color.White;
            LabelPovKval.ForeColor = Color.White;
            SearchCategoties.SelectedIndex = 0;
        }

        void updatingGridSertifictati(MySqlConnection mysql_connection, MySqlCommand mysql_query)
        {
            dataGridView1.Rows.Clear();
            mysql_connection.Open(); // Дальше для подключение и соединения с базой данных нужно вызвать метод .Open():
            MySqlDataReader mysql_result; // Теперь, чтобы увидеть обработанный запрос нужно создать объект MySqlDataReader:
            mysql_result = mysql_query.ExecuteReader(); //

            if (mysql_result.HasRows)
            {
                while (mysql_result.Read())
                {
                    dataGridView1.Rows.Add(mysql_result.GetString(0), mysql_result.GetString(1), mysql_result.GetString(2), 
                        mysql_result.GetString(3).Substring(0, mysql_result.GetString(3).Length - (mysql_result.GetString(3).Length - 10)), // Отрезать 00.00
                        mysql_result.GetString(4));
                }
            }
            mysql_result.Close();
            mysql_connection.Close();
        }
        private void LabelSertifictati_Click(object sender, EventArgs e)
        {
            SearchCategoties.Items.Clear();
            MySqlCommand comm = uploadingData(mysql_connection,
                "SELECT sertificati.s_zakl, sertificati.s_temat,sertificati.s_kol_god,sertificati.s_data,teachers.t_namesecname FROM sertificati, teachers " +
                "Where teachers.t_id = sertificati.s_t_id;");
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Назва закладу";
            dataGridView1.Columns[1].Name = "Темaтикa"; //?????? Правильно ли ??????
            dataGridView1.Columns[2].Name = "Кількість годин";
            dataGridView1.Columns[3].Name = "Дaтa отримaння";
            dataGridView1.Columns[4].Name = "Викладач";
            updatingGridSertifictati(mysql_connection, comm);
            SearchCategoties.Items.Add("За назвою закладу");
            SearchCategoties.Items.Add("За темaтикою");
            SearchCategoties.Items.Add("За ПІБ викладача");
            LabelCKonissiya.ForeColor = Color.White;
            LabelTeachers.ForeColor = Color.White;
            LabelMetObesp.ForeColor = Color.White;
            LabelMetObespType.ForeColor = Color.White;
            LabelSertifictati.ForeColor = Color.Aqua;
            LabelPubAndKonf.ForeColor = Color.White;
            LabelPovKval.ForeColor = Color.White;
            SearchCategoties.SelectedIndex = 0;
        }

        void updatingGridPubAndKonf(MySqlConnection mysql_connection, MySqlCommand mysql_query)
        {
            dataGridView1.Rows.Clear();
            mysql_connection.Open(); // Дальше для подключение и соединения с базой данных нужно вызвать метод .Open():
            MySqlDataReader mysql_result; // Теперь, чтобы увидеть обработанный запрос нужно создать объект MySqlDataReader:
            mysql_result = mysql_query.ExecuteReader(); //

            if (mysql_result.HasRows)
            {
                while (mysql_result.Read())
                {
                    dataGridView1.Rows.Add(mysql_result.GetString(0), 
                        mysql_result.GetString(1).Substring(0, mysql_result.GetString(1).Length - (mysql_result.GetString(1).Length - 10)), // Отрезать 00.00
                        mysql_result.GetString(2), mysql_result.GetString(3), mysql_result.GetString(4), mysql_result.GetString(5));
                }
            }
            mysql_result.Close();
            mysql_connection.Close();
        }

        private void LabelPubAndKonf_Click(object sender, EventArgs e)
        {
            SearchCategoties.Items.Clear();
            MySqlCommand comm = uploadingData(mysql_connection, 
                "SELECT teachers.t_namesecname, pub_and_konf.pak_date, pub_and_konf.pak_city, pub_and_konf.pak_tematika, pub_and_konf.pac_name_doc, pub_and_konf.pac_type " +
                "from pub_and_konf, teachers " +
                "where teachers.t_id = pub_and_konf.pak_t_id");
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Викладач";
            dataGridView1.Columns[1].Name = "Дaтa";
            dataGridView1.Columns[2].Name = "Місто";
            dataGridView1.Columns[3].Name = "Тематика публікaції/ конференції";
            dataGridView1.Columns[4].Name = "Назва докладу";
            dataGridView1.Columns[5].Name = "Вид";
            updatingGridPubAndKonf(mysql_connection, comm);
            SearchCategoties.Items.Add("За викладачем");
            SearchCategoties.Items.Add("За датою (в форматі Рік-Міс-День)");
            SearchCategoties.Items.Add("За містом");
            SearchCategoties.Items.Add("За тематикою");
            SearchCategoties.Items.Add("За назвою докладу");
            SearchCategoties.Items.Add("Видом");
            LabelCKonissiya.ForeColor = Color.White;
            LabelTeachers.ForeColor = Color.White;
            LabelMetObesp.ForeColor = Color.White;
            LabelMetObespType.ForeColor = Color.White;
            LabelSertifictati.ForeColor = Color.White;
            LabelPubAndKonf.ForeColor = Color.Aqua;
            LabelPovKval.ForeColor = Color.White;
            SearchCategoties.SelectedIndex = 0;
        }

        void updatingGridPovKvalf(MySqlConnection mysql_connection, MySqlCommand mysql_query)
        {
            dataGridView1.Rows.Clear();
            mysql_connection.Open(); // Дальше для подключение и соединения с базой данных нужно вызвать метод .Open():
            MySqlDataReader mysql_result; // Теперь, чтобы увидеть обработанный запрос нужно создать объект MySqlDataReader:
            mysql_result = mysql_query.ExecuteReader(); //

            if (mysql_result.HasRows)
            {
                while (mysql_result.Read())
                {
                    dataGridView1.Rows.Add(mysql_result.GetString(0), mysql_result.GetString(1), mysql_result.GetString(2), mysql_result.GetString(3));
                }
            }
            mysql_result.Close();
            mysql_connection.Close();
        }

        private void LabelPovKval_Click(object sender, EventArgs e)
        {
            SearchCategoties.Items.Clear();
            MySqlCommand comm = uploadingData(mysql_connection, 
                "Select teachers.t_namesecname, pov_kval.pk_zakl, pov_kval.pk_napravl,pov_kval.pk_year " +
                "from teachers, pov_kval " +
                "where teachers.t_id = pov_kval.pk_t_id;");
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Викладач";
            dataGridView1.Columns[1].Name = "Заклад";
            dataGridView1.Columns[2].Name = "Направлення";
            dataGridView1.Columns[3].Name = "Рік";
            updatingGridPovKvalf(mysql_connection, comm);
            SearchCategoties.Items.Add("За викладачем");
            SearchCategoties.Items.Add("За закладом");
            SearchCategoties.Items.Add("За Роком");
            LabelCKonissiya.ForeColor = Color.White;
            LabelTeachers.ForeColor = Color.White;
            LabelMetObesp.ForeColor = Color.White;
            LabelMetObespType.ForeColor = Color.White;
            LabelSertifictati.ForeColor = Color.White;
            LabelPubAndKonf.ForeColor = Color.White;
            LabelPovKval.ForeColor = Color.Aqua;
            SearchCategoties.SelectedIndex = 0;
        }

        private void MainForm_Click(object sender, EventArgs e) // Закрытие меню при нажатии не на меню
        {
            CloseMenuWithMouse();
        }

        private void AddIcon_Click(object sender, EventArgs e)
        {
            AddForm frm = new AddForm();
            frm.Owner = this;
            frm.Show();
            
        }
    }
   
}// Done


