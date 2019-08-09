namespace Klijent
{
    partial class Login
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
            this.login_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.korisnickoIme_label = new System.Windows.Forms.Label();
            this.korisnickoIme_textBox = new System.Windows.Forms.TextBox();
            this.lozinka_label = new System.Windows.Forms.Label();
            this.lozinka_textBox = new System.Windows.Forms.TextBox();
            this.buttons_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.signUp_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.greska_label = new System.Windows.Forms.Label();
            this.login_tableLayoutPanel.SuspendLayout();
            this.buttons_tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_tableLayoutPanel
            // 
            this.login_tableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_tableLayoutPanel.ColumnCount = 2;
            this.login_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.login_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 239F));
            this.login_tableLayoutPanel.Controls.Add(this.korisnickoIme_label, 0, 0);
            this.login_tableLayoutPanel.Controls.Add(this.korisnickoIme_textBox, 1, 0);
            this.login_tableLayoutPanel.Controls.Add(this.lozinka_label, 0, 1);
            this.login_tableLayoutPanel.Controls.Add(this.lozinka_textBox, 1, 1);
            this.login_tableLayoutPanel.Location = new System.Drawing.Point(53, 35);
            this.login_tableLayoutPanel.Name = "login_tableLayoutPanel";
            this.login_tableLayoutPanel.RowCount = 2;
            this.login_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.login_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.login_tableLayoutPanel.Size = new System.Drawing.Size(367, 118);
            this.login_tableLayoutPanel.TabIndex = 0;
            // 
            // korisnickoIme_label
            // 
            this.korisnickoIme_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.korisnickoIme_label.AutoSize = true;
            this.korisnickoIme_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korisnickoIme_label.Location = new System.Drawing.Point(12, 21);
            this.korisnickoIme_label.Name = "korisnickoIme_label";
            this.korisnickoIme_label.Size = new System.Drawing.Size(103, 17);
            this.korisnickoIme_label.TabIndex = 1;
            this.korisnickoIme_label.Text = "Korisničko ime:";
            this.korisnickoIme_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // korisnickoIme_textBox
            // 
            this.korisnickoIme_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.korisnickoIme_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korisnickoIme_textBox.Location = new System.Drawing.Point(131, 18);
            this.korisnickoIme_textBox.Name = "korisnickoIme_textBox";
            this.korisnickoIme_textBox.Size = new System.Drawing.Size(205, 22);
            this.korisnickoIme_textBox.TabIndex = 1;
            // 
            // lozinka_label
            // 
            this.lozinka_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lozinka_label.AutoSize = true;
            this.lozinka_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lozinka_label.Location = new System.Drawing.Point(33, 80);
            this.lozinka_label.Name = "lozinka_label";
            this.lozinka_label.Size = new System.Drawing.Size(61, 17);
            this.lozinka_label.TabIndex = 1;
            this.lozinka_label.Text = "Lozinka:";
            // 
            // lozinka_textBox
            // 
            this.lozinka_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lozinka_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lozinka_textBox.Location = new System.Drawing.Point(131, 77);
            this.lozinka_textBox.Name = "lozinka_textBox";
            this.lozinka_textBox.PasswordChar = '•';
            this.lozinka_textBox.Size = new System.Drawing.Size(205, 22);
            this.lozinka_textBox.TabIndex = 2;
            // 
            // buttons_tableLayoutPanel
            // 
            this.buttons_tableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttons_tableLayoutPanel.ColumnCount = 1;
            this.buttons_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttons_tableLayoutPanel.Controls.Add(this.signUp_button, 0, 1);
            this.buttons_tableLayoutPanel.Controls.Add(this.login_button, 0, 0);
            this.buttons_tableLayoutPanel.Location = new System.Drawing.Point(110, 212);
            this.buttons_tableLayoutPanel.Name = "buttons_tableLayoutPanel";
            this.buttons_tableLayoutPanel.RowCount = 2;
            this.buttons_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.29412F));
            this.buttons_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.70588F));
            this.buttons_tableLayoutPanel.Size = new System.Drawing.Size(282, 85);
            this.buttons_tableLayoutPanel.TabIndex = 1;
            // 
            // signUp_button
            // 
            this.signUp_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUp_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_button.Location = new System.Drawing.Point(90, 51);
            this.signUp_button.Name = "signUp_button";
            this.signUp_button.Size = new System.Drawing.Size(102, 30);
            this.signUp_button.TabIndex = 1;
            this.signUp_button.Text = "Registruj se";
            this.signUp_button.UseVisualStyleBackColor = true;
            this.signUp_button.Click += new System.EventHandler(this.SignUp_button_Click);
            // 
            // login_button
            // 
            this.login_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(44, 5);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(193, 36);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Uloguj se";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // greska_label
            // 
            this.greska_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.greska_label.BackColor = System.Drawing.SystemColors.Control;
            this.greska_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greska_label.ForeColor = System.Drawing.Color.Red;
            this.greska_label.Location = new System.Drawing.Point(110, 156);
            this.greska_label.Name = "greska_label";
            this.greska_label.Size = new System.Drawing.Size(282, 53);
            this.greska_label.TabIndex = 3;
            this.greska_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.greska_label);
            this.Controls.Add(this.buttons_tableLayoutPanel);
            this.Controls.Add(this.login_tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.login_tableLayoutPanel.ResumeLayout(false);
            this.login_tableLayoutPanel.PerformLayout();
            this.buttons_tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel login_tableLayoutPanel;
        private System.Windows.Forms.Label korisnickoIme_label;
        private System.Windows.Forms.Label lozinka_label;
        private System.Windows.Forms.TextBox korisnickoIme_textBox;
        private System.Windows.Forms.TextBox lozinka_textBox;
        private System.Windows.Forms.TableLayoutPanel buttons_tableLayoutPanel;
        private System.Windows.Forms.Button signUp_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label greska_label;
    }
}

