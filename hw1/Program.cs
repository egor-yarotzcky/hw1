using System;


    namespace hw1

    {

        class Finder

        {
            static void Main()

            {
                string str = "asdfrtttsssssrtf";
                int Count = 0; //counter
                char maxCh = ' ';
                char PreCh = ' ';
                int max = 0;

                foreach (char ch in str)
                {
                    foreach (char cha in str)

                        if (cha == PreCh && cha == ch)

                        {
                            Count++;

                            if (max < Count)
                            {
                                max = Count;
                                maxCh = ch;
                            }
                        }

                        else
                        {
                            Count = 0;
                        }



                    Count = 0;
                    PreCh = ch;
                }
                Console.WriteLine("Символ встречающийся максимальное колличество раз подрят {0} = {1}", maxCh, max);
                Console.ReadLine();
            }
        }
    }
