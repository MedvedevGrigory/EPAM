using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Figure[] arrayOfFigures = new Figure[random.Next(10,15)];

            try
            {
                for (int i = 0; i < arrayOfFigures.Length; i++)
                {
                    switch (random.Next(4))
                    {
                        case 0:
                            arrayOfFigures[i] = new Line(random.NextDouble() * 50);
                            break;
                        case 1:
                            arrayOfFigures[i] = new Round(random.NextDouble() * 50);
                            break;
                        case 2:
                            arrayOfFigures[i] = new Rectangle(random.NextDouble() * 50, random.NextDouble() * 50);
                            break;
                        case 3:
                            arrayOfFigures[i] = new Ring(random.NextDouble() * 50, random.NextDouble() * 50 + 50);
                            break;
                        default:
                            break;
                    }
                }

                foreach (Figure figure in arrayOfFigures)
                {
                    figure.Draw();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
