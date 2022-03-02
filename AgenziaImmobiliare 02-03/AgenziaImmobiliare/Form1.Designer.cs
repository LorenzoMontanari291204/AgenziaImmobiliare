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
            this.SuspendLayout();
            // 
            // btnAddBox
            // 
            this.btnAddBox.Location = new System.Drawing.Point(376, 31);
            this.btnAddBox.Name = "btnAddBox";
            this.btnAddBox.Size = new System.Drawing.Size(200, 85);
            this.btnAddBox.TabIndex = 0;
            this.btnAddBox.Text = "AGGIUNGI BOX";
            this.btnAddBox.UseVisualStyleBackColor = true;
            this.btnAddBox.Click += new System.EventHandler(this.btnAddBox_Click);
            // 
            // btnAddAppartamento
            // 
            this.btnAddAppartamento.Location = new System.Drawing.Point(376, 150);
            this.btnAddAppartamento.Name = "btnAddAppartamento";
            this.btnAddAppartamento.Size = new System.Drawing.Size(200, 85);
            this.btnAddAppartamento.TabIndex = 0;
            this.btnAddAppartamento.Text = "AGGIUNGI APPARTAMENTO";
            this.btnAddAppartamento.UseVisualStyleBackColor = true;
            this.btnAddAppartamento.Click += new System.EventHandler(this.btnAddAppartamento_Click);
            // 
            // btnAddVilla
            // 
            this.btnAddVilla.Location = new System.Drawing.Point(376, 257);
            this.btnAddVilla.Name = "btnAddVilla";
            this.btnAddVilla.Size = new System.Drawing.Size(200, 85);
            this.btnAddVilla.TabIndex = 0;
            this.btnAddVilla.Text = "AGGIUNGI VILLA";
            this.btnAddVilla.UseVisualStyleBackColor = true;
            this.btnAddVilla.Click += new System.EventHandler(this.btnAddVilla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 579);
            this.Controls.Add(this.btnAddVilla);
            this.Controls.Add(this.btnAddAppartamento);
            this.Controls.Add(this.btnAddBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddBox;
        private System.Windows.Forms.Button btnAddAppartamento;
        private System.Windows.Forms.Button btnAddVilla;
    }
}

