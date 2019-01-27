namespace System_zarządzania_studentami_informatyki
{
    partial class AddSubjectWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSubjectWindow));
            this.radioButtonW = new System.Windows.Forms.RadioButton();
            this.radioButtonCw = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TextBoxTeacherName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxSubjectName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AddSubjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonW
            // 
            this.radioButtonW.AutoSize = true;
            this.radioButtonW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonW.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonW.Location = new System.Drawing.Point(228, 223);
            this.radioButtonW.Name = "radioButtonW";
            this.radioButtonW.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonW.Size = new System.Drawing.Size(86, 25);
            this.radioButtonW.TabIndex = 37;
            this.radioButtonW.Text = "Wykład";
            this.radioButtonW.UseVisualStyleBackColor = true;
            // 
            // radioButtonCw
            // 
            this.radioButtonCw.AutoSize = true;
            this.radioButtonCw.Checked = true;
            this.radioButtonCw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonCw.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonCw.Location = new System.Drawing.Point(93, 223);
            this.radioButtonCw.Name = "radioButtonCw";
            this.radioButtonCw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonCw.Size = new System.Drawing.Size(108, 25);
            this.radioButtonCw.TabIndex = 34;
            this.radioButtonCw.TabStop = true;
            this.radioButtonCw.Text = "Ćwiczenia";
            this.radioButtonCw.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(42, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 36;
            this.label5.Text = "Rodzaj zajęć:";
            // 
            // TextBoxDesc
            // 
            this.TextBoxDesc.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxDesc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxDesc.Location = new System.Drawing.Point(57, 302);
            this.TextBoxDesc.Multiline = true;
            this.TextBoxDesc.Name = "TextBoxDesc";
            this.TextBoxDesc.Size = new System.Drawing.Size(344, 105);
            this.TextBoxDesc.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(42, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Opis:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(46, 413);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 1);
            this.panel3.TabIndex = 29;
            // 
            // TextBoxTeacherName
            // 
            this.TextBoxTeacherName.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxTeacherName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTeacherName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxTeacherName.Location = new System.Drawing.Point(57, 150);
            this.TextBoxTeacherName.Name = "TextBoxTeacherName";
            this.TextBoxTeacherName.Size = new System.Drawing.Size(344, 20);
            this.TextBoxTeacherName.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(42, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Wykładowca:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(46, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 1);
            this.panel2.TabIndex = 26;
            // 
            // TextBoxSubjectName
            // 
            this.TextBoxSubjectName.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxSubjectName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSubjectName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxSubjectName.Location = new System.Drawing.Point(57, 84);
            this.TextBoxSubjectName.Name = "TextBoxSubjectName";
            this.TextBoxSubjectName.Size = new System.Drawing.Size(344, 20);
            this.TextBoxSubjectName.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(42, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nazwa przedmiotu:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(46, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 1);
            this.panel1.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Location = new System.Drawing.Point(46, 292);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(365, 1);
            this.panel4.TabIndex = 30;
            // 
            // AddSubjectButton
            // 
            this.AddSubjectButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddSubjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddSubjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSubjectButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddSubjectButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddSubjectButton.Location = new System.Drawing.Point(46, 445);
            this.AddSubjectButton.Name = "AddSubjectButton";
            this.AddSubjectButton.Size = new System.Drawing.Size(365, 43);
            this.AddSubjectButton.TabIndex = 38;
            this.AddSubjectButton.Text = "Dodaj";
            this.AddSubjectButton.UseVisualStyleBackColor = false;
            this.AddSubjectButton.Click += new System.EventHandler(this.AddSubjectButton_Click);
            // 
            // AddSubjectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(463, 526);
            this.Controls.Add(this.AddSubjectButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.radioButtonW);
            this.Controls.Add(this.radioButtonCw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TextBoxTeacherName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TextBoxSubjectName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddSubjectWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj przedmiot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonW;
        private System.Windows.Forms.RadioButton radioButtonCw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TextBoxTeacherName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TextBoxSubjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button AddSubjectButton;
    }
}