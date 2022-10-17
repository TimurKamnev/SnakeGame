using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Graphics;

public abstract class Line 
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Length { get; set; }
    public char Symbol { get; set; }
    public List<Point> Points { get; set; }
    public Line(int x, int y, int length, char symbol)
    {
        X = x;
        Y = y;
        Length = length;
        Symbol = symbol;
        Points = new List<Point>();
        Initialize(x, y, length, symbol);
    }

    public abstract void Initialize(int x, int y, int length, char symbol);


    public void Draw()
    {
        foreach (var point in Points)
        {
            point.Draw();
        }
    }
}
