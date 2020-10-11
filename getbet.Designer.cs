namespace blackjack_form_application
{
    partial class getbet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bet_ki_btn = new System.Windows.Forms.Button();
            this.bet_ki_txtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bet_ki_btn
            // 
            this.bet_ki_btn.Location = new System.Drawing.Point(160, 197);
            this.bet_ki_btn.Name = "bet_ki_btn";
            this.bet_ki_btn.Size = new System.Drawing.Size(75, 23);
            this.bet_ki_btn.TabIndex = 5;
            this.bet_ki_btn.Text = "Kivétel";
            this.bet_ki_btn.UseVisualStyleBackColor = true;
            this.bet_ki_btn.Click += new System.EventHandler(this.bet_ki_btn_Click);
            // 
            // bet_ki_txtb
            // 
            this.bet_ki_txtb.Location = new System.Drawing.Point(160, 158);
            this.bet_ki_txtb.Name = "bet_ki_txtb";
            this.bet_ki_txtb.Size = new System.Drawing.Size(158, 20);
            this.bet_ki_txtb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hány forintot szeretnél?";
            // 
            // getbet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bet_ki_btn);
            this.Controls.Add(this.bet_ki_txtb);
            this.Controls.Add(this.label1);
            this.Name = "getbet";
            this.Size = new System.Drawing.Size(491, 437);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bet_ki_btn;
        private System.Windows.Forms.TextBox bet_ki_txtb;
        private System.Windows.Forms.Label label1;
    }
}
