using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeGame.Graphics;

namespace SnakeGame.Game;

public class Snake : HorizontalLine
{
    public ConsoleKey Direction { get; set; }
    public Snake(int x, int y, int length, char symbol,ConsoleKey direction) : base(x, y, length, symbol)
    {
        Direction = direction;
    }

    public bool Move(ConsoleKey newDirection, int startX, int startY, int endX, int endY)
    {
        Direction = newDirection;

        var head = Points.First();
        var head2 = new Point(head);
        var newHead = head2 + Direction;

        if(ValidationMove(startX, startY, endX, endY))
        {
            return false;
        }

        Points.Insert(0, newHead);
        newHead.Draw();

        var tail = Points.Last();
        Points.RemoveAt(Points.Count - 1);
        tail.Clear();

        return true;
    }

    public bool _ValidationDirection(ConsoleKey newDirection)
    {
        var checkLeftArrow = Direction == ConsoleKey.LeftArrow && newDirection != ConsoleKey.RightArrow;
        var checkRightArrow = Direction == ConsoleKey.RightArrow && newDirection != ConsoleKey.LeftArrow;
        var checkUpArrow = Direction == ConsoleKey.UpArrow && newDirection != ConsoleKey.DownArrow;
        var checkDownArrow = Direction == ConsoleKey.DownArrow && newDirection != ConsoleKey.UpArrow;

        return checkLeftArrow || checkRightArrow || checkUpArrow || checkDownArrow;
    }

    public bool ValidationMove(int startX, int startY, int endX, int endY)
    {
        var checkEatBody = IsEatBody();
        var checkPunchBoard = IsPunchBoard(startX,startY,endX,endY);

        return checkEatBody || checkPunchBoard;
    }

    public bool Eat(Food food)
    {
        var head = Points.First();
        if(head == food)
        {
            var head2 = new Point(head);
            var newHead = head2 + Direction;
            Points.Insert(0, newHead);
            newHead.Draw();
            return true;            
        }
        return false;
    }

    public bool InSnakeBody(Food food)
    {
        foreach(var point in Points)
        {
            if (food == point)
                return true;
        }
        return false;
    }

    private bool IsEatBody()
    {
        foreach(var index in Enumerable.Range(1, Points.Count - 1))
        {
            if(Points[index] == Points[0])
            {
                return true;
            }        
        }
        return false;
    }

    private bool IsPunchBoard(int startX, int startY, int endX, int endY)
    {
        var head = Points.First();
        var checkX = head.X == startX || head.X == endX;
        var checkY = head.Y == startY || head.Y == endY;
        return checkX || checkY;
    }
}