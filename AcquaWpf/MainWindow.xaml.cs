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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           try {
                double t = double.Parse(temperatura.Text);
                bool rispT = Metodi.ControlloTemperatura(t);
                if (rispT == true)
                {
                    lblresult.Content += "Temperatura:si \n";
                }
                else
                {
                    lblresult.Content += "Temperatura:no \n";
                }
                temperatura.Clear();
                double p = double.Parse(ph.Text);
                bool rispP = Metodi.ControlloPh(p);
                if (rispP == true)
                {
                    lblresult.Content += "Ph:si \n";
                }
                else
                {
                    lblresult.Content += "Ph:no \n";
                }
                ph.Clear();
                double r = double.Parse(residuo.Text);
                double l1 = double.Parse(litri.Text);
                bool rispR = Metodi.ControlloResiduo(r, l1);
                if (rispR == true)
                {
                    lblresult.Content += "Residuo:si \n";
                }
                else
                {
                    lblresult.Content += "Residuo:no \n";
                }
                residuo.Clear();
                double a = double.Parse(ammoniaca.Text);
                double l2 = double.Parse(litri.Text);
                bool rispA = Metodi.ControlloAmmoniaca(a, l2);
                if (rispA == true)
                {
                    lblresult.Content += "Ammoniaca:si \n";
                }
                else
                {
                    lblresult.Content += "Ammoniaca:no \n";
                }
                ammoniaca.Clear();
                double ni = double.Parse(nitriti.Text);
                bool rispNi = Metodi.ControlloNitriti(ni);
                if (rispNi == true)
                {
                    lblresult.Content += "Nitriti:si \n";
                }
                else
                {
                    lblresult.Content += "Nitriti:no \n";
                }
                nitriti.Clear();
                double na = double.Parse(nitrati.Text);
                double l3 = double.Parse(litri.Text);
                bool rispNa = Metodi.ControlloNitrati(na, l3);
                if (rispNa == true)
                {
                    lblresult.Content += "Nitrati:si \n";
                }
                else
                {
                    lblresult.Content += "Nitrati:no \n";
                }
                nitrati.Clear();
                double c = double.Parse(cloruri.Text);
                double l4 = double.Parse(litri.Text);
                bool rispC = Metodi.ControlloCloruri(a, l4);
                if (rispC == true)
                {
                    lblresult.Content += "Cloruri:si \n";
                }
                else
                {
                    lblresult.Content += "Cloruri:no \n";
                }
                cloruri.Clear();
            }
            catch
            { MessageBox.Show("Devi riempire tutti i campi con valori numerici", "ERRORE", MessageBoxButton.OK, MessageBoxImage.Error); }

        }
    }
}
