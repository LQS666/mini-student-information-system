namespace System_zarządzania_studentami_informatyki
{
    partial class ScoresWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoresWindow));
            this.dataGridViewStudentsList = new System.Windows.Forms.DataGridView();
            this.dataGridViewScoresList = new System.Windows.Forms.DataGridView();
            this.StudentsCounter_Click = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxStudentID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxSubject = new System.Windows.Forms.ComboBox();
            this.TextBoxImie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxNazwisko = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddScoreButton = new System.Windows.Forms.Button();
            this.DeleteScoreButton = new System.Windows.Forms.Button();
            this.RefreshScoresButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoresList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudentsList
            // 
            this.dataGridViewStudentsList.AccessibleName = "";
            this.dataGridViewStudentsList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewStudentsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewStudentsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewStudentsList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewStudentsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewStudentsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudentsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStudentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentsList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStudentsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStudentsList.Location = new System.Drawing.Point(29, 76);
            this.dataGridViewStudentsList.MultiSelect = false;
            this.dataGridViewStudentsList.Name = "dataGridViewStudentsList";
            this.dataGridViewStudentsList.ReadOnly = true;
            this.dataGridViewStudentsList.RowHeadersVisible = false;
            this.dataGridViewStudentsList.RowHeadersWidth = 70;
            this.dataGridViewStudentsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewStudentsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudentsList.Size = new System.Drawing.Size(409, 291);
            this.dataGridViewStudentsList.TabIndex = 84;
            this.dataGridViewStudentsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudentsList_CellClick);
            // 
            // dataGridViewScoresList
            // 
            this.dataGridViewScoresList.AccessibleName = "";
            this.dataGridViewScoresList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewScoresList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewScoresList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewScoresList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewScoresList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewScoresList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewScoresList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewScoresList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScoresList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewScoresList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewScoresList.Location = new System.Drawing.Point(463, 76);
            this.dataGridViewScoresList.MultiSelect = false;
            this.dataGridViewScoresList.Name = "dataGridViewScoresList";
            this.dataGridViewScoresList.ReadOnly = true;
            this.dataGridViewScoresList.RowHeadersVisible = false;
            this.dataGridViewScoresList.RowHeadersWidth = 70;
            this.dataGridViewScoresList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewScoresList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewScoresList.Size = new System.Drawing.Size(959, 569);
            this.dataGridViewScoresList.TabIndex = 80;
            this.dataGridViewScoresList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewScoresList_CellClick);
            // 
            // StudentsCounter_Click
            // 
            this.StudentsCounter_Click.AutoSize = true;
            this.StudentsCounter_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentsCounter_Click.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StudentsCounter_Click.ForeColor = System.Drawing.SystemColors.Control;
            this.StudentsCounter_Click.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentsCounter_Click.Location = new System.Drawing.Point(44, 40);
            this.StudentsCounter_Click.Name = "StudentsCounter_Click";
            this.StudentsCounter_Click.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StudentsCounter_Click.Size = new System.Drawing.Size(371, 22);
            this.StudentsCounter_Click.TabIndex = 54;
            this.StudentsCounter_Click.Text = "Wybierz studenta, aby przypisać ocenę";
            this.StudentsCounter_Click.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(459, 40);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(171, 22);
            this.label1.TabIndex = 55;
            this.label1.Text = "Wyniki Studentów";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxStudentID
            // 
            this.TextBoxStudentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TextBoxStudentID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxStudentID.Enabled = false;
            this.TextBoxStudentID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxStudentID.ForeColor = System.Drawing.SystemColors.Control;
            this.TextBoxStudentID.Location = new System.Drawing.Point(154, 453);
            this.TextBoxStudentID.Name = "TextBoxStudentID";
            this.TextBoxStudentID.ReadOnly = true;
            this.TextBoxStudentID.Size = new System.Drawing.Size(64, 20);
            this.TextBoxStudentID.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(25, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 21);
            this.label9.TabIndex = 63;
            this.label9.Text = "ID Studenta:";
            // 
            // TextBoxScore
            // 
            this.TextBoxScore.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxScore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxScore.Location = new System.Drawing.Point(374, 453);
            this.TextBoxScore.Name = "TextBoxScore";
            this.TextBoxScore.Size = new System.Drawing.Size(64, 20);
            this.TextBoxScore.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(299, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 60;
            this.label2.Text = "Ocena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(25, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 57;
            this.label3.Text = "Przedmiot:";
            // 
            // ComboBoxSubject
            // 
            this.ComboBoxSubject.BackColor = System.Drawing.SystemColors.Control;
            this.ComboBoxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxSubject.FormattingEnabled = true;
            this.ComboBoxSubject.Location = new System.Drawing.Point(122, 405);
            this.ComboBoxSubject.Name = "ComboBoxSubject";
            this.ComboBoxSubject.Size = new System.Drawing.Size(316, 28);
            this.ComboBoxSubject.TabIndex = 66;
            // 
            // TextBoxImie
            // 
            this.TextBoxImie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TextBoxImie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxImie.Enabled = false;
            this.TextBoxImie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxImie.ForeColor = System.Drawing.SystemColors.Control;
            this.TextBoxImie.Location = new System.Drawing.Point(170, 492);
            this.TextBoxImie.Name = "TextBoxImie";
            this.TextBoxImie.ReadOnly = true;
            this.TextBoxImie.Size = new System.Drawing.Size(257, 20);
            this.TextBoxImie.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(25, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 67;
            this.label4.Text = "Imię Studenta:";
            // 
            // TextBoxNazwisko
            // 
            this.TextBoxNazwisko.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TextBoxNazwisko.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxNazwisko.Enabled = false;
            this.TextBoxNazwisko.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxNazwisko.ForeColor = System.Drawing.SystemColors.Control;
            this.TextBoxNazwisko.Location = new System.Drawing.Point(211, 530);
            this.TextBoxNazwisko.Name = "TextBoxNazwisko";
            this.TextBoxNazwisko.ReadOnly = true;
            this.TextBoxNazwisko.Size = new System.Drawing.Size(216, 20);
            this.TextBoxNazwisko.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(25, 530);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 21);
            this.label5.TabIndex = 69;
            this.label5.Text = "Nazwisko Studenta:";
            // 
            // AddScoreButton
            // 
            this.AddScoreButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddScoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddScoreButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddScoreButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddScoreButton.Location = new System.Drawing.Point(29, 611);
            this.AddScoreButton.Name = "AddScoreButton";
            this.AddScoreButton.Size = new System.Drawing.Size(257, 34);
            this.AddScoreButton.TabIndex = 71;
            this.AddScoreButton.Text = "Dodaj ocenę";
            this.AddScoreButton.UseVisualStyleBackColor = false;
            this.AddScoreButton.Click += new System.EventHandler(this.AddScoreButton_Click);
            // 
            // DeleteScoreButton
            // 
            this.DeleteScoreButton.BackColor = System.Drawing.Color.Crimson;
            this.DeleteScoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteScoreButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteScoreButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteScoreButton.Location = new System.Drawing.Point(303, 611);
            this.DeleteScoreButton.Name = "DeleteScoreButton";
            this.DeleteScoreButton.Size = new System.Drawing.Size(135, 34);
            this.DeleteScoreButton.TabIndex = 72;
            this.DeleteScoreButton.Text = "Usuń ocenę";
            this.DeleteScoreButton.UseVisualStyleBackColor = false;
            this.DeleteScoreButton.Click += new System.EventHandler(this.DeleteScoreButton_Click);
            // 
            // RefreshScoresButton
            // 
            this.RefreshScoresButton.BackColor = System.Drawing.Color.White;
            this.RefreshScoresButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshScoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshScoresButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RefreshScoresButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RefreshScoresButton.Location = new System.Drawing.Point(1255, 651);
            this.RefreshScoresButton.Name = "RefreshScoresButton";
            this.RefreshScoresButton.Size = new System.Drawing.Size(167, 43);
            this.RefreshScoresButton.TabIndex = 85;
            this.RefreshScoresButton.Text = "Odśwież";
            this.RefreshScoresButton.UseVisualStyleBackColor = false;
            this.RefreshScoresButton.Click += new System.EventHandler(this.RefreshScoresButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(143, 479);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 1);
            this.panel2.TabIndex = 86;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(158, 518);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 1);
            this.panel1.TabIndex = 87;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(198, 556);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 1);
            this.panel3.TabIndex = 88;
            // 
            // ScoresWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1448, 706);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RefreshScoresButton);
            this.Controls.Add(this.DeleteScoreButton);
            this.Controls.Add(this.AddScoreButton);
            this.Controls.Add(this.TextBoxNazwisko);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxImie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboBoxSubject);
            this.Controls.Add(this.TextBoxStudentID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextBoxScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentsCounter_Click);
            this.Controls.Add(this.dataGridViewScoresList);
            this.Controls.Add(this.dataGridViewStudentsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ScoresWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oceny";
            this.Load += new System.EventHandler(this.ScoresWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoresList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dataGridViewStudentsList;
        internal System.Windows.Forms.DataGridView dataGridViewScoresList;
        private System.Windows.Forms.Label StudentsCounter_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox ComboBoxSubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddScoreButton;
        private System.Windows.Forms.Button DeleteScoreButton;
        internal System.Windows.Forms.TextBox TextBoxScore;
        internal System.Windows.Forms.TextBox TextBoxStudentID;
        internal System.Windows.Forms.TextBox TextBoxImie;
        internal System.Windows.Forms.TextBox TextBoxNazwisko;
        private System.Windows.Forms.Button RefreshScoresButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}