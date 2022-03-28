using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmAguarde : Form
    {
        public FrmAguarde()
        {
            InitializeComponent();
        }

        CancellationTokenSource tokenSource = new CancellationTokenSource();

        async Task PausaComTaskDelay()
        {
            await Task.Delay(5000, tokenSource.Token);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PausaComTaskDelay();

            //FrmMenu frmPrincipal = new FrmMenu();
            //frmPrincipal.Show(); // abre o form principal
            //timer1.Stop();       // para o relógio
            //this.Close();         //fecha a janela após completar os 100%

        }
    }
}
