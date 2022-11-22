namespace EdicionDatos
{
    partial class fmAcercaDe
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
            this.laAcercaDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // laAcercaDe
            // 
            this.laAcercaDe.AutoSize = true;
            this.laAcercaDe.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.laAcercaDe.Location = new System.Drawing.Point(127, 125);
            this.laAcercaDe.Name = "laAcercaDe";
            this.laAcercaDe.Size = new System.Drawing.Size(550, 156);
            this.laAcercaDe.TabIndex = 0;
            this.laAcercaDe.Text = "AUTOR: Jesús Ayala Milán\r\nCURSO: 2 DAM Q\r\nPROYECTO: Edición de Datos";
            // 
            // fmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.laAcercaDe);
            this.Name = "fmAcercaDe";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label laAcercaDe;
    }
}