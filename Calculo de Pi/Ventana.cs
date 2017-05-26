using System;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace Calculo_de_Pi
{
    public partial class Ventana : Form
    {
        public Thread calc;
        public Pi picls;
        public int isset;
        public Ventana()
        {
            InitializeComponent();
        }

        ~Ventana()
        {
            if (!calc.IsAlive)
            {
                calc.Join();
            }
        }

        public void calculo()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            
            this.lresult.Text = "";
            picls = new Pi();
            string sNumero = this.textNro.Text;
            int iNumero = picls.convertiraint(sNumero);
            string sTol = this.textTol.Text;
            double dTol = picls.convertiradouble(sTol);
            double valor = 0.0;
            pBpi.Minimum = 0;
            pBpi.Maximum = iNumero;
            pBpi.Value = 0;
            if (iNumero != -1 && dTol != -1)
            {
                if (this.rtaylor.Checked == true)
                {
                    valor = picls.calc_pi(iNumero, pBpi);
                }
                else if (this.rpfijo.Checked == true)
                {
                    valor = picls.calculo_de_pi3(iNumero, pBpi, dTol);
                }
                else if (this.rnewton.Checked == true)
                {
                    valor = picls.calculo_de_pi3(iNumero, pBpi, dTol);
                }
                this.lresult.Text = Convert.ToString(valor);

                stopWatch.Stop();
                // Get the elapsed time as a TimeSpan value.
                TimeSpan ts = stopWatch.Elapsed;
                this.lrestiempo.Text = Convert.ToString(ts.TotalSeconds)+" seg";
            }
            else
            {
                this.lresult.Text = "Error: valores invalidos";
                stopWatch.Stop();
            }
        }

        private void resetear(EventArgs e)
        {
            this.textNro.Text = "1";
            this.textTol.Text = "1e-05";
            this.isset = 0;
            this.rtaylor.Checked = true;
            this.OnCheckedChanged(e);
            this.lresult.Text = "";
            this.pBpi.Value = 0;
            this.lrestiempo.Text = "";
        }

        private void Ventana_Load(object sender, EventArgs e)
        {
            this.resetear(e);
        }

        private void lcalcular_Click(object sender, EventArgs e)
        {
            if (isset == 0)
            {
                calc = new Thread(new ThreadStart(this.calculo));
                isset = 1;
            } 
            if (!calc.IsAlive)
            {
                if (isset == 1)
                {
                    calc = new Thread(new ThreadStart(this.calculo));
                }
                int result = 0;
                try
                {
                    calc.Start();
                }
                catch (ThreadStateException ex)
                {
                    Console.WriteLine(ex);  // Display text of exception
                    result = 1;            // Result says there was an error
                }
                catch (ThreadInterruptedException ex)
                {
                    Console.WriteLine(ex);  // This exception means that the thread
                                           // was interrupted during a Wait
                    result = 1;            // Result says there was an error
                }
                Environment.ExitCode = result;
            }
            else
            {
                MensajeError errm = new MensajeError();
                errm.Show();
            }
        }

        private void lresult_textChanged(object sender, EventArgs e)
        {
            if (!calc.IsAlive && (this.lresult.Text != ""))
            {
                calc.Join();
            }
        }

        private void OnCheckedChanged(EventArgs e)
        {
            if (this.rtaylor.Checked)
            {
                this.ltol.Visible = false;
                this.textTol.Visible = false;
            }
            else
            {
                this.ltol.Visible = true;
                this.textTol.Visible = true;
            }
        }

        private void rtaylor_CheckedChanged(object sender, EventArgs e)
        {
            this.OnCheckedChanged(e);
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            this.resetear(e);
        }
    }
}
