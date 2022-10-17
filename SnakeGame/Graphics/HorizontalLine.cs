using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Graphics;

public class HorizontalLine : Line
{
    public HorizontalLine(int x, int y, int length, char symbol) : base(x, y, length, symbol) { }

    public override void Initialize(int x, int y, int length, char symbol)
    {
        foreach (var i in Enumerable.Range(0, length))
        {
            Points.Add(new(x + i, y, '#'));
        }
    }
}
