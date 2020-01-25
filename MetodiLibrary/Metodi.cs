using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodiLibrary
{
    public class Metodi
    {
            public static bool ControlloTemperatura(double temperatura)
            {
                int tempmin = 12;
                int tempmax = 25;
                bool risposta;
                if (temperatura >= tempmin && temperatura <= tempmax)
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
                double phmin = 6.5;
                double phmax = 8.5;
                bool risposta;
                if (ph >= phmin && ph <= phmax)
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
            public static bool ControlloResiduo(double residuo, double litri)
            {
                double residuomax = 1500 * litri;
                bool risposta;
                if (residuo < residuomax)
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
            public static bool ControlloAmmoniaca(double ammoniaca, double litro)
            {
                double ammoniacamax = 0.05 * litro;
                bool risposta;
                if (ammoniaca < ammoniacamax)
                {
                    return risposta = true;
                }
                else
                    return risposta = false;
            }
            public static bool ControlloNitriti(double nitriti)
            {
                bool risposta;
                if (nitriti == 0)
                {
                    risposta = true;
                    return risposta;
                }
                else
                    risposta = false;
                return risposta;
            }
            public static bool ControlloNitrati(double nitrati, double litri)
            {
                double nitratimax = 5 * litri;
                bool risposta;
                if (nitrati > nitratimax)
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
            public static bool ControlloCloruri(double cloruri, double litri)
            {
                double clorurimax = 25 * litri;
                bool risposta;
                if (cloruri > clorurimax)
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



