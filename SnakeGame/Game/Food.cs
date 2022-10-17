using System;
using System.Collections.Generic;
using SnakeGame.Graphics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Game;

public class Food : Point
{
    private Random _random { get; set; }
    public Food(int x, int y , char symbol) : base(x, y, symbol)
    {
        _random = new Random();
    }

    public void Generate(int startX, int startY, int endX, int endY)
    {
        X = _random.Next(startX, endX);
        Y = _random.Next(startY, endY);
    }
}
