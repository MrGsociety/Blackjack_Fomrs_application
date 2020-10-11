namespace blackjack_form_application
{
    partial class Distributor
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
            this.register_panel = new System.Windows.Forms.Panel();
            this.reg_check = new System.Windows.Forms.CheckBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.reg_password_again_txtb = new System.Windows.Forms.TextBox();
            this.reg_password_txtb = new System.Windows.Forms.TextBox();
            this.reg_uname_txtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Panel();
            this.szabalyzat_lbl = new System.Windows.Forms.LinkLabel();
            this.login_as_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.log_check = new System.Windows.Forms.CheckBox();
            this.log_me_in_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.log_password_txtb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.log_username_txtb = new System.Windows.Forms.TextBox();
            this.register_panel.SuspendLayout();
            this.login_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // register_panel
            // 
            this.register_panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.register_panel.Controls.Add(this.reg_check);
            this.register_panel.Controls.Add(this.register_btn);
            this.register_panel.Controls.Add(this.reg_password_again_txtb);
            this.register_panel.Controls.Add(this.reg_password_txtb);
            this.register_panel.Controls.Add(this.reg_uname_txtb);
            this.register_panel.Controls.Add(this.label4);
            this.register_panel.Controls.Add(this.label3);
            this.register_panel.Controls.Add(this.label2);
            this.register_panel.Controls.Add(this.label1);
            this.register_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.register_panel.Location = new System.Drawing.Point(0, 0);
            this.register_panel.Name = "register_panel";
            this.register_panel.Size = new System.Drawing.Size(452, 629);
            this.register_panel.TabIndex = 0;
            // 
            // reg_check
            // 
            this.reg_check.AutoSize = true;
            this.reg_check.CausesValidation = false;
            this.reg_check.Font = new System.Drawing.Font("Elephant", 9F);
            this.reg_check.Location = new System.Drawing.Point(91, 374);
            this.reg_check.Name = "reg_check";
            this.reg_check.Size = new System.Drawing.Size(259, 20);
            this.reg_check.TabIndex = 8;
            this.reg_check.Text = "Elolvastam és elfogadom a szabályzatot";
            this.reg_check.UseVisualStyleBackColor = true;
            this.reg_check.CheckedChanged += new System.EventHandler(this.reg_check_CheckedChanged);
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.register_btn.Enabled = false;
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.register_btn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.register_btn.Location = new System.Drawing.Point(122, 407);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(151, 32);
            this.register_btn.TabIndex = 7;
            this.register_btn.Text = "Regisztrálok";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // reg_password_again_txtb
            // 
            this.reg_password_again_txtb.AcceptsReturn = true;
            this.reg_password_again_txtb.AcceptsTab = true;
            this.reg_password_again_txtb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reg_password_again_txtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reg_password_again_txtb.CausesValidation = false;
            this.reg_password_again_txtb.Location = new System.Drawing.Point(186, 337);
            this.reg_password_again_txtb.Name = "reg_password_again_txtb";
            this.reg_password_again_txtb.Size = new System.Drawing.Size(128, 20);
            this.reg_password_again_txtb.TabIndex = 6;
            this.reg_password_again_txtb.TextChanged += new System.EventHandler(this.reg_password_again_txtb_TextChanged);
            // 
            // reg_password_txtb
            // 
            this.reg_password_txtb.AcceptsReturn = true;
            this.reg_password_txtb.AcceptsTab = true;
            this.reg_password_txtb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reg_password_txtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reg_password_txtb.CausesValidation = false;
            this.reg_password_txtb.Location = new System.Drawing.Point(186, 287);
            this.reg_password_txtb.Name = "reg_password_txtb";
            this.reg_password_txtb.Size = new System.Drawing.Size(128, 20);
            this.reg_password_txtb.TabIndex = 5;
            this.reg_password_txtb.TextChanged += new System.EventHandler(this.reg_password_txtb_TextChanged);
            // 
            // reg_uname_txtb
            // 
            this.reg_uname_txtb.AcceptsReturn = true;
            this.reg_uname_txtb.AcceptsTab = true;
            this.reg_uname_txtb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reg_uname_txtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reg_uname_txtb.CausesValidation = false;
            this.reg_uname_txtb.Location = new System.Drawing.Point(186, 240);
            this.reg_uname_txtb.Name = "reg_uname_txtb";
            this.reg_uname_txtb.Size = new System.Drawing.Size(128, 20);
            this.reg_uname_txtb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jelszó ismét:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jelszó:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Felhasználónév:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Regisztráció";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.login_btn.Controls.Add(this.szabalyzat_lbl);
            this.login_btn.Controls.Add(this.login_as_btn);
            this.login_btn.Controls.Add(this.exit_btn);
            this.login_btn.Controls.Add(this.log_check);
            this.login_btn.Controls.Add(this.log_me_in_btn);
            this.login_btn.Controls.Add(this.label8);
            this.login_btn.Controls.Add(this.label7);
            this.login_btn.Controls.Add(this.log_password_txtb);
            this.login_btn.Controls.Add(this.label6);
            this.login_btn.Controls.Add(this.log_username_txtb);
            this.login_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.login_btn.Location = new System.Drawing.Point(582, 0);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(498, 629);
            this.login_btn.TabIndex = 1;
            // 
            // szabalyzat_lbl
            // 
            this.szabalyzat_lbl.ActiveLinkColor = System.Drawing.Color.Maroon;
            this.szabalyzat_lbl.AutoSize = true;
            this.szabalyzat_lbl.BackColor = System.Drawing.Color.Blue;
            this.szabalyzat_lbl.LinkColor = System.Drawing.Color.Red;
            this.szabalyzat_lbl.Location = new System.Drawing.Point(431, 9);
            this.szabalyzat_lbl.Name = "szabalyzat_lbl";
            this.szabalyzat_lbl.Size = new System.Drawing.Size(58, 13);
            this.szabalyzat_lbl.TabIndex = 19;
            this.szabalyzat_lbl.TabStop = true;
            this.szabalyzat_lbl.Text = "Szabályzat";
            this.szabalyzat_lbl.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.szabalyzat_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.szabalyzat_lbl_LinkClicked);
            // 
            // login_as_btn
            // 
            this.login_as_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.login_as_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_as_btn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_as_btn.Location = new System.Drawing.Point(3, 388);
            this.login_as_btn.Name = "login_as_btn";
            this.login_as_btn.Size = new System.Drawing.Size(492, 32);
            this.login_as_btn.TabIndex = 18;
            this.login_as_btn.UseVisualStyleBackColor = false;
            this.login_as_btn.Click += new System.EventHandler(this.login_as_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_btn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit_btn.Location = new System.Drawing.Point(386, 579);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(109, 47);
            this.exit_btn.TabIndex = 17;
            this.exit_btn.Text = "Kilépés";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // log_check
            // 
            this.log_check.AutoSize = true;
            this.log_check.CausesValidation = false;
            this.log_check.Font = new System.Drawing.Font("Elephant", 9F);
            this.log_check.Location = new System.Drawing.Point(140, 318);
            this.log_check.Name = "log_check";
            this.log_check.Size = new System.Drawing.Size(259, 20);
            this.log_check.TabIndex = 9;
            this.log_check.Text = "Elolvastam és elfogadom a szabályzatot";
            this.log_check.UseVisualStyleBackColor = true;
            this.log_check.CheckedChanged += new System.EventHandler(this.log_check_CheckedChanged);
            // 
            // log_me_in_btn
            // 
            this.log_me_in_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.log_me_in_btn.Enabled = false;
            this.log_me_in_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.log_me_in_btn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.log_me_in_btn.Location = new System.Drawing.Point(179, 350);
            this.log_me_in_btn.Name = "log_me_in_btn";
            this.log_me_in_btn.Size = new System.Drawing.Size(151, 32);
            this.log_me_in_btn.TabIndex = 15;
            this.log_me_in_btn.Text = "Belépés";
            this.log_me_in_btn.UseVisualStyleBackColor = false;
            this.log_me_in_btn.Click += new System.EventHandler(this.log_me_in_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(185, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 27);
            this.label8.TabIndex = 8;
            this.label8.Text = "Bejelentkezés";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(125, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Felhasználónév:";
            // 
            // log_password_txtb
            // 
            this.log_password_txtb.AcceptsReturn = true;
            this.log_password_txtb.AcceptsTab = true;
            this.log_password_txtb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.log_password_txtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.log_password_txtb.CausesValidation = false;
            this.log_password_txtb.Location = new System.Drawing.Point(243, 283);
            this.log_password_txtb.Name = "log_password_txtb";
            this.log_password_txtb.Size = new System.Drawing.Size(128, 20);
            this.log_password_txtb.TabIndex = 13;
            this.log_password_txtb.TextChanged += new System.EventHandler(this.log_password_txtb_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(153, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Jelszó:";
            // 
            // log_username_txtb
            // 
            this.log_username_txtb.AcceptsReturn = true;
            this.log_username_txtb.AcceptsTab = true;
            this.log_username_txtb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.log_username_txtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.log_username_txtb.CausesValidation = false;
            this.log_username_txtb.Location = new System.Drawing.Point(243, 240);
            this.log_username_txtb.Name = "log_username_txtb";
            this.log_username_txtb.Size = new System.Drawing.Size(128, 20);
            this.log_username_txtb.TabIndex = 12;
            // 
            // Distributor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 629);
            this.ControlBox = false;
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.register_panel);
            this.Name = "Distributor";
            this.Opacity = 0.94D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Mr. Lucky Blackjack";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Distributor_Load);
            this.register_panel.ResumeLayout(false);
            this.register_panel.PerformLayout();
            this.login_btn.ResumeLayout(false);
            this.login_btn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel register_panel;
        private System.Windows.Forms.Panel login_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reg_password_again_txtb;
        private System.Windows.Forms.TextBox reg_password_txtb;
        private System.Windows.Forms.TextBox reg_uname_txtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Button log_me_in_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox log_password_txtb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox log_username_txtb;
        private System.Windows.Forms.CheckBox reg_check;
        private System.Windows.Forms.CheckBox log_check;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button login_as_btn;
        private System.Windows.Forms.LinkLabel szabalyzat_lbl;
    }
}

