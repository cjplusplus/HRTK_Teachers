namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchCategoties = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.t_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_bdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_zakl_obraz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_spec_diplom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_o_predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_date_last_att = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelAppName = new System.Windows.Forms.Label();
            this.LabelAppVersion = new System.Windows.Forms.Label();
            this.LabelTableText = new System.Windows.Forms.Label();
            this.IconTable1 = new System.Windows.Forms.PictureBox();
            this.ArrowClose = new System.Windows.Forms.PictureBox();
            this.MenuToolBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SearchIconNonActive = new System.Windows.Forms.PictureBox();
            this.SearchIconActive = new System.Windows.Forms.PictureBox();
            this.DeleteIcon = new System.Windows.Forms.PictureBox();
            this.AddIcon = new System.Windows.Forms.PictureBox();
            this.EditIcon = new System.Windows.Forms.PictureBox();
            this.UserIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IconTable2 = new System.Windows.Forms.PictureBox();
            this.IconTable3 = new System.Windows.Forms.PictureBox();
            this.IconTable4 = new System.Windows.Forms.PictureBox();
            this.IconTable5 = new System.Windows.Forms.PictureBox();
            this.IconTable6 = new System.Windows.Forms.PictureBox();
            this.IconTable0Current = new System.Windows.Forms.PictureBox();
            this.LabelTeachers = new System.Windows.Forms.Label();
            this.LabelCKonissiya = new System.Windows.Forms.Label();
            this.LabelMetObesp = new System.Windows.Forms.Label();
            this.LabelMetObespType = new System.Windows.Forms.Label();
            this.LabelSertifictati = new System.Windows.Forms.Label();
            this.LabelPubAndKonf = new System.Windows.Forms.Label();
            this.LabelPovKval = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuToolBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIconNonActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIconActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconTable0Current)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1159, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSearch.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSearch.ForeColor = System.Drawing.Color.LightGray;
            this.TextBoxSearch.Location = new System.Drawing.Point(310, 20);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(158, 14);
            this.TextBoxSearch.TabIndex = 7;
            this.TextBoxSearch.Text = "Пошук";
            this.TextBoxSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxSearch_MouseClick);
            this.TextBoxSearch.Enter += new System.EventHandler(this.TextBoxSearch_Enter);
            this.TextBoxSearch.Leave += new System.EventHandler(this.TextBoxSearch_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(48, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Критерії пошука:";
            // 
            // SearchCategoties
            // 
            this.SearchCategoties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.SearchCategoties.DisplayMember = "0";
            this.SearchCategoties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchCategoties.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchCategoties.ForeColor = System.Drawing.Color.LightGray;
            this.SearchCategoties.Items.AddRange(new object[] {
            "За ПІБ",
            "За основним предметом",
            "За закладом, що закінчив(ла)"});
            this.SearchCategoties.Location = new System.Drawing.Point(51, 18);
            this.SearchCategoties.Name = "SearchCategoties";
            this.SearchCategoties.Size = new System.Drawing.Size(215, 24);
            this.SearchCategoties.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t_name,
            this.t_bdate,
            this.t_zakl_obraz,
            this.t_spec_diplom,
            this.t_o_predmet,
            this.t_date_last_att});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1266, 634);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // t_name
            // 
            this.t_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.t_name.HeaderText = "ПІБ Викладача";
            this.t_name.Name = "t_name";
            this.t_name.ReadOnly = true;
            this.t_name.Width = 98;
            // 
            // t_bdate
            // 
            this.t_bdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.t_bdate.HeaderText = "Дата Народження";
            this.t_bdate.Name = "t_bdate";
            this.t_bdate.ReadOnly = true;
            this.t_bdate.Width = 114;
            // 
            // t_zakl_obraz
            // 
            this.t_zakl_obraz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.t_zakl_obraz.HeaderText = "Заклад освіти";
            this.t_zakl_obraz.Name = "t_zakl_obraz";
            this.t_zakl_obraz.ReadOnly = true;
            this.t_zakl_obraz.Width = 95;
            // 
            // t_spec_diplom
            // 
            this.t_spec_diplom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.t_spec_diplom.HeaderText = "Спеціалізація за фахом";
            this.t_spec_diplom.Name = "t_spec_diplom";
            this.t_spec_diplom.ReadOnly = true;
            this.t_spec_diplom.Width = 107;
            // 
            // t_o_predmet
            // 
            this.t_o_predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.t_o_predmet.HeaderText = "Основний предмет";
            this.t_o_predmet.Name = "t_o_predmet";
            this.t_o_predmet.ReadOnly = true;
            this.t_o_predmet.Width = 117;
            // 
            // t_date_last_att
            // 
            this.t_date_last_att.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.t_date_last_att.HeaderText = "Дата останньої атестації";
            this.t_date_last_att.Name = "t_date_last_att";
            this.t_date_last_att.ReadOnly = true;
            this.t_date_last_att.Width = 145;
            // 
            // LabelAppName
            // 
            this.LabelAppName.AutoSize = true;
            this.LabelAppName.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAppName.Location = new System.Drawing.Point(16, 642);
            this.LabelAppName.Name = "LabelAppName";
            this.LabelAppName.Size = new System.Drawing.Size(123, 15);
            this.LabelAppName.TabIndex = 21;
            this.LabelAppName.Text = "Викладачі ХРТК Desktop";
            this.LabelAppName.Visible = false;
            // 
            // LabelAppVersion
            // 
            this.LabelAppVersion.AutoSize = true;
            this.LabelAppVersion.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAppVersion.Location = new System.Drawing.Point(16, 657);
            this.LabelAppVersion.Name = "LabelAppVersion";
            this.LabelAppVersion.Size = new System.Drawing.Size(89, 15);
            this.LabelAppVersion.TabIndex = 22;
            this.LabelAppVersion.Text = "Версія 2.2.8.3.2.2.";
            this.LabelAppVersion.Visible = false;
            // 
            // LabelTableText
            // 
            this.LabelTableText.AutoSize = true;
            this.LabelTableText.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTableText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelTableText.Location = new System.Drawing.Point(16, 20);
            this.LabelTableText.Name = "LabelTableText";
            this.LabelTableText.Size = new System.Drawing.Size(183, 16);
            this.LabelTableText.TabIndex = 23;
            this.LabelTableText.Text = "Выберете таблицу для работы:";
            this.LabelTableText.Visible = false;
            // 
            // IconTable1
            // 
            this.IconTable1.Image = global::WindowsFormsApp1.Properties.Resources.MenuIcons2;
            this.IconTable1.Location = new System.Drawing.Point(9, 127);
            this.IconTable1.Name = "IconTable1";
            this.IconTable1.Size = new System.Drawing.Size(251, 33);
            this.IconTable1.TabIndex = 15;
            this.IconTable1.TabStop = false;
            this.IconTable1.Visible = false;
            // 
            // ArrowClose
            // 
            this.ArrowClose.Image = global::WindowsFormsApp1.Properties.Resources.ArrowTurnBackIcon;
            this.ArrowClose.Location = new System.Drawing.Point(236, 14);
            this.ArrowClose.Name = "ArrowClose";
            this.ArrowClose.Size = new System.Drawing.Size(29, 26);
            this.ArrowClose.TabIndex = 14;
            this.ArrowClose.TabStop = false;
            this.ArrowClose.Visible = false;
            this.ArrowClose.Click += new System.EventHandler(this.ArrowClose_Click);
            // 
            // MenuToolBox
            // 
            this.MenuToolBox.Location = new System.Drawing.Point(-1, -1);
            this.MenuToolBox.Name = "MenuToolBox";
            this.MenuToolBox.Size = new System.Drawing.Size(273, 683);
            this.MenuToolBox.TabIndex = 13;
            this.MenuToolBox.TabStop = false;
            this.MenuToolBox.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.TableIconActive;
            this.pictureBox2.Location = new System.Drawing.Point(9, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 32);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // SearchIconNonActive
            // 
            this.SearchIconNonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.SearchIconNonActive.Image = global::WindowsFormsApp1.Properties.Resources.searchicon;
            this.SearchIconNonActive.Location = new System.Drawing.Point(474, 16);
            this.SearchIconNonActive.Name = "SearchIconNonActive";
            this.SearchIconNonActive.Size = new System.Drawing.Size(21, 23);
            this.SearchIconNonActive.TabIndex = 1;
            this.SearchIconNonActive.TabStop = false;
            this.SearchIconNonActive.MouseHover += new System.EventHandler(this.SearchIconNonActive_MouseHover);
            // 
            // SearchIconActive
            // 
            this.SearchIconActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.SearchIconActive.Image = global::WindowsFormsApp1.Properties.Resources.searchiconActive;
            this.SearchIconActive.Location = new System.Drawing.Point(474, 16);
            this.SearchIconActive.Name = "SearchIconActive";
            this.SearchIconActive.Size = new System.Drawing.Size(21, 23);
            this.SearchIconActive.TabIndex = 11;
            this.SearchIconActive.TabStop = false;
            this.SearchIconActive.Click += new System.EventHandler(this.SearchIconActive_Click);
            this.SearchIconActive.MouseLeave += new System.EventHandler(this.SearchIconActive_MouseLeave);
            // 
            // DeleteIcon
            // 
            this.DeleteIcon.Image = global::WindowsFormsApp1.Properties.Resources.deleteicon;
            this.DeleteIcon.Location = new System.Drawing.Point(907, 4);
            this.DeleteIcon.Name = "DeleteIcon";
            this.DeleteIcon.Size = new System.Drawing.Size(35, 36);
            this.DeleteIcon.TabIndex = 6;
            this.DeleteIcon.TabStop = false;
            // 
            // AddIcon
            // 
            this.AddIcon.Image = global::WindowsFormsApp1.Properties.Resources.addicon;
            this.AddIcon.Location = new System.Drawing.Point(865, 5);
            this.AddIcon.Name = "AddIcon";
            this.AddIcon.Size = new System.Drawing.Size(36, 37);
            this.AddIcon.TabIndex = 5;
            this.AddIcon.TabStop = false;
            this.AddIcon.Click += new System.EventHandler(this.AddIcon_Click);
            // 
            // EditIcon
            // 
            this.EditIcon.Image = global::WindowsFormsApp1.Properties.Resources.editicon;
            this.EditIcon.Location = new System.Drawing.Point(820, 5);
            this.EditIcon.Name = "EditIcon";
            this.EditIcon.Size = new System.Drawing.Size(39, 37);
            this.EditIcon.TabIndex = 4;
            this.EditIcon.TabStop = false;
            // 
            // UserIcon
            // 
            this.UserIcon.Image = global::WindowsFormsApp1.Properties.Resources.usericon;
            this.UserIcon.Location = new System.Drawing.Point(1218, 7);
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.Size = new System.Drawing.Size(34, 35);
            this.UserIcon.TabIndex = 2;
            this.UserIcon.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.rectsearch;
            this.pictureBox1.Location = new System.Drawing.Point(297, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 30);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // IconTable2
            // 
            this.IconTable2.Image = global::WindowsFormsApp1.Properties.Resources.MenuIcons2;
            this.IconTable2.Location = new System.Drawing.Point(9, 176);
            this.IconTable2.Name = "IconTable2";
            this.IconTable2.Size = new System.Drawing.Size(251, 33);
            this.IconTable2.TabIndex = 24;
            this.IconTable2.TabStop = false;
            this.IconTable2.Visible = false;
            // 
            // IconTable3
            // 
            this.IconTable3.Image = global::WindowsFormsApp1.Properties.Resources.MenuIcons2;
            this.IconTable3.Location = new System.Drawing.Point(9, 227);
            this.IconTable3.Name = "IconTable3";
            this.IconTable3.Size = new System.Drawing.Size(251, 33);
            this.IconTable3.TabIndex = 25;
            this.IconTable3.TabStop = false;
            this.IconTable3.Visible = false;
            // 
            // IconTable4
            // 
            this.IconTable4.Image = global::WindowsFormsApp1.Properties.Resources.MenuIcons2;
            this.IconTable4.Location = new System.Drawing.Point(9, 276);
            this.IconTable4.Name = "IconTable4";
            this.IconTable4.Size = new System.Drawing.Size(251, 33);
            this.IconTable4.TabIndex = 26;
            this.IconTable4.TabStop = false;
            this.IconTable4.Visible = false;
            // 
            // IconTable5
            // 
            this.IconTable5.Image = global::WindowsFormsApp1.Properties.Resources.MenuIcons2;
            this.IconTable5.Location = new System.Drawing.Point(9, 329);
            this.IconTable5.Name = "IconTable5";
            this.IconTable5.Size = new System.Drawing.Size(251, 33);
            this.IconTable5.TabIndex = 27;
            this.IconTable5.TabStop = false;
            this.IconTable5.Visible = false;
            // 
            // IconTable6
            // 
            this.IconTable6.Image = global::WindowsFormsApp1.Properties.Resources.MenuIcons2;
            this.IconTable6.Location = new System.Drawing.Point(9, 380);
            this.IconTable6.Name = "IconTable6";
            this.IconTable6.Size = new System.Drawing.Size(251, 33);
            this.IconTable6.TabIndex = 28;
            this.IconTable6.TabStop = false;
            this.IconTable6.Visible = false;
            // 
            // IconTable0Current
            // 
            this.IconTable0Current.Image = global::WindowsFormsApp1.Properties.Resources.MenuIcons2;
            this.IconTable0Current.Location = new System.Drawing.Point(9, 79);
            this.IconTable0Current.Name = "IconTable0Current";
            this.IconTable0Current.Size = new System.Drawing.Size(251, 33);
            this.IconTable0Current.TabIndex = 29;
            this.IconTable0Current.TabStop = false;
            this.IconTable0Current.Visible = false;
            // 
            // LabelTeachers
            // 
            this.LabelTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.LabelTeachers.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTeachers.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelTeachers.Location = new System.Drawing.Point(15, 84);
            this.LabelTeachers.Name = "LabelTeachers";
            this.LabelTeachers.Size = new System.Drawing.Size(234, 20);
            this.LabelTeachers.TabIndex = 30;
            this.LabelTeachers.Text = "Викладачі";
            this.LabelTeachers.Visible = false;
            this.LabelTeachers.Click += new System.EventHandler(this.LabelTeachers_Click);
            // 
            // LabelCKonissiya
            // 
            this.LabelCKonissiya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.LabelCKonissiya.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCKonissiya.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelCKonissiya.Location = new System.Drawing.Point(15, 132);
            this.LabelCKonissiya.Name = "LabelCKonissiya";
            this.LabelCKonissiya.Size = new System.Drawing.Size(234, 20);
            this.LabelCKonissiya.TabIndex = 31;
            this.LabelCKonissiya.Text = "Циклова комісія";
            this.LabelCKonissiya.Visible = false;
            this.LabelCKonissiya.Click += new System.EventHandler(this.LabelCKonissiya_Click);
            // 
            // LabelMetObesp
            // 
            this.LabelMetObesp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.LabelMetObesp.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMetObesp.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelMetObesp.Location = new System.Drawing.Point(15, 181);
            this.LabelMetObesp.Name = "LabelMetObesp";
            this.LabelMetObesp.Size = new System.Drawing.Size(234, 20);
            this.LabelMetObesp.TabIndex = 32;
            this.LabelMetObesp.Text = "Методичне забезпечення";
            this.LabelMetObesp.Visible = false;
            this.LabelMetObesp.Click += new System.EventHandler(this.LabelMetObesp_Click);
            // 
            // LabelMetObespType
            // 
            this.LabelMetObespType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.LabelMetObespType.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMetObespType.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelMetObespType.Location = new System.Drawing.Point(15, 232);
            this.LabelMetObespType.Name = "LabelMetObespType";
            this.LabelMetObespType.Size = new System.Drawing.Size(234, 20);
            this.LabelMetObespType.TabIndex = 33;
            this.LabelMetObespType.Text = "Методичне забезпечення тип";
            this.LabelMetObespType.Visible = false;
            this.LabelMetObespType.Click += new System.EventHandler(this.LabelMetObespType_Click);
            // 
            // LabelSertifictati
            // 
            this.LabelSertifictati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.LabelSertifictati.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSertifictati.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelSertifictati.Location = new System.Drawing.Point(15, 281);
            this.LabelSertifictati.Name = "LabelSertifictati";
            this.LabelSertifictati.Size = new System.Drawing.Size(234, 20);
            this.LabelSertifictati.TabIndex = 34;
            this.LabelSertifictati.Text = "Сертифікати";
            this.LabelSertifictati.Visible = false;
            this.LabelSertifictati.Click += new System.EventHandler(this.LabelSertifictati_Click);
            // 
            // LabelPubAndKonf
            // 
            this.LabelPubAndKonf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.LabelPubAndKonf.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPubAndKonf.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelPubAndKonf.Location = new System.Drawing.Point(15, 334);
            this.LabelPubAndKonf.Name = "LabelPubAndKonf";
            this.LabelPubAndKonf.Size = new System.Drawing.Size(234, 20);
            this.LabelPubAndKonf.TabIndex = 35;
            this.LabelPubAndKonf.Text = "Публікації та конференції";
            this.LabelPubAndKonf.Visible = false;
            this.LabelPubAndKonf.Click += new System.EventHandler(this.LabelPubAndKonf_Click);
            // 
            // LabelPovKval
            // 
            this.LabelPovKval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.LabelPovKval.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPovKval.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelPovKval.Location = new System.Drawing.Point(15, 385);
            this.LabelPovKval.Name = "LabelPovKval";
            this.LabelPovKval.Size = new System.Drawing.Size(234, 20);
            this.LabelPovKval.TabIndex = 36;
            this.LabelPovKval.Text = "Підвищення кваліфікації";
            this.LabelPovKval.Visible = false;
            this.LabelPovKval.Click += new System.EventHandler(this.LabelPovKval_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(199)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.LabelPubAndKonf);
            this.Controls.Add(this.LabelSertifictati);
            this.Controls.Add(this.LabelMetObespType);
            this.Controls.Add(this.LabelMetObesp);
            this.Controls.Add(this.LabelCKonissiya);
            this.Controls.Add(this.LabelTeachers);
            this.Controls.Add(this.LabelTableText);
            this.Controls.Add(this.LabelPovKval);
            this.Controls.Add(this.LabelAppVersion);
            this.Controls.Add(this.LabelAppName);
            this.Controls.Add(this.IconTable6);
            this.Controls.Add(this.IconTable5);
            this.Controls.Add(this.IconTable4);
            this.Controls.Add(this.IconTable3);
            this.Controls.Add(this.IconTable2);
            this.Controls.Add(this.IconTable1);
            this.Controls.Add(this.IconTable0Current);
            this.Controls.Add(this.ArrowClose);
            this.Controls.Add(this.MenuToolBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SearchIconNonActive);
            this.Controls.Add(this.SearchIconActive);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchCategoties);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.DeleteIcon);
            this.Controls.Add(this.AddIcon);
            this.Controls.Add(this.EditIcon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserIcon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Викладачі ХРТК";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Click += new System.EventHandler(this.MainForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuToolBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIconNonActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIconActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconTable0Current)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox SearchIconNonActive;
        private System.Windows.Forms.PictureBox UserIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox EditIcon;
        private System.Windows.Forms.PictureBox AddIcon;
        private System.Windows.Forms.PictureBox DeleteIcon;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SearchCategoties;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox SearchIconActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_bdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_zakl_obraz;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_spec_diplom;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_o_predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_date_last_att;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox MenuToolBox;
        private System.Windows.Forms.PictureBox ArrowClose;
        private System.Windows.Forms.PictureBox IconTable1;
        private System.Windows.Forms.Label LabelAppName;
        private System.Windows.Forms.Label LabelAppVersion;
        private System.Windows.Forms.Label LabelTableText;
        private System.Windows.Forms.PictureBox IconTable2;
        private System.Windows.Forms.PictureBox IconTable3;
        private System.Windows.Forms.PictureBox IconTable4;
        private System.Windows.Forms.PictureBox IconTable5;
        private System.Windows.Forms.PictureBox IconTable6;
        private System.Windows.Forms.PictureBox IconTable0Current;
        public System.Windows.Forms.Label LabelTeachers;
        public System.Windows.Forms.Label LabelCKonissiya;
        public System.Windows.Forms.Label LabelMetObesp;
        public System.Windows.Forms.Label LabelMetObespType;
        public System.Windows.Forms.Label LabelSertifictati;
        public System.Windows.Forms.Label LabelPubAndKonf;
        public System.Windows.Forms.Label LabelPovKval;
    }
}