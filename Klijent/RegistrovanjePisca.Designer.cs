namespace Klijent
{
    partial class RegistrovanjePisca
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
            this.pisac_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.jmbg_textBox = new System.Windows.Forms.TextBox();
            this.prezime_textBox = new System.Windows.Forms.TextBox();
            this.ime_label = new System.Windows.Forms.Label();
            this.prezime_label = new System.Windows.Forms.Label();
            this.jmbg_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ime_textBox = new System.Windows.Forms.TextBox();
            this.datumRodjenja_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RegistrujPisca_button = new System.Windows.Forms.Button();
            this.greska_label = new System.Windows.Forms.Label();
            this.pisac_tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pisac_tableLayoutPanel
            // 
            this.pisac_tableLayoutPanel.ColumnCount = 2;
            this.pisac_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.pisac_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.pisac_tableLayoutPanel.Controls.Add(this.jmbg_textBox, 1, 2);
            this.pisac_tableLayoutPanel.Controls.Add(this.prezime_textBox, 1, 1);
            this.pisac_tableLayoutPanel.Controls.Add(this.ime_label, 0, 0);
            this.pisac_tableLayoutPanel.Controls.Add(this.prezime_label, 0, 1);
            this.pisac_tableLayoutPanel.Controls.Add(this.jmbg_label, 0, 2);
            this.pisac_tableLayoutPanel.Controls.Add(this.label3, 0, 3);
            this.pisac_tableLayoutPanel.Controls.Add(this.ime_textBox, 1, 0);
            this.pisac_tableLayoutPanel.Controls.Add(this.datumRodjenja_dateTimePicker, 1, 3);
            this.pisac_tableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pisac_tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.pisac_tableLayoutPanel.Name = "pisac_tableLayoutPanel";
            this.pisac_tableLayoutPanel.RowCount = 4;
            this.pisac_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pisac_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.61809F));
            this.pisac_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.62814F));
            this.pisac_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pisac_tableLayoutPanel.Size = new System.Drawing.Size(368, 199);
            this.pisac_tableLayoutPanel.TabIndex = 0;
            // 
            // jmbg_textBox
            // 
            this.jmbg_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.jmbg_textBox.Location = new System.Drawing.Point(105, 112);
            this.jmbg_textBox.Name = "jmbg_textBox";
            this.jmbg_textBox.Size = new System.Drawing.Size(180, 20);
            this.jmbg_textBox.TabIndex = 9;
            // 
            // prezime_textBox
            // 
            this.prezime_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.prezime_textBox.Location = new System.Drawing.Point(105, 63);
            this.prezime_textBox.Name = "prezime_textBox";
            this.prezime_textBox.Size = new System.Drawing.Size(180, 20);
            this.prezime_textBox.TabIndex = 8;
            // 
            // ime_label
            // 
            this.ime_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ime_label.Location = new System.Drawing.Point(3, 5);
            this.ime_label.Name = "ime_label";
            this.ime_label.Size = new System.Drawing.Size(96, 39);
            this.ime_label.TabIndex = 3;
            this.ime_label.Text = "Ime";
            this.ime_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prezime_label
            // 
            this.prezime_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prezime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezime_label.Location = new System.Drawing.Point(9, 54);
            this.prezime_label.Name = "prezime_label";
            this.prezime_label.Size = new System.Drawing.Size(83, 39);
            this.prezime_label.TabIndex = 4;
            this.prezime_label.Text = "Prezime";
            this.prezime_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jmbg_label
            // 
            this.jmbg_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jmbg_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jmbg_label.Location = new System.Drawing.Point(9, 103);
            this.jmbg_label.Name = "jmbg_label";
            this.jmbg_label.Size = new System.Drawing.Size(83, 39);
            this.jmbg_label.TabIndex = 5;
            this.jmbg_label.Text = "JMBG";
            this.jmbg_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum rođenja";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ime_textBox
            // 
            this.ime_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ime_textBox.Location = new System.Drawing.Point(105, 15);
            this.ime_textBox.Name = "ime_textBox";
            this.ime_textBox.Size = new System.Drawing.Size(180, 20);
            this.ime_textBox.TabIndex = 7;
            // 
            // datumRodjenja_dateTimePicker
            // 
            this.datumRodjenja_dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.datumRodjenja_dateTimePicker.CustomFormat = "dd  -  MMM  -  yyyy";
            this.datumRodjenja_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datumRodjenja_dateTimePicker.Location = new System.Drawing.Point(105, 163);
            this.datumRodjenja_dateTimePicker.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.datumRodjenja_dateTimePicker.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.datumRodjenja_dateTimePicker.Name = "datumRodjenja_dateTimePicker";
            this.datumRodjenja_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datumRodjenja_dateTimePicker.TabIndex = 10;
            this.datumRodjenja_dateTimePicker.Value = new System.DateTime(2019, 5, 9, 0, 0, 0, 0);
            // 
            // RegistrujPisca_button
            // 
            this.RegistrujPisca_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrujPisca_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrujPisca_button.Location = new System.Drawing.Point(131, 293);
            this.RegistrujPisca_button.Name = "RegistrujPisca_button";
            this.RegistrujPisca_button.Size = new System.Drawing.Size(133, 42);
            this.RegistrujPisca_button.TabIndex = 1;
            this.RegistrujPisca_button.Text = "Registrj pisca";
            this.RegistrujPisca_button.UseVisualStyleBackColor = true;
            this.RegistrujPisca_button.Click += new System.EventHandler(this.RegistrujPisca_Click);
            // 
            // greska_label
            // 
            this.greska_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.greska_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greska_label.ForeColor = System.Drawing.Color.Red;
            this.greska_label.Location = new System.Drawing.Point(10, 212);
            this.greska_label.Name = "greska_label";
            this.greska_label.Size = new System.Drawing.Size(368, 80);
            this.greska_label.TabIndex = 2;
            this.greska_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegistrovanjePisca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 351);
            this.Controls.Add(this.greska_label);
            this.Controls.Add(this.RegistrujPisca_button);
            this.Controls.Add(this.pisac_tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(408, 390);
            this.MinimumSize = new System.Drawing.Size(408, 390);
            this.Name = "RegistrovanjePisca";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrovanje pisca";
            this.pisac_tableLayoutPanel.ResumeLayout(false);
            this.pisac_tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel pisac_tableLayoutPanel;
        private System.Windows.Forms.TextBox jmbg_textBox;
        private System.Windows.Forms.TextBox prezime_textBox;
        private System.Windows.Forms.Label ime_label;
        private System.Windows.Forms.Label prezime_label;
        private System.Windows.Forms.Label jmbg_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ime_textBox;
        private System.Windows.Forms.DateTimePicker datumRodjenja_dateTimePicker;
        private System.Windows.Forms.Button RegistrujPisca_button;
        private System.Windows.Forms.Label greska_label;
    }
}