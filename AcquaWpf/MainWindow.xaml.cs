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
            double t = double.Parse(temperatura.Text);
            bool rispT = Metodi.ControlloTemperatura(t);
            if(rispT==true)
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
            if(rispP==true)
            {
                lblresult.Content += "Ph:si \n"; 
            }
            else
            {
                lblresult.Content += "Ph:no \n";
            }
            ph.Clear();
            double r = double.Parse(residuo.Text);
            bool rispR = Metodi.ControlloResiduo(r);
        }
    }
}
