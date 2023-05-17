using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboCatch
{
	public class BoxClass
	{
		public int ScreenIndex { get; set; } = 1; // Indice dello schermo (0 per il primo schermo, 1 per il secondo, ecc.)
		public int X { get; set; } = 100;               // Coordinate X del punto iniziale
		public int Y { get; set; } = 200;               // Coordinate Y del punto iniziale
		public int Width { get; set; } = 300;           // Larghezza dell'area da catturare
		public int Height { get; set; } = 400;      // Altezza dell'area da catturare
		public BoxClass(int screenIndex, int x, int y, int width, int height)
		{
			ScreenIndex = screenIndex;
			X = x;
			Y = y;
			Width = width;
			Height = height;
		}
	}
}
