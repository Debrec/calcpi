namespace Calculo_de_Pi
{
    partial class Ventana
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana));
            this.lnro = new System.Windows.Forms.Label();
            this.rtaylor = new System.Windows.Forms.RadioButton();
            this.rpfijo = new System.Windows.Forms.RadioButton();
            this.rnewton = new System.Windows.Forms.RadioButton();
            this.textNro = new System.Windows.Forms.TextBox();
            this.bcalcular = new System.Windows.Forms.Button();
            this.lresult = new System.Windows.Forms.Label();
            this.textTol = new System.Windows.Forms.TextBox();
            this.ltol = new System.Windows.Forms.Label();
            this.pBpi = new System.Windows.Forms.ProgressBar();
            this.bReset = new System.Windows.Forms.Button();
            this.lPi = new System.Windows.Forms.Label();
            this.ltiempo = new System.Windows.Forms.Label();
            this.lrestiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnro
            // 
            this.lnro.AutoSize = true;
            this.lnro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnro.Location = new System.Drawing.Point(12, 36);
            this.lnro.Name = "lnro";
            this.lnro.Size = new System.Drawing.Size(26, 15);
            this.lnro.TabIndex = 0;
            this.lnro.Text = "Nro";
            // 
            // rtaylor
            // 
            this.rtaylor.AutoSize = true;
            this.rtaylor.Location = new System.Drawing.Point(140, 34);
            this.rtaylor.Name = "rtaylor";
            this.rtaylor.Size = new System.Drawing.Size(54, 17);
            this.rtaylor.TabIndex = 1;
            this.rtaylor.TabStop = true;
            this.rtaylor.Text = "Taylor";
            this.rtaylor.UseVisualStyleBackColor = true;
            this.rtaylor.CheckedChanged += new System.EventHandler(this.rtaylor_CheckedChanged);
            // 
            // rpfijo
            // 
            this.rpfijo.AutoSize = true;
            this.rpfijo.Location = new System.Drawing.Point(140, 57);
            this.rpfijo.Name = "rpfijo";
            this.rpfijo.Size = new System.Drawing.Size(72, 17);
            this.rpfijo.TabIndex = 2;
            this.rpfijo.TabStop = true;
            this.rpfijo.Text = "Punto Fijo";
            this.rpfijo.UseVisualStyleBackColor = true;
            // 
            // rnewton
            // 
            this.rnewton.AutoSize = true;
            this.rnewton.Location = new System.Drawing.Point(140, 80);
            this.rnewton.Name = "rnewton";
            this.rnewton.Size = new System.Drawing.Size(62, 17);
            this.rnewton.TabIndex = 3;
            this.rnewton.TabStop = true;
            this.rnewton.Text = "Newton";
            this.rnewton.UseVisualStyleBackColor = true;
            // 
            // textNro
            // 
            this.textNro.Location = new System.Drawing.Point(48, 34);
            this.textNro.MaxLength = 10;
            this.textNro.Name = "textNro";
            this.textNro.Size = new System.Drawing.Size(79, 20);
            this.textNro.TabIndex = 4;
            // 
            // bcalcular
            // 
            this.bcalcular.Location = new System.Drawing.Point(12, 227);
            this.bcalcular.Name = "bcalcular";
            this.bcalcular.Size = new System.Drawing.Size(75, 23);
            this.bcalcular.TabIndex = 5;
            this.bcalcular.Text = "Calcular";
            this.bcalcular.UseVisualStyleBackColor = true;
            this.bcalcular.Click += new System.EventHandler(this.lcalcular_Click);
            // 
            // lresult
            // 
            this.lresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lresult.Location = new System.Drawing.Point(38, 154);
            this.lresult.Name = "lresult";
            this.lresult.Size = new System.Drawing.Size(191, 18);
            this.lresult.TabIndex = 6;
            // 
            // textTol
            // 
            this.textTol.Location = new System.Drawing.Point(48, 60);
            this.textTol.MaxLength = 6;
            this.textTol.Name = "textTol";
            this.textTol.Size = new System.Drawing.Size(79, 20);
            this.textTol.TabIndex = 7;
            // 
            // ltol
            // 
            this.ltol.AutoSize = true;
            this.ltol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ltol.Location = new System.Drawing.Point(12, 60);
            this.ltol.Name = "ltol";
            this.ltol.Size = new System.Drawing.Size(24, 15);
            this.ltol.TabIndex = 8;
            this.ltol.Text = "Tol";
            // 
            // pBpi
            // 
            this.pBpi.Location = new System.Drawing.Point(12, 113);
            this.pBpi.Name = "pBpi";
            this.pBpi.Size = new System.Drawing.Size(217, 23);
            this.pBpi.TabIndex = 9;
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(102, 226);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(75, 23);
            this.bReset.TabIndex = 10;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // lPi
            // 
            this.lPi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lPi.Location = new System.Drawing.Point(12, 155);
            this.lPi.Name = "lPi";
            this.lPi.Size = new System.Drawing.Size(20, 17);
            this.lPi.TabIndex = 11;
            this.lPi.Text = "Pi";
            // 
            // ltiempo
            // 
            this.ltiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ltiempo.Location = new System.Drawing.Point(12, 187);
            this.ltiempo.Name = "ltiempo";
            this.ltiempo.Size = new System.Drawing.Size(44, 19);
            this.ltiempo.TabIndex = 12;
            this.ltiempo.Text = "Tiempo";
            // 
            // lrestiempo
            // 
            this.lrestiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lrestiempo.Location = new System.Drawing.Point(62, 187);
            this.lrestiempo.MinimumSize = new System.Drawing.Size(80, 0);
            this.lrestiempo.Name = "lrestiempo";
            this.lrestiempo.Size = new System.Drawing.Size(167, 19);
            this.lrestiempo.TabIndex = 13;
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 266);
            this.Controls.Add(this.lrestiempo);
            this.Controls.Add(this.ltiempo);
            this.Controls.Add(this.lPi);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.pBpi);
            this.Controls.Add(this.ltol);
            this.Controls.Add(this.textTol);
            this.Controls.Add(this.lresult);
            this.Controls.Add(this.bcalcular);
            this.Controls.Add(this.textNro);
            this.Controls.Add(this.rnewton);
            this.Controls.Add(this.rpfijo);
            this.Controls.Add(this.rtaylor);
            this.Controls.Add(this.lnro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ventana";
            this.Text = "Cálculo de Pi";
            this.Load += new System.EventHandler(this.Ventana_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lnro;
        private System.Windows.Forms.RadioButton rtaylor;
        private System.Windows.Forms.RadioButton rpfijo;
        private System.Windows.Forms.RadioButton rnewton;
        private System.Windows.Forms.TextBox textNro;
        private System.Windows.Forms.Button bcalcular;
        private System.Windows.Forms.Label lresult;
        private System.Windows.Forms.TextBox textTol;
        private System.Windows.Forms.Label ltol;
        private System.Windows.Forms.ProgressBar pBpi;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Label lPi;
        private System.Windows.Forms.Label ltiempo;
        private System.Windows.Forms.Label lrestiempo;
    }
}

