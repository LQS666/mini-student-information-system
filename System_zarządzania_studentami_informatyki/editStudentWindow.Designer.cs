namespace System_zarządzania_studentami_informatyki
{
    partial class EditStudentWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudentWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.StudentImageUploadButton = new System.Windows.Forms.Button();
            this.StudentImageBox = new System.Windows.Forms.PictureBox();
            this.TextBoxAdres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioButtonK = new System.Windows.Forms.RadioButton();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TextBoxNazwisko = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxImie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.StudentsCounter_Click = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ResetButton = new System.Windows.Forms.Button();
            this.EditStudentButton = new System.Windows.Forms.Button();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.StudentImageDownloadButton = new System.Windows.Forms.Button();
            this.TextBoxAdres2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.StudentImageBox)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(57, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 48;
            this.label7.Text = "Zdjęcie:";
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.BackColor = System.Drawing.Color.LimeGreen;
            this.AddStudentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudentButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddStudentButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddStudentButton.Location = new System.Drawing.Point(20, 656);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(177, 43);
            this.AddStudentButton.TabIndex = 47;
            this.AddStudentButton.Text = "Dodaj";
            this.AddStudentButton.UseVisualStyleBackColor = false;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click_1);
            // 
            // StudentImageUploadButton
            // 
            this.StudentImageUploadButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.StudentImageUploadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentImageUploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentImageUploadButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StudentImageUploadButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StudentImageUploadButton.Location = new System.Drawing.Point(255, 582);
            this.StudentImageUploadButton.Name = "StudentImageUploadButton";
            this.StudentImageUploadButton.Size = new System.Drawing.Size(116, 26);
            this.StudentImageUploadButton.TabIndex = 46;
            this.StudentImageUploadButton.Text = "Wrzuć zdjęcie";
            this.StudentImageUploadButton.UseVisualStyleBackColor = false;
            this.StudentImageUploadButton.Click += new System.EventHandler(this.StudentImageUploadButton_Click);
            // 
            // StudentImageBox
            // 
            this.StudentImageBox.BackColor = System.Drawing.Color.White;
            this.StudentImageBox.BackgroundImage = global::System_zarządzania_studentami_informatyki.Properties.Resources.maleImage;
            this.StudentImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StudentImageBox.Location = new System.Drawing.Point(170, 456);
            this.StudentImageBox.Name = "StudentImageBox";
            this.StudentImageBox.Size = new System.Drawing.Size(165, 120);
            this.StudentImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StudentImageBox.TabIndex = 45;
            this.StudentImageBox.TabStop = false;
            // 
            // TextBoxAdres
            // 
            this.TextBoxAdres.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxAdres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxAdres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxAdres.Location = new System.Drawing.Point(75, 358);
            this.TextBoxAdres.Name = "TextBoxAdres";
            this.TextBoxAdres.Size = new System.Drawing.Size(335, 20);
            this.TextBoxAdres.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(57, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 43;
            this.label6.Text = "Miasto:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Location = new System.Drawing.Point(61, 379);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(365, 1);
            this.panel5.TabIndex = 42;
            // 
            // radioButtonK
            // 
            this.radioButtonK.AutoSize = true;
            this.radioButtonK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonK.Location = new System.Drawing.Point(265, 228);
            this.radioButtonK.Name = "radioButtonK";
            this.radioButtonK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonK.Size = new System.Drawing.Size(88, 25);
            this.radioButtonK.TabIndex = 41;
            this.radioButtonK.Text = "Kobieta";
            this.radioButtonK.UseVisualStyleBackColor = true;
            this.radioButtonK.CheckedChanged += new System.EventHandler(this.radioButtonK_CheckedChanged);
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Checked = true;
            this.radioButtonM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonM.Location = new System.Drawing.Point(131, 228);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonM.Size = new System.Drawing.Size(112, 25);
            this.radioButtonM.TabIndex = 38;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "Mężczyzna";
            this.radioButtonM.UseVisualStyleBackColor = true;
            this.radioButtonM.CheckedChanged += new System.EventHandler(this.radioButtonM_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(57, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 40;
            this.label5.Text = "Płeć:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.AliceBlue;
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(199, 188);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 23);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(57, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Data urodzenia:";
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxPhone.Location = new System.Drawing.Point(75, 292);
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(335, 20);
            this.TextBoxPhone.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(57, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Numer kontaktowy:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(61, 313);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 1);
            this.panel3.TabIndex = 33;
            // 
            // TextBoxNazwisko
            // 
            this.TextBoxNazwisko.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxNazwisko.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxNazwisko.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxNazwisko.Location = new System.Drawing.Point(75, 148);
            this.TextBoxNazwisko.Name = "TextBoxNazwisko";
            this.TextBoxNazwisko.Size = new System.Drawing.Size(335, 20);
            this.TextBoxNazwisko.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(57, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nazwisko:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(61, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 1);
            this.panel2.TabIndex = 30;
            // 
            // TextBoxImie
            // 
            this.TextBoxImie.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxImie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxImie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxImie.Location = new System.Drawing.Point(75, 82);
            this.TextBoxImie.Name = "TextBoxImie";
            this.TextBoxImie.Size = new System.Drawing.Size(335, 20);
            this.TextBoxImie.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(57, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Imię:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(61, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 1);
            this.panel1.TabIndex = 27;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel6.Controls.Add(this.RefreshButton);
            this.panel6.Controls.Add(this.StudentsCounter_Click);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.DeleteStudentButton);
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Controls.Add(this.AddStudentButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(504, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1000, 723);
            this.panel6.TabIndex = 49;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.White;
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RefreshButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RefreshButton.Location = new System.Drawing.Point(766, 658);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(210, 41);
            this.RefreshButton.TabIndex = 54;
            this.RefreshButton.Text = "Odśwież";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // StudentsCounter_Click
            // 
            this.StudentsCounter_Click.AutoSize = true;
            this.StudentsCounter_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentsCounter_Click.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StudentsCounter_Click.ForeColor = System.Drawing.Color.Snow;
            this.StudentsCounter_Click.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentsCounter_Click.Location = new System.Drawing.Point(16, 46);
            this.StudentsCounter_Click.Name = "StudentsCounter_Click";
            this.StudentsCounter_Click.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StudentsCounter_Click.Size = new System.Drawing.Size(274, 22);
            this.StudentsCounter_Click.TabIndex = 53;
            this.StudentsCounter_Click.Text = "Liczba wszystkich studentów:";
            this.StudentsCounter_Click.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.TextBoxSearch);
            this.panel7.Controls.Add(this.SearchButton);
            this.panel7.Location = new System.Drawing.Point(641, 36);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(335, 43);
            this.panel7.TabIndex = 52;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxSearch.Location = new System.Drawing.Point(16, 10);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(267, 24);
            this.TextBoxSearch.TabIndex = 50;
            this.TextBoxSearch.Text = "Szukaj...";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.Control;
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchButton.Location = new System.Drawing.Point(289, 0);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(46, 43);
            this.SearchButton.TabIndex = 51;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.BackColor = System.Drawing.Color.Crimson;
            this.DeleteStudentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteStudentButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteStudentButton.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteStudentButton.Location = new System.Drawing.Point(213, 656);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(111, 43);
            this.DeleteStudentButton.TabIndex = 49;
            this.DeleteStudentButton.Text = "Usuń";
            this.DeleteStudentButton.UseVisualStyleBackColor = false;
            this.DeleteStudentButton.Click += new System.EventHandler(this.DeleteStudentButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleName = "";
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(20, 82);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 70;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(956, 565);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.White;
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResetButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ResetButton.Location = new System.Drawing.Point(265, 656);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(177, 43);
            this.ResetButton.TabIndex = 50;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // EditStudentButton
            // 
            this.EditStudentButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.EditStudentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditStudentButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditStudentButton.ForeColor = System.Drawing.Color.White;
            this.EditStudentButton.Location = new System.Drawing.Point(61, 656);
            this.EditStudentButton.Name = "EditStudentButton";
            this.EditStudentButton.Size = new System.Drawing.Size(177, 43);
            this.EditStudentButton.TabIndex = 48;
            this.EditStudentButton.Text = "Edytuj dane";
            this.EditStudentButton.UseVisualStyleBackColor = false;
            this.EditStudentButton.Click += new System.EventHandler(this.EditStudentButton_Click);
            // 
            // TextBoxID
            // 
            this.TextBoxID.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxID.Enabled = false;
            this.TextBoxID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxID.Location = new System.Drawing.Point(108, 20);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.ReadOnly = true;
            this.TextBoxID.Size = new System.Drawing.Size(34, 20);
            this.TextBoxID.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(57, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 21);
            this.label9.TabIndex = 51;
            this.label9.Text = "ID:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel8.Location = new System.Drawing.Point(94, 41);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(62, 1);
            this.panel8.TabIndex = 50;
            // 
            // StudentImageDownloadButton
            // 
            this.StudentImageDownloadButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.StudentImageDownloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentImageDownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentImageDownloadButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StudentImageDownloadButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StudentImageDownloadButton.Location = new System.Drawing.Point(133, 582);
            this.StudentImageDownloadButton.Name = "StudentImageDownloadButton";
            this.StudentImageDownloadButton.Size = new System.Drawing.Size(116, 26);
            this.StudentImageDownloadButton.TabIndex = 53;
            this.StudentImageDownloadButton.Text = "Pobierz zdjęcie";
            this.StudentImageDownloadButton.UseVisualStyleBackColor = false;
            this.StudentImageDownloadButton.Click += new System.EventHandler(this.StudentImageDownloadButton_Click);
            // 
            // TextBoxAdres2
            // 
            this.TextBoxAdres2.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxAdres2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxAdres2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxAdres2.Location = new System.Drawing.Point(75, 417);
            this.TextBoxAdres2.Name = "TextBoxAdres2";
            this.TextBoxAdres2.Size = new System.Drawing.Size(335, 20);
            this.TextBoxAdres2.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(57, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 21);
            this.label8.TabIndex = 55;
            this.label8.Text = "Kraj:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Location = new System.Drawing.Point(61, 438);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(365, 1);
            this.panel4.TabIndex = 54;
            // 
            // EditStudentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1504, 723);
            this.Controls.Add(this.TextBoxAdres2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.StudentImageDownloadButton);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.EditStudentButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StudentImageUploadButton);
            this.Controls.Add(this.StudentImageBox);
            this.Controls.Add(this.TextBoxAdres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.radioButtonK);
            this.Controls.Add(this.radioButtonM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TextBoxNazwisko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TextBoxImie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditStudentWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edytuj studenta";
            this.Load += new System.EventHandler(this.editStudentWindow_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.StudentImageBox)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button StudentImageUploadButton;
        private System.Windows.Forms.PictureBox StudentImageBox;
        private System.Windows.Forms.TextBox TextBoxAdres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioButtonK;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TextBoxNazwisko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TextBoxImie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button DeleteStudentButton;
        private System.Windows.Forms.Button EditStudentButton;
        internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label StudentsCounter_Click;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button StudentImageDownloadButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.TextBox TextBoxAdres2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
    }
}