using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasLightsKata.Models
{
    public class ChristmasLights
    {
        public int[,] Grid { get; set; }

        public ChristmasLights()
        {
            Grid = new int[1000, 1000];
        }

        public void TurnOn(int rangeStartX, int rangeStartY, int rangeEndX, int rangeEndY)
        {
            for (int i = rangeStartX; i <= rangeEndX; i++)
            {
                for (int j = rangeStartY; j <= rangeEndY; j++)
                {
                    Grid[i, j] = 1;
                }
            }

        }

        public void TurnOff(int rangeStartX, int rangeStartY, int rangeEndX, int rangeEndY)
        {
            for (int i = rangeStartX; i <= rangeEndX; i++)
            {
                for (int j = rangeStartY; j <= rangeEndY; j++)
                {
                    Grid[i, j] = 0;
                }
            }

        }

        public void Toggle(int rangeStartX, int rangeStartY, int rangeEndX, int rangeEndY)
        {
            for (int i = rangeStartX; i <= rangeEndX; i++)
            {
                for (int j = rangeStartY; j <= rangeEndY; j++)
                {
                    if (Grid[i, j] == 0)
                    {  
                       Grid[i, j] = 1; 
                    }
                    else
                    {
                        Grid[i,j] = 0;
                    }
                }
            }

        }

    }
}
