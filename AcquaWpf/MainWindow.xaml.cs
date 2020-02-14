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
            lblresult1.Content = "";
            lblresult2.Content = "";
            lblresult3.Content = "";
            lblresult4.Content = "";
            lblresult5.Content = "";
            lblresult6.Content = "";
            lblresult7.Content = "";
            lblresult8.Content = "";
            try
            {
                double t = double.Parse(temperatura.Text);
                bool rispT = Metodi.ControlloTemperatura(t);
                if (rispT == true)
                {
                    lblresult1.Content += "Temperatura : si \n";
                    lblresult1.Foreground = new SolidColorBrush(Colors.Green);
                    f1 = true;
                }
                else
                {
                    lblresult1.Content += "Temperatura : no \n";
                     f1 = false;
                    lblresult1.Foreground = new SolidColorBrush(Colors.Red);
                }
                double p = double.Parse(ph.Text);
                bool rispP = Metodi.ControlloPh(p);
                if (rispP == true)
                {
                    lblresult2.Content += "Ph : si \n";
                    lblresult2.Foreground = new SolidColorBrush(Colors.Green);
                    f2 = true;
                }
                else
                {
                    lblresult2.Content += "Ph : no \n";
                    f2 = false;
                    lblresult2.Foreground = new SolidColorBrush(Colors.Red);
                }
                double r = double.Parse(residuo.Text);
                double l1 = double.Parse(litri.Text);
                bool rispR = Metodi.ControlloResiduo(r, l1);
                if (rispR == true)
                {
                    lblresult3.Content += "Residuo : si \n";
                    lblresult3.Foreground = new SolidColorBrush(Colors.Green);
                    f3 = true;
                }
                else
                {
                    lblresult3.Content += "Residuo : no  \n";
                    f3 = false;
                    lblresult3.Foreground = new SolidColorBrush(Colors.Red);

                }
                double a = double.Parse(ammoniaca.Text);
                double l2 = double.Parse(litri.Text);
                bool rispA = Metodi.ControlloAmmoniaca(a, l2);
                if (rispA == true)
                {
                    lblresult4.Content += "Ammoniaca : si \n";
                    lblresult4.Foreground = new SolidColorBrush(Colors.Green);
                    f4 = true;
                }
                else
                {
                    lblresult4.Content += "Ammoniaca : no \n";
                     f4 = false;
                    lblresult4.Foreground = new SolidColorBrush(Colors.Red);
                }
                double ni = double.Parse(nitriti.Text);
                bool rispNi = Metodi.ControlloNitriti(ni);
                if (rispNi == true)
                {
                    lblresult5.Content += "Nitriti : si \n";
                    lblresult5.Foreground = new SolidColorBrush(Colors.Green);
                    f5 = true;
                }
                else
                {
                    lblresult5.Content += "Nitriti : no \n";
                     f5 = false;
                    lblresult5.Foreground = new SolidColorBrush(Colors.Red);
                }
                double na = double.Parse(nitrati.Text);
                double l3 = double.Parse(litri.Text);
                bool rispNa = Metodi.ControlloNitrati(na, l3);
                if (rispNa == true)
                {
                    lblresult6.Content += "Nitrati : si \n";
                    lblresult6.Foreground = new SolidColorBrush(Colors.Green);
                    f6 = true;
                }
                else
                {
                    lblresult6.Content += "Nitrati : no \n";
                     f6 = false;
                    lblresult6.Foreground = new SolidColorBrush(Colors.Red);
                }
                double c = double.Parse(cloruri.Text);
                double l4 = double.Parse(litri.Text);
                bool rispC = Metodi.ControlloCloruri(a, l4);
                if (rispC == true)
                {
                    lblresult7.Content += "Cloruri : si \n";
                    lblresult7.Foreground = new SolidColorBrush(Colors.Green);
                    f7 = true;
                }
                else
                {
                    lblresult7.Content += "Cloruri : no \n";
                     f7 = false;
                    lblresult7.Foreground = new SolidColorBrush(Colors.Red);
                }
            }
            catch
            {
                MessageBox.Show("Devi riempire tutti i campi con valori numerici", "ERRORE", MessageBoxButton.OK, MessageBoxImage.Error);
                ph.Clear();
                cloruri.Clear();
                nitrati.Clear();
                nitriti.Clear();
                litri.Clear();
                ammoniaca.Clear();
                residuo.Clear();
                temperatura.Clear();
                lblresult1.Content = "";
                lblresult2.Content = "";
                lblresult3.Content = "";
                lblresult4.Content = "";
                lblresult5.Content = "";
                lblresult6.Content = "";
                lblresult7.Content = "";
                lblresult8.Content = "";
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
                lblresult8.Content += ("L'acqua è potabile");
                lblresult8.Foreground = new SolidColorBrush(Colors.Green);
            }
            else
            {
                lblresult8.Content += ("L'acqua non è potabile");
                lblresult8.Foreground = new SolidColorBrush(Colors.Red);
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
