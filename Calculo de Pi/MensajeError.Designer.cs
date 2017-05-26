namespace Calculo_de_Pi
{
    partial class MensajeError
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
            this.lmerror = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lmerror
            // 
            this.lmerror.AutoSize = true;
            this.lmerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmerror.Location = new System.Drawing.Point(12, 22);
            this.lmerror.Name = "lmerror";
            this.lmerror.Size = new System.Drawing.Size(294, 15);
            this.lmerror.TabIndex = 0;
            this.lmerror.Text = "Error, ya se esta calculando pi esperar a que termine";
            // 
            // MensajeError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 77);
            this.Controls.Add(this.lmerror);
            this.Name = "MensajeError";
            this.Text = "Mensaje de Error";
            this.Load += new System.EventHandler(this.MensajeError_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lmerror;
    }
}