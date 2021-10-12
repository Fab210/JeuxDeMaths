using System;

namespace JeuxDeMaths
{
    class Program
    {
        //An enum is a special "class" that represents a group of constants 
        enum e_Operator
        {
            ADDITION = 1,
            MULTIPLICATION = 2,
            SUBSTRACTION = 3,
        }

        static void AskQuestion(int VAL_MIN, int VAL_MAX, int NB_QUESTIONS)
        {

            int points = 0;

            for (int i = 0; i < NB_QUESTIONS; i++)
            {
                Random rand = new Random();
                int a = rand.Next(VAL_MIN, VAL_MAX + 1);
                int b = rand.Next(VAL_MIN, VAL_MAX + 1);

                e_Operator o = (e_Operator)rand.Next(1, 4);
                int finalResult;

                int responseInt = 0;

                // ****** SOLUTION WITH SWITCH CASE *******
                /*switch (o)
                {
                    case e_Operator.ADDITION:
                        Console.WriteLine(a + " + " + b + " = ");
                        finalResult = a + b;
                        break;
                    case e_Operator.MULTIPLICATION:
                        Console.WriteLine(a + " x " + b + " = ");
                        finalResult = a * b;
                        break;
                    case e_Operator.SUBSTRACTION:
                        Console.WriteLine(a + " - " + b + " = ");
                        finalResult = a - b;
                        break;
                    default:
                        Console.WriteLine("ERREUR operateur inconnu");
                        break;
                }*/

                Console.WriteLine("Question " + (i + 1) + " / " + NB_QUESTIONS);
                if (o == e_Operator.ADDITION)
                {
                    Console.WriteLine(a + " + " + b + " = ");
                    finalResult = a + b;
                }
                else if (o == e_Operator.MULTIPLICATION)
                {
                    Console.WriteLine(a + " x " + b + " = ");
                    finalResult = a * b;
                }
                else if (o == e_Operator.SUBSTRACTION)
                {
                    Console.WriteLine(a + " - " + b + " = ");
                    finalResult = a - b;
                }
                else
                {
                    Console.WriteLine("ERREUR operateur inconnu");
                    return;
                }

                string res = Console.ReadLine();

                try
                {
                    responseInt = int.Parse(res);
                    if (responseInt == finalResult)
                    {
                        Console.WriteLine("CORRECT");
                        points = points + 1;

                    }
                    else
                    {
                        Console.WriteLine("WRONG");
                    }
                }
                catch
                {
                    Console.WriteLine("ERROR : Enter valid number");
                }
            }
            Console.WriteLine("Nombre de points " + points + " sur " + NB_QUESTIONS);
            Console.WriteLine("");

            if (points == NB_QUESTIONS)
            {
                Console.WriteLine("BRAVO EXCELLENT 100%");
            }
            else if (points == (NB_QUESTIONS / 2))
            {
                Console.WriteLine("COULD BE BETTER 50%");
            }
            else if (points == 0)
            {
                Console.WriteLine("NOOB");
            }

        }
        static void Main(string[] args)
        {
            int VAL_MIN = 0;
            int VAL_MAX = 15;
            int NB_QUESTIONS = 4;

            AskQuestion(VAL_MIN, VAL_MAX, NB_QUESTIONS);
        }
    }
}
