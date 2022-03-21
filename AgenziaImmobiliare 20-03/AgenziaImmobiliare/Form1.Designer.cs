namespace AgenziaImmobiliare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddBox = new System.Windows.Forms.Button();
            this.btnAddAppartamento = new System.Windows.Forms.Button();
            this.btnAddVilla = new System.Windows.Forms.Button();
            this.btnRicercaImmobile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVisualizzaImmobili = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddBox
            // 
            this.btnAddBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddBox.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddBox.Location = new System.Drawing.Point(51, 53);
            this.btnAddBox.Name = "btnAddBox";
            this.btnAddBox.Size = new System.Drawing.Size(200, 85);
            this.btnAddBox.TabIndex = 0;
            this.btnAddBox.Text = "AGGIUNGI BOX";
            this.btnAddBox.UseVisualStyleBackColor = false;
            this.btnAddBox.Click += new System.EventHandler(this.btnAddBox_Click);
            // 
            // btnAddAppartamento
            // 
            this.btnAddAppartamento.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddAppartamento.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddAppartamento.Location = new System.Drawing.Point(332, 53);
            this.btnAddAppartamento.Name = "btnAddAppartamento";
            this.btnAddAppartamento.Size = new System.Drawing.Size(200, 85);
            this.btnAddAppartamento.TabIndex = 0;
            this.btnAddAppartamento.Text = "AGGIUNGI APPARTAMENTO";
            this.btnAddAppartamento.UseVisualStyleBackColor = false;
            this.btnAddAppartamento.Click += new System.EventHandler(this.btnAddAppartamento_Click);
            // 
            // btnAddVilla
            // 
            this.btnAddVilla.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddVilla.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddVilla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddVilla.Location = new System.Drawing.Point(604, 53);
            this.btnAddVilla.Name = "btnAddVilla";
            this.btnAddVilla.Size = new System.Drawing.Size(200, 85);
            this.btnAddVilla.TabIndex = 0;
            this.btnAddVilla.Text = "AGGIUNGI VILLA";
            this.btnAddVilla.UseVisualStyleBackColor = false;
            this.btnAddVilla.Click += new System.EventHandler(this.btnAddVilla_Click);
            // 
            // btnRicercaImmobile
            // 
            this.btnRicercaImmobile.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRicercaImmobile.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRicercaImmobile.Location = new System.Drawing.Point(160, 242);
            this.btnRicercaImmobile.Name = "btnRicercaImmobile";
            this.btnRicercaImmobile.Size = new System.Drawing.Size(185, 87);
            this.btnRicercaImmobile.TabIndex = 1;
            this.btnRicercaImmobile.Text = "RICERCA IMMOBILE";
            this.btnRicercaImmobile.UseVisualStyleBackColor = false;
            this.btnRicercaImmobile.Click += new System.EventHandler(this.btnRicercaImmobile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(8, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "\r\n";
            // 
            // btnVisualizzaImmobili
            // 
            this.btnVisualizzaImmobili.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnVisualizzaImmobili.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVisualizzaImmobili.Location = new System.Drawing.Point(511, 242);
            this.btnVisualizzaImmobili.Name = "btnVisualizzaImmobili";
            this.btnVisualizzaImmobili.Size = new System.Drawing.Size(185, 87);
            this.btnVisualizzaImmobili.TabIndex = 3;
            this.btnVisualizzaImmobili.Text = "VISUALIZZA IMMOBILI";
            this.btnVisualizzaImmobili.UseVisualStyleBackColor = false;
            this.btnVisualizzaImmobili.Click += new System.EventHandler(this.btnVisualizzaImmobili_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(864, 459);
            this.Controls.Add(this.btnVisualizzaImmobili);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRicercaImmobile);
            this.Controls.Add(this.btnAddVilla);
            this.Controls.Add(this.btnAddAppartamento);
            this.Controls.Add(this.btnAddBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddBox;
        private System.Windows.Forms.Button btnAddAppartamento;
        private System.Windows.Forms.Button btnAddVilla;
        private System.Windows.Forms.Button btnRicercaImmobil;
        private System.Windows.Forms.Button btnRicercaImmobile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVisualizzaImmobili;
    }
}

