    using System;
    using System.Threading;
    using System.Threading.Tasks;

    namespace WinstonApp
    {
        public class Helper
        {
            public static void Counter(string txt, int interval)
            {
                foreach (var a in txt)
                {
                    Console.Write(a);
                    Thread.Sleep(interval);
                }
                Console.WriteLine();
            }
            public static void Clear()
            {
                try
                {
                    Console.Clear();
                }
                catch (System.Exception e)
                {
                }
            }
            public static void Menu()
            {
                string a = "0";

                while(a != "1" & a != "2")
                {

                    Console.WriteLine("1 - Iniciar");
                    Console.WriteLine("2 - Fechar");
                    a = Console.ReadLine();

                    if (a.Equals("1") )
                    {
                        Helper.Counter("...", 100);
                    }
                    else if (a.Equals("2"))
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Você digitou uma opção incorreta.");
                        Helper.Counter("...", 100);
                    }
                }

            }

            public static void DisplayChapter(string title, string description, string[] action, string[] answer)
            {
                Helper.Counter(title, 100);

                Helper.Counter("\n", 500);
                Helper.Counter(description, 60);
                foreach (var act in action)
                {
                    Helper.Counter(act, 100);
                }
                Helper.Counter("\n Digite a opção escolhida", 100);
                string a = "0";

                while(a != "1" & a != "2")
                {   
                    a = Console.ReadLine();

                    if(a.Equals("1"))
                    {
                        Helper.Counter(answer[0], 60);        
                    }
                    else if(a.Equals("2"))
                    {
                        Helper.Counter(answer[1], 60);
                    }
                    else
                    {
                        Console.WriteLine("Você digitou uma opção incorreta.");
                        Helper.Counter("...", 100);
                    
                        foreach (var act in action)
                        {
                            Helper.Counter(act, 100);
                        }        
                    }
                    
                }
                Helper.Counter("\n Aperte qualquer tecla para continuar...", 100);
                Console.ReadLine();
            }
        }
        
    }