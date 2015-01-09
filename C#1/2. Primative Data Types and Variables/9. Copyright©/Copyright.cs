using System;

    class Copyright
    {
        static void Main(string[] args)
        {
            char potato = '©';
            Console.WriteLine(" " + " " + " " + " " + potato);
            Console.WriteLine(" " + " " + " " +potato + " " + potato);
            Console.WriteLine(" " + " " + potato + " " + " " + potato);
            Console.WriteLine(" " + potato + " " + " " + " " + potato);
            Console.WriteLine(potato + " " + " " + " " + " " + potato);

            Console.WriteLine();
            int size = 21;
            for (int i = 0; i < size; i++)
            {
                if (i%1==0)
                {
                    
                    for (int p = 0; p <= i; p++)
                    {

                        if (p == 0)
                        {
                            
                            for (int wtf = size; wtf >= i; wtf--)
                            {
                                Console.Write("-");
                            }
                            Console.Write(potato);
                            
                        }
                        if (p == i)
                        {
                            
                            
                            for (int wtf = 0; wtf <= i; wtf++)
                            {
                                Console.Write("-");
                            }
                            Console.Write(potato);
                        }
                        Console.Write(" ");
                        
                    }
                    
                    Console.WriteLine();
                }   
            }



        }
    }