using System;

namespace BankATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 0, v1=0, falschesPasswort=1;
            decimal saldo = 5000, menge;
            string action, pin = "1234", pinG = ""; 

            while (v1 < 1)
            {

                Console.WriteLine("Wilkommen X Bank ATM");
                Console.WriteLine("Bitte führen Sie Ihre Karte ein und tippen Sie Ihr Passwort.");

                pinG = Console.ReadLine();



                if (pin == pinG)
                {


                    while (a1 < 1)
                    {
                        Console.WriteLine("Ihr aktuelles Guthaben beträgt " + saldo + " Euro");
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("Was würden Sie gern tun?");
                        Console.WriteLine("1. Zurückziehen");
                        Console.WriteLine("2. Kontostand prüfen");
                        Console.WriteLine("3. Exit");

                        action = Console.ReadLine();



                        switch (action)
                        {
                            case "1":
                                Console.Clear();
                                Console.WriteLine("Geben Sie bitte den abzuhebenden Betrag ein:");
                                menge = Convert.ToDecimal(Console.ReadLine());
                                if (menge > saldo)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Leider haben Sie nicht so viel Geld auf Ihrem Konto, wie Sie abheben möchten.");
                                    Console.WriteLine("-----------------------------");
                                }
                                else
                                {
                                    Console.Clear();
                                    saldo = saldo - menge;
                                    Console.WriteLine("Auszahlung abgeschlossen. Sie können Ihr Geld aus dem Fach darunter holen");
                                    Console.WriteLine("-----------------------------");

                                }
                                break;

                            case "2":
                                Console.Clear();

                                break;
                            case "3":
                                Console.Clear();
                                Console.WriteLine("Vielen Dank für die Nutzung des Geldautomaten.");
                                a1++;
                                v1++;

                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Ungültige Option");
                                Console.WriteLine("Bitte versuche es erneut");
                                break;


                        }

                    }

                }


                else if (falschesPasswort==3)
                {
                    Console.WriteLine("Sie haben Ihr Passwort dreimal falsch eingegeben, Ihre Karte ist gesperrt");
                    v1++;

                }
                
                
                else
                {
                    Console.WriteLine("Bitte versuche es erneut");
                    falschesPasswort++;
                }


            }

        }
    }
}

