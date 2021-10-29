using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppS2PBlacio
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private void btnResultado_Clicked(object sender, EventArgs e)
        {
            try
            {
                double NotaUno = Convert.ToDouble(txtS1.Text);
                double ExamenUno = Convert.ToDouble(txtE1.Text);

                double Nf1 = NotaUno * 0.3;
                double Ef1 = ExamenUno * 0.2;

                double suma = Nf1 + Ef1;
                txtP1.Text = Convert.ToString(suma);

                double NotaDos = Convert.ToDouble(txtS2.Text);
                double ExamenDos = Convert.ToDouble(txtE2.Text);

                double Nf2 = NotaDos * 0.3;
                double Ef2 = ExamenDos * 0.2;

                double suma2 = Nf2 + Ef2;
                txtP2.Text = Convert.ToString(suma2);

                double NotaFinal = suma + suma2;
                txtNf.Text = Convert.ToString(NotaFinal);

                if (NotaFinal >= 7)
                {
                    txtEstado.Text = Convert.ToString("Aprobado");
                    txtEstado.TextColor = Color.Green;
                }
                else if (NotaFinal >=5)
                {
                    txtEstado.Text = Convert.ToString("Complementario");
                    txtEstado.TextColor = Color.Orange;
                }

                else
                {
                    txtEstado.Text = Convert.ToString("Reprobado");
                    txtEstado.TextColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Advertencia", ex.Message, "OK");
            }
        }
    }
}
