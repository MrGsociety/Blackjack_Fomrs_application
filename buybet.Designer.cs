namespace blackjack_form_application
{
    partial class buybet
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
            this.label1 = new System.Windows.Forms.Label();
            this.bet_out_txtb = new System.Windows.Forms.TextBox();
            this.bet_out_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hány zsetont szeretnél?";
            // 
            // bet_out_txtb
            // 
            this.bet_out_txtb.Location = new System.Drawing.Point(145, 110);
            this.bet_out_txtb.Name = "bet_out_txtb";
            this.bet_out_txtb.Size = new System.Drawing.Size(158, 20);
            this.bet_out_txtb.TabIndex = 1;
            // 
            // bet_out_btn
            // 
            this.bet_out_btn.Location = new System.Drawing.Point(145, 149);
            this.bet_out_btn.Name = "bet_out_btn";
            this.bet_out_btn.Size = new System.Drawing.Size(75, 23);
            this.bet_out_btn.TabIndex = 2;
            this.bet_out_btn.Text = "Kivétel";
            this.bet_out_btn.UseVisualStyleBackColor = true;
            this.bet_out_btn.Click += new System.EventHandler(this.bet_out_btn_Click);
            // 
            // buybet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bet_out_btn);
            this.Controls.Add(this.bet_out_txtb);
            this.Controls.Add(this.label1);
            this.Name = "buybet";
            this.Size = new System.Drawing.Size(491, 437);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bet_out_txtb;
        private System.Windows.Forms.Button bet_out_btn;



    }
}
