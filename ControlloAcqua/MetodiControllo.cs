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
        public static bool Residuo(double litri,double residuo)
        {
            double residuomax = litri * 1500;
            bool risposta;
            if(residuo>residuomax)
            {
                 risposta = false;
                return risposta;
            }
            else
            {
                risposta = true;
                return risposta;
            }
        }
        public static bool ControlloAmmoniaca(double ammoniaca, double litri)
        {
            double ammoniacamax = ammoniaca * litri;
            bool risposta;
            if (ammoniaca > ammoniacamax)
            {
                risposta = false;
                return risposta;
            }
            else
            {
                risposta = true;
                return risposta;
            }

        }
    }
}
