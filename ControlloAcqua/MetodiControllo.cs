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
            if(temperatura>=tempmin||temperatura<=tempmax)
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
    }
}
