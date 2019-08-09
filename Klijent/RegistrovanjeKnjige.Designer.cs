namespace Klijent
{
    partial class RegistrovanjeKnjige
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
            this.naziv_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.godinaIzdavanja_label = new System.Windows.Forms.Label();
            this.nazivKnjige_textBox = new System.Windows.Forms.TextBox();
            this.kolicina_label = new System.Windows.Forms.Label();
            this.kolicina_textBox = new System.Windows.Forms.TextBox();
            this.godIzdavanja_textBox = new System.Windows.Forms.TextBox();
            this.Pisac_label = new System.Windows.Forms.Label();
            this.pisac_comboBox = new System.Windows.Forms.ComboBox();
            this.buttons_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.registrujKnjigu_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.greska_label = new System.Windows.Forms.Label();
            this.RegistrujPisca_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.buttons_tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // naziv_label
            // 
            this.naziv_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.naziv_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naziv_label.Location = new System.Drawing.Point(3, 6);
            this.naziv_label.Name = "naziv_label";
            this.naziv_label.Size = new System.Drawing.Size(130, 31);
            this.naziv_label.TabIndex = 0;
            this.naziv_label.Text = "Naziv knjige";
            this.naziv_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 239F));
            this.tableLayoutPanel1.Controls.Add(this.naziv_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.godinaIzdavanja_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nazivKnjige_textBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.kolicina_label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.kolicina_textBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.godIzdavanja_textBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Pisac_label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pisac_comboBox, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 179);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // godinaIzdavanja_label
            // 
            this.godinaIzdavanja_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.godinaIzdavanja_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.godinaIzdavanja_label.Location = new System.Drawing.Point(5, 51);
            this.godinaIzdavanja_label.Name = "godinaIzdavanja_label";
            this.godinaIzdavanja_label.Size = new System.Drawing.Size(126, 29);
            this.godinaIzdavanja_label.TabIndex = 0;
            this.godinaIzdavanja_label.Text = "Godina izdavanja";
            this.godinaIzdavanja_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nazivKnjige_textBox
            // 
            this.nazivKnjige_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nazivKnjige_textBox.Location = new System.Drawing.Point(139, 12);
            this.nazivKnjige_textBox.Name = "nazivKnjige_textBox";
            this.nazivKnjige_textBox.Size = new System.Drawing.Size(180, 20);
            this.nazivKnjige_textBox.TabIndex = 1;
            // 
            // kolicina_label
            // 
            this.kolicina_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kolicina_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kolicina_label.Location = new System.Drawing.Point(5, 94);
            this.kolicina_label.Name = "kolicina_label";
            this.kolicina_label.Size = new System.Drawing.Size(125, 31);
            this.kolicina_label.TabIndex = 3;
            this.kolicina_label.Text = "Količina knjiga";
            this.kolicina_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kolicina_textBox
            // 
            this.kolicina_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kolicina_textBox.Location = new System.Drawing.Point(139, 100);
            this.kolicina_textBox.Name = "kolicina_textBox";
            this.kolicina_textBox.Size = new System.Drawing.Size(46, 20);
            this.kolicina_textBox.TabIndex = 4;
            this.kolicina_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // godIzdavanja_textBox
            // 
            this.godIzdavanja_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.godIzdavanja_textBox.Location = new System.Drawing.Point(139, 56);
            this.godIzdavanja_textBox.Name = "godIzdavanja_textBox";
            this.godIzdavanja_textBox.Size = new System.Drawing.Size(46, 20);
            this.godIzdavanja_textBox.TabIndex = 5;
            this.godIzdavanja_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Pisac_label
            // 
            this.Pisac_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pisac_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pisac_label.Location = new System.Drawing.Point(6, 140);
            this.Pisac_label.Name = "Pisac_label";
            this.Pisac_label.Size = new System.Drawing.Size(124, 30);
            this.Pisac_label.TabIndex = 6;
            this.Pisac_label.Text = "Pisac";
            this.Pisac_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pisac_comboBox
            // 
            this.pisac_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pisac_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pisac_comboBox.FormattingEnabled = true;
            this.pisac_comboBox.Location = new System.Drawing.Point(139, 145);
            this.pisac_comboBox.Name = "pisac_comboBox";
            this.pisac_comboBox.Size = new System.Drawing.Size(180, 21);
            this.pisac_comboBox.TabIndex = 7;
            // 
            // buttons_tableLayoutPanel
            // 
            this.buttons_tableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttons_tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttons_tableLayoutPanel.ColumnCount = 1;
            this.buttons_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttons_tableLayoutPanel.Controls.Add(this.registrujKnjigu_button, 0, 0);
            this.buttons_tableLayoutPanel.Controls.Add(this.back_button, 0, 1);
            this.buttons_tableLayoutPanel.Location = new System.Drawing.Point(100, 297);
            this.buttons_tableLayoutPanel.Name = "buttons_tableLayoutPanel";
            this.buttons_tableLayoutPanel.RowCount = 2;
            this.buttons_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.buttons_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.buttons_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttons_tableLayoutPanel.Size = new System.Drawing.Size(200, 81);
            this.buttons_tableLayoutPanel.TabIndex = 3;
            // 
            // registrujKnjigu_button
            // 
            this.registrujKnjigu_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registrujKnjigu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrujKnjigu_button.Location = new System.Drawing.Point(10, 3);
            this.registrujKnjigu_button.Name = "registrujKnjigu_button";
            this.registrujKnjigu_button.Size = new System.Drawing.Size(180, 36);
            this.registrujKnjigu_button.TabIndex = 1;
            this.registrujKnjigu_button.Text = "Registruj knjigu";
            this.registrujKnjigu_button.UseVisualStyleBackColor = true;
            this.registrujKnjigu_button.Click += new System.EventHandler(this.RegistrujKnjigu_button_Click);
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
            // greska_label
            // 
            this.greska_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.greska_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greska_label.ForeColor = System.Drawing.Color.Red;
            this.greska_label.Location = new System.Drawing.Point(12, 235);
            this.greska_label.Name = "greska_label";
            this.greska_label.Size = new System.Drawing.Size(375, 59);
            this.greska_label.TabIndex = 4;
            this.greska_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegistrujPisca_button
            // 
            this.RegistrujPisca_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegistrujPisca_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrujPisca_button.Location = new System.Drawing.Point(110, 197);
            this.RegistrujPisca_button.Name = "RegistrujPisca_button";
            this.RegistrujPisca_button.Size = new System.Drawing.Size(180, 35);
            this.RegistrujPisca_button.TabIndex = 5;
            this.RegistrujPisca_button.Text = "Registruj pisca";
            this.RegistrujPisca_button.UseVisualStyleBackColor = true;
            this.RegistrujPisca_button.Click += new System.EventHandler(this.RegistrujPisca_button_Click);
            // 
            // RegistrovanjeKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 390);
            this.Controls.Add(this.RegistrujPisca_button);
            this.Controls.Add(this.greska_label);
            this.Controls.Add(this.buttons_tableLayoutPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(411, 429);
            this.MinimumSize = new System.Drawing.Size(411, 429);
            this.Name = "RegistrovanjeKnjige";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrovanje knjige";
            this.Load += new System.EventHandler(this.RegistrovanjeKnjige_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.buttons_tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label naziv_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label godinaIzdavanja_label;
        private System.Windows.Forms.TextBox nazivKnjige_textBox;
        private System.Windows.Forms.TableLayoutPanel buttons_tableLayoutPanel;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button registrujKnjigu_button;
        private System.Windows.Forms.Label greska_label;
        private System.Windows.Forms.Label kolicina_label;
        private System.Windows.Forms.TextBox kolicina_textBox;
        private System.Windows.Forms.TextBox godIzdavanja_textBox;
        private System.Windows.Forms.Label Pisac_label;
        private System.Windows.Forms.ComboBox pisac_comboBox;
        private System.Windows.Forms.Button RegistrujPisca_button;
    }
}