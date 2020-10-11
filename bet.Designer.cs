namespace blackjack_form_application
{
    partial class bet
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
            this.usercontrol_panel = new System.Windows.Forms.Panel();
            this.buybet_btn = new System.Windows.Forms.Button();
            this.getbet_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.money_lbl = new System.Windows.Forms.Label();
            this.zsetnyon_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usercontrol_panel
            // 
            this.usercontrol_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.usercontrol_panel.Location = new System.Drawing.Point(453, 0);
            this.usercontrol_panel.Name = "usercontrol_panel";
            this.usercontrol_panel.Size = new System.Drawing.Size(627, 629);
            this.usercontrol_panel.TabIndex = 1;
            // 
            // buybet_btn
            // 
            this.buybet_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buybet_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buybet_btn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buybet_btn.Location = new System.Drawing.Point(109, 113);
            this.buybet_btn.Name = "buybet_btn";
            this.buybet_btn.Size = new System.Drawing.Size(220, 42);
            this.buybet_btn.TabIndex = 16;
            this.buybet_btn.Text = "Zseton vásárlás";
            this.buybet_btn.UseVisualStyleBackColor = false;
            this.buybet_btn.Click += new System.EventHandler(this.buybet_btn_Click);
            // 
            // getbet_btn
            // 
            this.getbet_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.getbet_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getbet_btn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.getbet_btn.Location = new System.Drawing.Point(109, 282);
            this.getbet_btn.Name = "getbet_btn";
            this.getbet_btn.Size = new System.Drawing.Size(220, 42);
            this.getbet_btn.TabIndex = 17;
            this.getbet_btn.Text = "Zseton beváltás";
            this.getbet_btn.UseVisualStyleBackColor = false;
            this.getbet_btn.Click += new System.EventHandler(this.getbet_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_btn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit_btn.Location = new System.Drawing.Point(109, 459);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(220, 42);
            this.exit_btn.TabIndex = 18;
            this.exit_btn.Text = "Kilépés";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arbutus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(407, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 42);
            this.button1.TabIndex = 19;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // money_lbl
            // 
            this.money_lbl.AutoSize = true;
            this.money_lbl.Location = new System.Drawing.Point(13, 13);
            this.money_lbl.Name = "money_lbl";
            this.money_lbl.Size = new System.Drawing.Size(31, 13);
            this.money_lbl.TabIndex = 20;
            this.money_lbl.Text = "Pénz";
            // 
            // zsetnyon_lbl
            // 
            this.zsetnyon_lbl.AutoSize = true;
            this.zsetnyon_lbl.Location = new System.Drawing.Point(383, 13);
            this.zsetnyon_lbl.Name = "zsetnyon_lbl";
            this.zsetnyon_lbl.Size = new System.Drawing.Size(40, 13);
            this.zsetnyon_lbl.TabIndex = 21;
            this.zsetnyon_lbl.Text = "Zseton";
            // 
            // bet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 629);
            this.ControlBox = false;
            this.Controls.Add(this.zsetnyon_lbl);
            this.Controls.Add(this.money_lbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.getbet_btn);
            this.Controls.Add(this.buybet_btn);
            this.Controls.Add(this.usercontrol_panel);
            this.Name = "bet";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Mr. Lucky Zseton vétel";
            this.Load += new System.EventHandler(this.bet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel usercontrol_panel;
        private System.Windows.Forms.Button buybet_btn;
        private System.Windows.Forms.Button getbet_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label money_lbl;
        private System.Windows.Forms.Label zsetnyon_lbl;
    }
}