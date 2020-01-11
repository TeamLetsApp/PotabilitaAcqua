using System;

namespace ControlloAcqua
{
    public class MetodiControllo
    {
        public static bool ControlloTemperatura(double temperatura)
        {
            int tempmin = 12;
            int tempmax = 25;
            bool risposta;
            if (temperatura>=tempmin||temperatura<=tempmax)
            {
                risposta = true;
                return risposta;
            }
            else
            {
                risposta = false;
                return risposta;
            }
        }
        public static bool ControlloPh(double ph)
        {
            double phmin=6.5;
            double phmax = 8.5;
            bool risposta;
            if(ph>=phmin||ph<=phmax)
            {
                risposta = true;
                return risposta;
            }
            else
            {
                risposta =false;
                return risposta;
            }
        }
    }
}
