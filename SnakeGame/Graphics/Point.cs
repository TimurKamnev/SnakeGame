using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Graphics;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public char Symbol { get; set; }

    public Point(int x, int y, char symbol)
    {
        X = x;
        Y = y;
        Symbol = symbol;
    }

    public Point(Point points)
    {
        X = points.X;
        Y = points.Y;
        Symbol = points.Symbol;
    }

    public void Draw()
    {
        Console.SetCursorPosition(X, Y);
        Console.Write(Symbol);
    }

    public static Point operator+ (Point point , ConsoleKey direction)
    {
        if (direction  == ConsoleKey.LeftArrow)
        {
            point.X -= 1;
        }
        if (direction == ConsoleKey.RightArrow)
        {
            point.X += 1;
        }
        if (direction == ConsoleKey.UpArrow)
        {
            point.Y -= 1;
        }
        if (direction == ConsoleKey.DownArrow)
        {
            point.Y += 1;
        }

        return new Point(point);
    }

    public static bool operator ==(Point point, Point point2)
    {
        return point.X == point2.X && point.Y == point2.Y;
    }

    public static bool operator !=(Point point, Point point2)
    {
        return !(point.X == point2.X && point.Y == point2.Y);
    }

    public void Clear()
    {
        Console.SetCursorPosition(X, Y);
        Console.Write(' ');
    }
}
