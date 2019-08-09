namespace Klijent
{
    partial class SveTabele
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
            this.SveTabele_dataGridView = new System.Windows.Forms.DataGridView();
            this.Buttons_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Iznajmljivanja_button = new System.Windows.Forms.Button();
            this.Pisci_button = new System.Windows.Forms.Button();
            this.Knjige_button = new System.Windows.Forms.Button();
            this.Clanovi_button = new System.Windows.Forms.Button();
            this.Izmena_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Back_button = new System.Windows.Forms.Button();
            this.Izmeni_button = new System.Windows.Forms.Button();
            this.Greska_label = new System.Windows.Forms.Label();
            this.Izmena_label = new System.Windows.Forms.Label();
            this.Izmena_textBox = new System.Windows.Forms.TextBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.SveTabele_dataGridView)).BeginInit();
            this.Buttons_tableLayoutPanel.SuspendLayout();
            this.Izmena_tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SveTabele_dataGridView
            // 
            this.SveTabele_dataGridView.AllowUserToAddRows = false;
            this.SveTabele_dataGridView.AllowUserToDeleteRows = false;
            this.SveTabele_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SveTabele_dataGridView.Location = new System.Drawing.Point(12, 70);
            this.SveTabele_dataGridView.MultiSelect = false;
            this.SveTabele_dataGridView.Name = "SveTabele_dataGridView";
            this.SveTabele_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.SveTabele_dataGridView.Size = new System.Drawing.Size(670, 369);
            this.SveTabele_dataGridView.TabIndex = 0;
            this.SveTabele_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SveTabele_dataGridView_CellClick);
            // 
            // Buttons_tableLayoutPanel
            // 
            this.Buttons_tableLayoutPanel.ColumnCount = 4;
            this.Buttons_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Buttons_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Buttons_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Buttons_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Buttons_tableLayoutPanel.Controls.Add(this.Iznajmljivanja_button, 3, 0);
            this.Buttons_tableLayoutPanel.Controls.Add(this.Pisci_button, 2, 0);
            this.Buttons_tableLayoutPanel.Controls.Add(this.Knjige_button, 1, 0);
            this.Buttons_tableLayoutPanel.Controls.Add(this.Clanovi_button, 0, 0);
            this.Buttons_tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.Buttons_tableLayoutPanel.Name = "Buttons_tableLayoutPanel";
            this.Buttons_tableLayoutPanel.RowCount = 1;
            this.Buttons_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Buttons_tableLayoutPanel.Size = new System.Drawing.Size(670, 52);
            this.Buttons_tableLayoutPanel.TabIndex = 1;
            // 
            // Iznajmljivanja_button
            // 
            this.Iznajmljivanja_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Iznajmljivanja_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iznajmljivanja_button.Location = new System.Drawing.Point(504, 3);
            this.Iznajmljivanja_button.Name = "Iznajmljivanja_button";
            this.Iznajmljivanja_button.Size = new System.Drawing.Size(163, 46);
            this.Iznajmljivanja_button.TabIndex = 5;
            this.Iznajmljivanja_button.Text = "Iznajmljivanja";
            this.Iznajmljivanja_button.UseVisualStyleBackColor = true;
            this.Iznajmljivanja_button.Click += new System.EventHandler(this.Iznajmljivanja_button_Click);
            // 
            // Pisci_button
            // 
            this.Pisci_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pisci_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pisci_button.Location = new System.Drawing.Point(337, 3);
            this.Pisci_button.Name = "Pisci_button";
            this.Pisci_button.Size = new System.Drawing.Size(161, 46);
            this.Pisci_button.TabIndex = 4;
            this.Pisci_button.Text = "Pisci";
            this.Pisci_button.UseVisualStyleBackColor = true;
            this.Pisci_button.Click += new System.EventHandler(this.Pisci_button_Click);
            // 
            // Knjige_button
            // 
            this.Knjige_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Knjige_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Knjige_button.Location = new System.Drawing.Point(170, 3);
            this.Knjige_button.Name = "Knjige_button";
            this.Knjige_button.Size = new System.Drawing.Size(161, 46);
            this.Knjige_button.TabIndex = 3;
            this.Knjige_button.Text = "Knjige";
            this.Knjige_button.UseVisualStyleBackColor = true;
            this.Knjige_button.Click += new System.EventHandler(this.Knjige_button_Click);
            // 
            // Clanovi_button
            // 
            this.Clanovi_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clanovi_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clanovi_button.Location = new System.Drawing.Point(3, 3);
            this.Clanovi_button.Name = "Clanovi_button";
            this.Clanovi_button.Size = new System.Drawing.Size(161, 46);
            this.Clanovi_button.TabIndex = 2;
            this.Clanovi_button.Text = "Članovi";
            this.Clanovi_button.UseVisualStyleBackColor = true;
            this.Clanovi_button.Click += new System.EventHandler(this.Clanovi_button_Click);
            // 
            // Izmena_tableLayoutPanel
            // 
            this.Izmena_tableLayoutPanel.ColumnCount = 1;
            this.Izmena_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Izmena_tableLayoutPanel.Controls.Add(this.Back_button, 0, 5);
            this.Izmena_tableLayoutPanel.Controls.Add(this.Izmeni_button, 0, 4);
            this.Izmena_tableLayoutPanel.Controls.Add(this.Greska_label, 0, 3);
            this.Izmena_tableLayoutPanel.Controls.Add(this.Izmena_label, 0, 0);
            this.Izmena_tableLayoutPanel.Controls.Add(this.Izmena_textBox, 0, 1);
            this.Izmena_tableLayoutPanel.Controls.Add(this.DateTimePicker, 0, 2);
            this.Izmena_tableLayoutPanel.Location = new System.Drawing.Point(688, 95);
            this.Izmena_tableLayoutPanel.Name = "Izmena_tableLayoutPanel";
            this.Izmena_tableLayoutPanel.RowCount = 6;
            this.Izmena_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Izmena_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Izmena_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Izmena_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Izmena_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Izmena_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Izmena_tableLayoutPanel.Size = new System.Drawing.Size(293, 304);
            this.Izmena_tableLayoutPanel.TabIndex = 2;
            // 
            // Back_button
            // 
            this.Back_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.Location = new System.Drawing.Point(80, 259);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(133, 35);
            this.Back_button.TabIndex = 7;
            this.Back_button.Text = "Nazad";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Izmeni_button
            // 
            this.Izmeni_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Izmeni_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Izmeni_button.Location = new System.Drawing.Point(3, 203);
            this.Izmeni_button.Name = "Izmeni_button";
            this.Izmeni_button.Size = new System.Drawing.Size(287, 44);
            this.Izmeni_button.TabIndex = 8;
            this.Izmeni_button.Text = "Izmeni";
            this.Izmeni_button.UseVisualStyleBackColor = true;
            this.Izmeni_button.Click += new System.EventHandler(this.Izmeni_button_Click);
            // 
            // Greska_label
            // 
            this.Greska_label.AutoSize = true;
            this.Greska_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Greska_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Greska_label.ForeColor = System.Drawing.Color.Red;
            this.Greska_label.Location = new System.Drawing.Point(3, 150);
            this.Greska_label.Name = "Greska_label";
            this.Greska_label.Size = new System.Drawing.Size(287, 50);
            this.Greska_label.TabIndex = 9;
            this.Greska_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Izmena_label
            // 
            this.Izmena_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Izmena_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Izmena_label.Location = new System.Drawing.Point(3, 0);
            this.Izmena_label.Name = "Izmena_label";
            this.Izmena_label.Size = new System.Drawing.Size(201, 50);
            this.Izmena_label.TabIndex = 11;
            this.Izmena_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Izmena_textBox
            // 
            this.Izmena_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Izmena_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Izmena_textBox.Location = new System.Drawing.Point(3, 63);
            this.Izmena_textBox.Name = "Izmena_textBox";
            this.Izmena_textBox.Size = new System.Drawing.Size(287, 23);
            this.Izmena_textBox.TabIndex = 10;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateTimePicker.CustomFormat = "dd   -   MMM   -   yyyy";
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker.Location = new System.Drawing.Point(3, 115);
            this.DateTimePicker.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker.TabIndex = 12;
            this.DateTimePicker.Value = new System.DateTime(2019, 5, 9, 0, 0, 0, 0);
            // 
            // SveTabele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 451);
            this.Controls.Add(this.Izmena_tableLayoutPanel);
            this.Controls.Add(this.Buttons_tableLayoutPanel);
            this.Controls.Add(this.SveTabele_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1009, 490);
            this.MinimumSize = new System.Drawing.Size(1009, 490);
            this.Name = "SveTabele";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sve tabele";
            this.Load += new System.EventHandler(this.SveTabele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SveTabele_dataGridView)).EndInit();
            this.Buttons_tableLayoutPanel.ResumeLayout(false);
            this.Izmena_tableLayoutPanel.ResumeLayout(false);
            this.Izmena_tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SveTabele_dataGridView;
        private System.Windows.Forms.TableLayoutPanel Buttons_tableLayoutPanel;
        private System.Windows.Forms.Button Clanovi_button;
        private System.Windows.Forms.Button Iznajmljivanja_button;
        private System.Windows.Forms.Button Pisci_button;
        private System.Windows.Forms.Button Knjige_button;
        private System.Windows.Forms.TableLayoutPanel Izmena_tableLayoutPanel;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Izmeni_button;
        private System.Windows.Forms.Label Greska_label;
        private System.Windows.Forms.TextBox Izmena_textBox;
        private System.Windows.Forms.Label Izmena_label;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
    }
}