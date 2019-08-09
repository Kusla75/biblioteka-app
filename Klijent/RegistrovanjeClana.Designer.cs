namespace Klijent
{
    partial class RegistrovanjeClana
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
            this.back_button = new System.Windows.Forms.Button();
            this.signUp_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.prezime_textBox = new System.Windows.Forms.TextBox();
            this.ime_label = new System.Windows.Forms.Label();
            this.prezime_label = new System.Windows.Forms.Label();
            this.datumRodjenja_label = new System.Windows.Forms.Label();
            this.jmbg_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.ime_textBox = new System.Windows.Forms.TextBox();
            this.jmbg_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttons_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.registrujClana_button = new System.Windows.Forms.Button();
            this.greska_label = new System.Windows.Forms.Label();
            this.signUp_tableLayoutPanel.SuspendLayout();
            this.buttons_tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(40, 46);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(120, 32);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "Nazad";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // signUp_tableLayoutPanel
            // 
            this.signUp_tableLayoutPanel.ColumnCount = 2;
            this.signUp_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.signUp_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.signUp_tableLayoutPanel.Controls.Add(this.prezime_textBox, 1, 1);
            this.signUp_tableLayoutPanel.Controls.Add(this.ime_label, 0, 0);
            this.signUp_tableLayoutPanel.Controls.Add(this.prezime_label, 0, 1);
            this.signUp_tableLayoutPanel.Controls.Add(this.datumRodjenja_label, 0, 2);
            this.signUp_tableLayoutPanel.Controls.Add(this.jmbg_label, 0, 3);
            this.signUp_tableLayoutPanel.Controls.Add(this.email_label, 0, 4);
            this.signUp_tableLayoutPanel.Controls.Add(this.ime_textBox, 1, 0);
            this.signUp_tableLayoutPanel.Controls.Add(this.jmbg_textBox, 1, 3);
            this.signUp_tableLayoutPanel.Controls.Add(this.email_textBox, 1, 4);
            this.signUp_tableLayoutPanel.Controls.Add(this.dateTimePicker, 1, 2);
            this.signUp_tableLayoutPanel.Location = new System.Drawing.Point(64, 12);
            this.signUp_tableLayoutPanel.Name = "signUp_tableLayoutPanel";
            this.signUp_tableLayoutPanel.RowCount = 5;
            this.signUp_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.signUp_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.signUp_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.signUp_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.signUp_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.signUp_tableLayoutPanel.Size = new System.Drawing.Size(323, 288);
            this.signUp_tableLayoutPanel.TabIndex = 1;
            // 
            // prezime_textBox
            // 
            this.prezime_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.prezime_textBox.Location = new System.Drawing.Point(103, 75);
            this.prezime_textBox.Name = "prezime_textBox";
            this.prezime_textBox.Size = new System.Drawing.Size(160, 20);
            this.prezime_textBox.TabIndex = 8;
            // 
            // ime_label
            // 
            this.ime_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ime_label.Location = new System.Drawing.Point(3, 6);
            this.ime_label.Name = "ime_label";
            this.ime_label.Size = new System.Drawing.Size(94, 45);
            this.ime_label.TabIndex = 2;
            this.ime_label.Text = "Ime";
            this.ime_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prezime_label
            // 
            this.prezime_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prezime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezime_label.Location = new System.Drawing.Point(3, 63);
            this.prezime_label.Name = "prezime_label";
            this.prezime_label.Size = new System.Drawing.Size(94, 45);
            this.prezime_label.TabIndex = 3;
            this.prezime_label.Text = "Prezime";
            this.prezime_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datumRodjenja_label
            // 
            this.datumRodjenja_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datumRodjenja_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumRodjenja_label.Location = new System.Drawing.Point(3, 120);
            this.datumRodjenja_label.Name = "datumRodjenja_label";
            this.datumRodjenja_label.Size = new System.Drawing.Size(94, 45);
            this.datumRodjenja_label.TabIndex = 4;
            this.datumRodjenja_label.Text = "Datum rođenja";
            this.datumRodjenja_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jmbg_label
            // 
            this.jmbg_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jmbg_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jmbg_label.Location = new System.Drawing.Point(3, 177);
            this.jmbg_label.Name = "jmbg_label";
            this.jmbg_label.Size = new System.Drawing.Size(94, 45);
            this.jmbg_label.TabIndex = 5;
            this.jmbg_label.Text = "JMBG";
            this.jmbg_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email_label
            // 
            this.email_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(3, 235);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(94, 45);
            this.email_label.TabIndex = 6;
            this.email_label.Text = "Email";
            this.email_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ime_textBox
            // 
            this.ime_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ime_textBox.Location = new System.Drawing.Point(103, 18);
            this.ime_textBox.Name = "ime_textBox";
            this.ime_textBox.Size = new System.Drawing.Size(160, 20);
            this.ime_textBox.TabIndex = 7;
            // 
            // jmbg_textBox
            // 
            this.jmbg_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.jmbg_textBox.Location = new System.Drawing.Point(103, 189);
            this.jmbg_textBox.Name = "jmbg_textBox";
            this.jmbg_textBox.Size = new System.Drawing.Size(160, 20);
            this.jmbg_textBox.TabIndex = 9;
            // 
            // email_textBox
            // 
            this.email_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.email_textBox.Location = new System.Drawing.Point(103, 248);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(160, 20);
            this.email_textBox.TabIndex = 10;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker.CustomFormat = "dd  -  MMM  -  yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(103, 132);
            this.dateTimePicker.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(160, 21);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.Value = new System.DateTime(2019, 5, 9, 0, 0, 0, 0);
            // 
            // buttons_tableLayoutPanel
            // 
            this.buttons_tableLayoutPanel.ColumnCount = 1;
            this.buttons_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttons_tableLayoutPanel.Controls.Add(this.back_button, 0, 1);
            this.buttons_tableLayoutPanel.Controls.Add(this.registrujClana_button, 0, 0);
            this.buttons_tableLayoutPanel.Location = new System.Drawing.Point(127, 358);
            this.buttons_tableLayoutPanel.Name = "buttons_tableLayoutPanel";
            this.buttons_tableLayoutPanel.RowCount = 2;
            this.buttons_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.buttons_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.buttons_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttons_tableLayoutPanel.Size = new System.Drawing.Size(200, 81);
            this.buttons_tableLayoutPanel.TabIndex = 2;
            // 
            // registrujClana_button
            // 
            this.registrujClana_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registrujClana_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrujClana_button.Location = new System.Drawing.Point(10, 3);
            this.registrujClana_button.Name = "registrujClana_button";
            this.registrujClana_button.Size = new System.Drawing.Size(180, 36);
            this.registrujClana_button.TabIndex = 1;
            this.registrujClana_button.Text = "Registruj člana";
            this.registrujClana_button.UseVisualStyleBackColor = true;
            this.registrujClana_button.Click += new System.EventHandler(this.SignUp_button_Click);
            // 
            // greska_label
            // 
            this.greska_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.greska_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greska_label.ForeColor = System.Drawing.Color.Red;
            this.greska_label.Location = new System.Drawing.Point(35, 303);
            this.greska_label.Name = "greska_label";
            this.greska_label.Size = new System.Drawing.Size(381, 52);
            this.greska_label.TabIndex = 2;
            this.greska_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegistrovanjeClana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(454, 451);
            this.Controls.Add(this.buttons_tableLayoutPanel);
            this.Controls.Add(this.signUp_tableLayoutPanel);
            this.Controls.Add(this.greska_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 490);
            this.MinimumSize = new System.Drawing.Size(470, 490);
            this.Name = "RegistrovanjeClana";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrovanje člana";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.signUp_tableLayoutPanel.ResumeLayout(false);
            this.signUp_tableLayoutPanel.PerformLayout();
            this.buttons_tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TableLayoutPanel signUp_tableLayoutPanel;
        private System.Windows.Forms.Label ime_label;
        private System.Windows.Forms.Label prezime_label;
        private System.Windows.Forms.Label datumRodjenja_label;
        private System.Windows.Forms.Label jmbg_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox ime_textBox;
        private System.Windows.Forms.TextBox prezime_textBox;
        private System.Windows.Forms.TextBox jmbg_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TableLayoutPanel buttons_tableLayoutPanel;
        private System.Windows.Forms.Button registrujClana_button;
        private System.Windows.Forms.Label greska_label;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}