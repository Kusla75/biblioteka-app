namespace Klijent
{
    partial class DetaljnaPretraga
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
            this.Pretraga_dataGridView = new System.Windows.Forms.DataGridView();
            this.RadioButton_groupBox = new System.Windows.Forms.GroupBox();
            this.RadioButton_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Pisac_radioButton = new System.Windows.Forms.RadioButton();
            this.Knjiga_radioButton = new System.Windows.Forms.RadioButton();
            this.Clan_radioButton = new System.Windows.Forms.RadioButton();
            this.Unos_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Button_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Pretraga_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.Info_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pretraga_dataGridView)).BeginInit();
            this.RadioButton_groupBox.SuspendLayout();
            this.RadioButton_tableLayoutPanel.SuspendLayout();
            this.Unos_tableLayoutPanel.SuspendLayout();
            this.Button_tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pretraga_dataGridView
            // 
            this.Pretraga_dataGridView.AllowUserToAddRows = false;
            this.Pretraga_dataGridView.AllowUserToDeleteRows = false;
            this.Pretraga_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pretraga_dataGridView.Location = new System.Drawing.Point(309, 55);
            this.Pretraga_dataGridView.MultiSelect = false;
            this.Pretraga_dataGridView.Name = "Pretraga_dataGridView";
            this.Pretraga_dataGridView.ReadOnly = true;
            this.Pretraga_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Pretraga_dataGridView.Size = new System.Drawing.Size(529, 346);
            this.Pretraga_dataGridView.TabIndex = 0;
            // 
            // RadioButton_groupBox
            // 
            this.RadioButton_groupBox.Controls.Add(this.RadioButton_tableLayoutPanel);
            this.RadioButton_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_groupBox.Location = new System.Drawing.Point(12, 12);
            this.RadioButton_groupBox.Name = "RadioButton_groupBox";
            this.RadioButton_groupBox.Size = new System.Drawing.Size(291, 60);
            this.RadioButton_groupBox.TabIndex = 1;
            this.RadioButton_groupBox.TabStop = false;
            this.RadioButton_groupBox.Text = "Traženi podatak";
            // 
            // RadioButton_tableLayoutPanel
            // 
            this.RadioButton_tableLayoutPanel.ColumnCount = 3;
            this.RadioButton_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.RadioButton_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.RadioButton_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.RadioButton_tableLayoutPanel.Controls.Add(this.Pisac_radioButton, 2, 0);
            this.RadioButton_tableLayoutPanel.Controls.Add(this.Knjiga_radioButton, 1, 0);
            this.RadioButton_tableLayoutPanel.Controls.Add(this.Clan_radioButton, 0, 0);
            this.RadioButton_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadioButton_tableLayoutPanel.Location = new System.Drawing.Point(3, 17);
            this.RadioButton_tableLayoutPanel.Name = "RadioButton_tableLayoutPanel";
            this.RadioButton_tableLayoutPanel.RowCount = 1;
            this.RadioButton_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RadioButton_tableLayoutPanel.Size = new System.Drawing.Size(285, 40);
            this.RadioButton_tableLayoutPanel.TabIndex = 2;
            // 
            // Pisac_radioButton
            // 
            this.Pisac_radioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pisac_radioButton.AutoSize = true;
            this.Pisac_radioButton.Location = new System.Drawing.Point(210, 10);
            this.Pisac_radioButton.Name = "Pisac_radioButton";
            this.Pisac_radioButton.Size = new System.Drawing.Size(55, 19);
            this.Pisac_radioButton.TabIndex = 2;
            this.Pisac_radioButton.TabStop = true;
            this.Pisac_radioButton.Text = "Pisac";
            this.Pisac_radioButton.UseVisualStyleBackColor = true;
            this.Pisac_radioButton.CheckedChanged += new System.EventHandler(this.Pisac_radioButton_CheckedChanged);
            // 
            // Knjiga_radioButton
            // 
            this.Knjiga_radioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Knjiga_radioButton.AutoSize = true;
            this.Knjiga_radioButton.Location = new System.Drawing.Point(112, 10);
            this.Knjiga_radioButton.Name = "Knjiga_radioButton";
            this.Knjiga_radioButton.Size = new System.Drawing.Size(60, 19);
            this.Knjiga_radioButton.TabIndex = 1;
            this.Knjiga_radioButton.TabStop = true;
            this.Knjiga_radioButton.Text = "Knjiga";
            this.Knjiga_radioButton.UseVisualStyleBackColor = true;
            this.Knjiga_radioButton.CheckedChanged += new System.EventHandler(this.Knjiga_radioButton_CheckedChanged);
            // 
            // Clan_radioButton
            // 
            this.Clan_radioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clan_radioButton.AutoSize = true;
            this.Clan_radioButton.Location = new System.Drawing.Point(22, 10);
            this.Clan_radioButton.Name = "Clan_radioButton";
            this.Clan_radioButton.Size = new System.Drawing.Size(50, 19);
            this.Clan_radioButton.TabIndex = 0;
            this.Clan_radioButton.TabStop = true;
            this.Clan_radioButton.Text = "Član";
            this.Clan_radioButton.UseVisualStyleBackColor = true;
            this.Clan_radioButton.CheckedChanged += new System.EventHandler(this.Clan_radioButton_CheckedChanged);
            // 
            // Unos_tableLayoutPanel
            // 
            this.Unos_tableLayoutPanel.ColumnCount = 2;
            this.Unos_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.36426F));
            this.Unos_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.63574F));
            this.Unos_tableLayoutPanel.Controls.Add(this.textBox2, 1, 1);
            this.Unos_tableLayoutPanel.Controls.Add(this.label4, 0, 3);
            this.Unos_tableLayoutPanel.Controls.Add(this.label3, 0, 2);
            this.Unos_tableLayoutPanel.Controls.Add(this.label2, 0, 1);
            this.Unos_tableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.Unos_tableLayoutPanel.Controls.Add(this.textBox1, 1, 0);
            this.Unos_tableLayoutPanel.Controls.Add(this.textBox3, 1, 2);
            this.Unos_tableLayoutPanel.Controls.Add(this.dateTimePicker, 1, 3);
            this.Unos_tableLayoutPanel.Location = new System.Drawing.Point(12, 75);
            this.Unos_tableLayoutPanel.Name = "Unos_tableLayoutPanel";
            this.Unos_tableLayoutPanel.RowCount = 4;
            this.Unos_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Unos_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Unos_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Unos_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Unos_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Unos_tableLayoutPanel.Size = new System.Drawing.Size(291, 219);
            this.Unos_tableLayoutPanel.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(103, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 21);
            this.textBox2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 57);
            this.label4.TabIndex = 6;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 54);
            this.label3.TabIndex = 4;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 54);
            this.label2.TabIndex = 2;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 54);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(103, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 21);
            this.textBox1.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(103, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(185, 21);
            this.textBox3.TabIndex = 10;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker.CustomFormat = "dd   -   MMM   -    yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(103, 180);
            this.dateTimePicker.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker.TabIndex = 11;
            this.dateTimePicker.Value = new System.DateTime(2019, 5, 9, 0, 0, 0, 0);
            // 
            // Button_tableLayoutPanel
            // 
            this.Button_tableLayoutPanel.ColumnCount = 1;
            this.Button_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Button_tableLayoutPanel.Controls.Add(this.Pretraga_button, 0, 0);
            this.Button_tableLayoutPanel.Controls.Add(this.Back_button, 0, 1);
            this.Button_tableLayoutPanel.Location = new System.Drawing.Point(12, 300);
            this.Button_tableLayoutPanel.Name = "Button_tableLayoutPanel";
            this.Button_tableLayoutPanel.RowCount = 2;
            this.Button_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Button_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Button_tableLayoutPanel.Size = new System.Drawing.Size(288, 101);
            this.Button_tableLayoutPanel.TabIndex = 3;
            // 
            // Pretraga_button
            // 
            this.Pretraga_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pretraga_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pretraga_button.Location = new System.Drawing.Point(3, 3);
            this.Pretraga_button.Name = "Pretraga_button";
            this.Pretraga_button.Size = new System.Drawing.Size(282, 44);
            this.Pretraga_button.TabIndex = 0;
            this.Pretraga_button.Text = "Pretraži";
            this.Pretraga_button.UseVisualStyleBackColor = true;
            this.Pretraga_button.Click += new System.EventHandler(this.Pretraga_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.Location = new System.Drawing.Point(61, 54);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(166, 42);
            this.Back_button.TabIndex = 1;
            this.Back_button.Text = "Nazad";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Info_label
            // 
            this.Info_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info_label.Location = new System.Drawing.Point(309, 12);
            this.Info_label.Name = "Info_label";
            this.Info_label.Size = new System.Drawing.Size(529, 38);
            this.Info_label.TabIndex = 4;
            this.Info_label.Text = "Petraga:";
            this.Info_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DetaljnaPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 413);
            this.Controls.Add(this.Info_label);
            this.Controls.Add(this.Button_tableLayoutPanel);
            this.Controls.Add(this.Unos_tableLayoutPanel);
            this.Controls.Add(this.RadioButton_groupBox);
            this.Controls.Add(this.Pretraga_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(866, 452);
            this.MinimumSize = new System.Drawing.Size(866, 452);
            this.Name = "DetaljnaPretraga";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detaljna pretraga";
            this.Load += new System.EventHandler(this.DetaljnaPretraga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pretraga_dataGridView)).EndInit();
            this.RadioButton_groupBox.ResumeLayout(false);
            this.RadioButton_tableLayoutPanel.ResumeLayout(false);
            this.RadioButton_tableLayoutPanel.PerformLayout();
            this.Unos_tableLayoutPanel.ResumeLayout(false);
            this.Unos_tableLayoutPanel.PerformLayout();
            this.Button_tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Pretraga_dataGridView;
        private System.Windows.Forms.GroupBox RadioButton_groupBox;
        private System.Windows.Forms.TableLayoutPanel RadioButton_tableLayoutPanel;
        private System.Windows.Forms.RadioButton Clan_radioButton;
        private System.Windows.Forms.RadioButton Pisac_radioButton;
        private System.Windows.Forms.RadioButton Knjiga_radioButton;
        private System.Windows.Forms.TableLayoutPanel Unos_tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel Button_tableLayoutPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button Pretraga_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Label Info_label;
    }
}