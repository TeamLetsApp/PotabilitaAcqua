using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MetodiLibrary;

namespace AcquaWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        bool f1;
        bool f2;
        bool f3;
        bool f4;
        bool f5;
        bool f6;
        bool f7;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lblresult.Content = "";
            try
            {
                double t = double.Parse(temperatura.Text);
                bool rispT = Metodi.ControlloTemperatura(t);
                if (rispT == true)
                {
                    lblresult.Content += "Temperatura : si \n";
                     f1 = true;
                }
                else
                {
                    lblresult.Content += "Temperatura : no \n";
                     f1 = false;
                }
                double p = double.Parse(ph.Text);
                bool rispP = Metodi.ControlloPh(p);
                if (rispP == true)
                {
                    lblresult.Content += "Ph : si \n";
                     f2 = true;
                }
                else
                {
                    lblresult.Content += "Ph : no \n";
                    f2 = false;
                }
                double r = double.Parse(residuo.Text);
                double l1 = double.Parse(litri.Text);
                bool rispR = Metodi.ControlloResiduo(r, l1);
                if (rispR == true)
                {
                    lblresult.Content += "Residuo : si \n";
                     f3 = true;
                }
                else
                {
                    lblresult.Content += "Residuo : no  \n";
                    f3 = false;

                }
                double a = double.Parse(ammoniaca.Text);
                double l2 = double.Parse(litri.Text);
                bool rispA = Metodi.ControlloAmmoniaca(a, l2);
                if (rispA == true)
                {
                    lblresult.Content += "Ammoniaca : si \n";
                     f4 = true;
                }
                else
                {
                    lblresult.Content += "Ammoniaca : no \n";
                     f4 = false;
                }
                double ni = double.Parse(nitriti.Text);
                bool rispNi = Metodi.ControlloNitriti(ni);
                if (rispNi == true)
                {
                    lblresult.Content += "Nitriti : si \n";
                     f5 = true;
                }
                else
                {
                    lblresult.Content += "Nitriti : no \n";
                     f5 = false;
                }
                double na = double.Parse(nitrati.Text);
                double l3 = double.Parse(litri.Text);
                bool rispNa = Metodi.ControlloNitrati(na, l3);
                if (rispNa == true)
                {
                    lblresult.Content += "Nitrati : si \n";
                     f6 = true;
                }
                else
                {
                    lblresult.Content += "Nitrati : no \n";
                     f6 = false;
                }
                double c = double.Parse(cloruri.Text);
                double l4 = double.Parse(litri.Text);
                bool rispC = Metodi.ControlloCloruri(a, l4);
                if (rispC == true)
                {
                    lblresult.Content += "Cloruri : si \n";
                     f7 = true;
                }
                else
                {
                    lblresult.Content += "Cloruri : no \n";
                     f7 = false;
                }
            }
            catch
            {
                MessageBox.Show("Devi riempire tutti i campi con valori numerici", "ERRORE", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                ph.Text = " ph";
                cloruri.Text = "cloruri(mg/l)";
                nitrati.Text = "nitrati(mg/l)";
                nitriti.Text = "nitriti(mg/l)";
                litri.Text = "litri";
                ammoniaca.Text = "ammoniaca(mg/l)";
                residuo.Text = "residuo(mg/l)";
                temperatura.Text = "temperatura(C°)";
            }
            if(f1&&f2&&f3&&f4&&f5&&f6&&f7==true)
            {
                lblresult.Content += (" \n");
                lblresult.Content += (" \n");
                lblresult.Content += ("L'acqua è potabile");
            }
            else
            {
                lblresult.Content += (" \n");
                lblresult.Content += (" \n");
                lblresult.Content += ("L'acqua non è potabile");
            }
        }

        private void Cloruri_GotMouseCapture(object sender, MouseEventArgs e)
        {
            cloruri.Clear();
        }

        

        private void Nitrati_GotMouseCapture(object sender, MouseEventArgs e)
        {
            nitrati.Clear();
        }

        private void Litri_GotMouseCapture(object sender, MouseEventArgs e)
        {
            litri.Clear();
        }

        private void Nitriti_GotMouseCapture(object sender, MouseEventArgs e)
        {
            nitriti.Clear();
        }

        private void Residuo_GotMouseCapture(object sender, MouseEventArgs e)
        {
            residuo.Clear();
        }

        private void Temperatura_GotMouseCapture(object sender, MouseEventArgs e)
        {
            temperatura.Clear();
        }

        private void Ammoniaca_GotMouseCapture(object sender, MouseEventArgs e)
        {
            ammoniaca.Clear();
        }

        private void Ph_GotMouseCapture(object sender, MouseEventArgs e)
        {
            ph.Clear();
        }
    }
}
