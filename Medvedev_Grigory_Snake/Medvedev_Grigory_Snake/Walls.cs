using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medvedev_Grigory_Snake
{
    class Walls
    {
        public Walls(int MapWidth, int MapHeight)
        {
            wallList = new List<Figure>();

            HorizontalLine upLine = new HorizontalLine(0, MapWidth - 2, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, MapWidth - 2, MapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, MapHeight - 1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, MapHeight - 1, MapWidth - 2, '+');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        List<Figure> wallList;

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }

            return false;
        }

        public void Draw()
        {
            foreach (Figure wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
