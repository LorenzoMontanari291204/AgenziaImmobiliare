namespace AgenziaImmobiliare
{
    partial class frmStampaImmobile
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
            this.lblBox = new System.Windows.Forms.Label();
            this.lblAppartamento = new System.Windows.Forms.Label();
            this.lblVilla = new System.Windows.Forms.Label();
            this.btnStampaBox = new System.Windows.Forms.Button();
            this.listBoxBox = new System.Windows.Forms.ListBox();
            this.listBoxAppartamenti = new System.Windows.Forms.ListBox();
            this.listBoxVille = new System.Windows.Forms.ListBox();
            this.btnStampaAppartamenti = new System.Windows.Forms.Button();
            this.btnStampaVille = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBox
            // 
            this.lblBox.AutoSize = true;
            this.lblBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblBox.Location = new System.Drawing.Point(12, 28);
            this.lblBox.Name = "lblBox";
            this.lblBox.Size = new System.Drawing.Size(29, 17);
            this.lblBox.TabIndex = 0;
            this.lblBox.Text = "Box";
            // 
            // lblAppartamento
            // 
            this.lblAppartamento.AutoSize = true;
            this.lblAppartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblAppartamento.Location = new System.Drawing.Point(12, 168);
            this.lblAppartamento.Name = "lblAppartamento";
            this.lblAppartamento.Size = new System.Drawing.Size(87, 17);
            this.lblAppartamento.TabIndex = 0;
            this.lblAppartamento.Text = "Appartamenti";
            // 
            // lblVilla
            // 
            this.lblVilla.AutoSize = true;
            this.lblVilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblVilla.Location = new System.Drawing.Point(12, 335);
            this.lblVilla.Name = "lblVilla";
            this.lblVilla.Size = new System.Drawing.Size(32, 17);
            this.lblVilla.TabIndex = 0;
            this.lblVilla.Text = "Ville";
            // 
            // btnStampaBox
            // 
            this.btnStampaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStampaBox.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStampaBox.Location = new System.Drawing.Point(827, 12);
            this.btnStampaBox.Name = "btnStampaBox";
            this.btnStampaBox.Size = new System.Drawing.Size(195, 33);
            this.btnStampaBox.TabIndex = 1;
            this.btnStampaBox.Text = "VISUALIZZA BOX";
            this.btnStampaBox.UseVisualStyleBackColor = false;
            this.btnStampaBox.Click += new System.EventHandler(this.btnStampaBox_Click);
            // 
            // listBoxBox
            // 
            this.listBoxBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBoxBox.FormattingEnabled = true;
            this.listBoxBox.ItemHeight = 17;
            this.listBoxBox.Location = new System.Drawing.Point(2, 51);
            this.listBoxBox.Name = "listBoxBox";
            this.listBoxBox.Size = new System.Drawing.Size(1020, 89);
            this.listBoxBox.TabIndex = 2;
            // 
            // listBoxAppartamenti
            // 
            this.listBoxAppartamenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBoxAppartamenti.FormattingEnabled = true;
            this.listBoxAppartamenti.ItemHeight = 17;
            this.listBoxAppartamenti.Location = new System.Drawing.Point(2, 199);
            this.listBoxAppartamenti.Name = "listBoxAppartamenti";
            this.listBoxAppartamenti.Size = new System.Drawing.Size(1020, 89);
            this.listBoxAppartamenti.TabIndex = 2;
            // 
            // listBoxVille
            // 
            this.listBoxVille.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listBoxVille.FormattingEnabled = true;
            this.listBoxVille.ItemHeight = 17;
            this.listBoxVille.Location = new System.Drawing.Point(2, 358);
            this.listBoxVille.Name = "listBoxVille";
            this.listBoxVille.Size = new System.Drawing.Size(1020, 89);
            this.listBoxVille.TabIndex = 2;
            // 
            // btnStampaAppartamenti
            // 
            this.btnStampaAppartamenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStampaAppartamenti.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStampaAppartamenti.Location = new System.Drawing.Point(827, 160);
            this.btnStampaAppartamenti.Name = "btnStampaAppartamenti";
            this.btnStampaAppartamenti.Size = new System.Drawing.Size(195, 32);
            this.btnStampaAppartamenti.TabIndex = 3;
            this.btnStampaAppartamenti.Text = "VISUALIZZA APPARTAMENTI";
            this.btnStampaAppartamenti.UseVisualStyleBackColor = false;
            this.btnStampaAppartamenti.Click += new System.EventHandler(this.btnStampaAppartamenti_Click);
            // 
            // btnStampaVille
            // 
            this.btnStampaVille.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStampaVille.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStampaVille.Location = new System.Drawing.Point(827, 319);
            this.btnStampaVille.Name = "btnStampaVille";
            this.btnStampaVille.Size = new System.Drawing.Size(195, 33);
            this.btnStampaVille.TabIndex = 4;
            this.btnStampaVille.Text = "VISUALIZZA VILLE";
            this.btnStampaVille.UseVisualStyleBackColor = false;
            this.btnStampaVille.Click += new System.EventHandler(this.btnStampaVille_Click);
            // 
            // frmStampaImmobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1034, 459);
            this.Controls.Add(this.btnStampaVille);
            this.Controls.Add(this.btnStampaAppartamenti);
            this.Controls.Add(this.listBoxVille);
            this.Controls.Add(this.listBoxAppartamenti);
            this.Controls.Add(this.listBoxBox);
            this.Controls.Add(this.btnStampaBox);
            this.Controls.Add(this.lblVilla);
            this.Controls.Add(this.lblAppartamento);
            this.Controls.Add(this.lblBox);
            this.Name = "frmStampaImmobile";
            this.Text = "frmStampaImmobile";
            this.Load += new System.EventHandler(this.frmStampaImmobile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBox;
        private System.Windows.Forms.Label lblAppartamento;
        private System.Windows.Forms.Label lblVilla;
        private System.Windows.Forms.Button btnStampaBox;
        private System.Windows.Forms.ListBox listBoxBox;
        private System.Windows.Forms.ListBox listBoxAppartamenti;
        private System.Windows.Forms.ListBox listBoxVille;
        private System.Windows.Forms.Button btnStampaAppartamenti;
        private System.Windows.Forms.Button btnStampaVille;
    }
}