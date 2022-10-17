using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Graphics;

public class Square : Figure
{
    public Square(int x, int y, char symbol, int width, int heigth) : base(x, y, symbol)
    {
        Lines.Add(new HorizontalLine(x, y, width, symbol));
        Lines.Add(new HorizontalLine(x, y + heigth - 1, width, symbol));
        Lines.Add(new VerticalLine(x, y, heigth, symbol));
        Lines.Add(new VerticalLine(x + width - 1, y, heigth, symbol));
    }
}