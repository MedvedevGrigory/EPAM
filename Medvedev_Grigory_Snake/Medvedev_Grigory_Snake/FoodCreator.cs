using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medvedev_Grigory_Snake
{
    class FoodCreator
    {
        public FoodCreator(int MapWidth, int MapHeight, char sym)
        {
            this.MapWidth = MapWidth;
            this.MapHeight = MapHeight;
            this.sym = sym;
        }

        int MapWidth;
        int MapHeight;
        char sym;

        Random random = new Random();

        internal Point CreateFood()
        {
            int x = random.Next(2, MapWidth - 2);
            int y = random.Next(2, MapHeight - 2);

            return new Point(x, y, sym);
        }
    }
}
