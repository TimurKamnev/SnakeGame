using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Graphics;

public interface IFigure
{
    List<Line> Lines { get; }
    void Draw();
}
