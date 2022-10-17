using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Graphics;

public abstract class Figure : IFigure
{
    public int X { get; set; }
    public int Y { get; set; }
    public char Symbol { get; set; }
    public List<Line> Lines { get; set; }
    public Figure(int x, int y, char symbol)
    {
        X = x;
        Y = y;
        Symbol = symbol;
        Lines = new List<Line>();
    }

    public void Draw()
    {
        foreach (var point in Lines)
        {
            point.Draw();
        }
    }
}
