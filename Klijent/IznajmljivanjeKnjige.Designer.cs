namespace Klijent
{
    partial class IznajmljivanjeKnjige
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
            this.Knjige_dataGridView = new System.Windows.Forms.DataGridView();
            this.IznajmiKnjigu_button = new System.Windows.Forms.Button();
            this.button_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Back_button = new System.Windows.Forms.Button();
            this.greska_label = new System.Windows.Forms.Label();
            this.Clanovi_dataGridView = new System.Windows.Forms.DataGridView();
            this.listaClanova_label = new System.Windows.Forms.Label();
            this.ListaKnjiga_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Knjige_dataGridView)).BeginInit();
            this.button_tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clanovi_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Knjige_dataGridView
            // 
            this.Knjige_dataGridView.AllowUserToAddRows = false;
            this.Knjige_dataGridView.AllowUserToDeleteRows = false;
            this.Knjige_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Knjige_dataGridView.Location = new System.Drawing.Point(420, 44);
            this.Knjige_dataGridView.MultiSelect = false;
            this.Knjige_dataGridView.Name = "Knjige_dataGridView";
            this.Knjige_dataGridView.ReadOnly = true;
            this.Knjige_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Knjige_dataGridView.Size = new System.Drawing.Size(342, 280);
            this.Knjige_dataGridView.TabIndex = 0;
            // 
            // IznajmiKnjigu_button
            // 
            this.IznajmiKnjigu_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IznajmiKnjigu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IznajmiKnjigu_button.Location = new System.Drawing.Point(292, 5);
            this.IznajmiKnjigu_button.Name = "IznajmiKnjigu_button";
            this.IznajmiKnjigu_button.Size = new System.Drawing.Size(165, 49);
            this.IznajmiKnjigu_button.TabIndex = 1;
            this.IznajmiKnjigu_button.Text = "Iznajmi knjigu";
            this.IznajmiKnjigu_button.UseVisualStyleBackColor = true;
            this.IznajmiKnjigu_button.Click += new System.EventHandler(this.IznajmiKnjigu_button_Click);
            // 
            // button_tableLayoutPanel
            // 
            this.button_tableLayoutPanel.ColumnCount = 1;
            this.button_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.button_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.button_tableLayoutPanel.Controls.Add(this.IznajmiKnjigu_button, 0, 0);
            this.button_tableLayoutPanel.Controls.Add(this.Back_button, 0, 1);
            this.button_tableLayoutPanel.Location = new System.Drawing.Point(12, 399);
            this.button_tableLayoutPanel.Name = "button_tableLayoutPanel";
            this.button_tableLayoutPanel.RowCount = 2;
            this.button_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.button_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.button_tableLayoutPanel.Size = new System.Drawing.Size(750, 100);
            this.button_tableLayoutPanel.TabIndex = 2;
            // 
            // Back_button
            // 
            this.Back_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.Location = new System.Drawing.Point(324, 64);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(102, 32);
            this.Back_button.TabIndex = 2;
            this.Back_button.Text = "Nazad";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_Click);
            // 
            // greska_label
            // 
            this.greska_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greska_label.ForeColor = System.Drawing.Color.Red;
            this.greska_label.Location = new System.Drawing.Point(12, 327);
            this.greska_label.Name = "greska_label";
            this.greska_label.Size = new System.Drawing.Size(750, 69);
            this.greska_label.TabIndex = 3;
            this.greska_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Clanovi_dataGridView
            // 
            this.Clanovi_dataGridView.AllowUserToAddRows = false;
            this.Clanovi_dataGridView.AllowUserToDeleteRows = false;
            this.Clanovi_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Clanovi_dataGridView.Location = new System.Drawing.Point(12, 44);
            this.Clanovi_dataGridView.MultiSelect = false;
            this.Clanovi_dataGridView.Name = "Clanovi_dataGridView";
            this.Clanovi_dataGridView.ReadOnly = true;
            this.Clanovi_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Clanovi_dataGridView.Size = new System.Drawing.Size(400, 280);
            this.Clanovi_dataGridView.TabIndex = 4;
            // 
            // listaClanova_label
            // 
            this.listaClanova_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listaClanova_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaClanova_label.Location = new System.Drawing.Point(12, 9);
            this.listaClanova_label.Name = "listaClanova_label";
            this.listaClanova_label.Size = new System.Drawing.Size(400, 32);
            this.listaClanova_label.TabIndex = 5;
            this.listaClanova_label.Text = "Lista članova biblioteke";
            this.listaClanova_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ListaKnjiga_label
            // 
            this.ListaKnjiga_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListaKnjiga_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaKnjiga_label.Location = new System.Drawing.Point(420, 9);
            this.ListaKnjiga_label.Name = "ListaKnjiga_label";
            this.ListaKnjiga_label.Size = new System.Drawing.Size(342, 32);
            this.ListaKnjiga_label.TabIndex = 6;
            this.ListaKnjiga_label.Text = "Lista knjiga";
            this.ListaKnjiga_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IznajmljivanjeKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 511);
            this.Controls.Add(this.ListaKnjiga_label);
            this.Controls.Add(this.listaClanova_label);
            this.Controls.Add(this.Clanovi_dataGridView);
            this.Controls.Add(this.greska_label);
            this.Controls.Add(this.button_tableLayoutPanel);
            this.Controls.Add(this.Knjige_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(790, 550);
            this.MinimumSize = new System.Drawing.Size(790, 550);
            this.Name = "IznajmljivanjeKnjige";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iznajmljivanje knjige";
            this.Load += new System.EventHandler(this.IznajmljivanjeKnjige_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Knjige_dataGridView)).EndInit();
            this.button_tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Clanovi_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Knjige_dataGridView;
        private System.Windows.Forms.Button IznajmiKnjigu_button;
        private System.Windows.Forms.TableLayoutPanel button_tableLayoutPanel;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Label greska_label;
        private System.Windows.Forms.DataGridView Clanovi_dataGridView;
        private System.Windows.Forms.Label listaClanova_label;
        private System.Windows.Forms.Label ListaKnjiga_label;
    }
}