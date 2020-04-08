namespace MonteCarloPI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.baslatButon = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.adimSayisiText = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.sayac = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // baslatButon
            // 
            this.baslatButon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baslatButon.Location = new System.Drawing.Point(12, 74);
            this.baslatButon.Name = "baslatButon";
            this.baslatButon.Size = new System.Drawing.Size(434, 33);
            this.baslatButon.TabIndex = 0;
            this.baslatButon.Text = "Baslat";
            this.baslatButon.UseVisualStyleBackColor = true;
            this.baslatButon.Click += new System.EventHandler(this.baslatButon_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(434, 30);
            this.progressBar1.TabIndex = 2;
            // 
            // adimSayisiText
            // 
            this.adimSayisiText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adimSayisiText.Location = new System.Drawing.Point(12, 48);
            this.adimSayisiText.Name = "adimSayisiText";
            this.adimSayisiText.Size = new System.Drawing.Size(434, 20);
            this.adimSayisiText.TabIndex = 3;
            // 
            // lblSonuc
            // 
            this.lblSonuc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSonuc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(0, 110);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(458, 35);
            this.lblSonuc.TabIndex = 4;
            this.lblSonuc.Text = "Sonuc";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 145);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.adimSayisiText);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.baslatButon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monte Carlo - Pi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button baslatButon;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox adimSayisiText;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Timer sayac;
    }
}

