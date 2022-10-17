using SnakeGame.Graphics;
using SnakeGame.Game;

var width = 80;
var height = 30;
var figure = new Square(0, 0, '#', width, height);

figure.Draw();
var snake = new Snake(20, 20, 3,'*', ConsoleKey.LeftArrow);
Console.ReadKey();
var pressedKey = ConsoleKey.LeftArrow;
var food = new Food(10, 10, '$');
food.Draw();
var gameContinue = true;

while (true)
{
    Thread.Sleep(100);
    if (snake.Eat(food))
    {
        food.Generate(0,0,width - 1, height - 1);
        while (snake.InSnakeBody(food))
        {
            food.Generate(0, 0, width - 1, height - 1);
        }
        food.Draw();
    }

    if (Console.KeyAvailable)
    {
        var key = Console.ReadKey();
        if (snake._ValidationDirection(key.Key)){
            pressedKey = key.Key;
            gameContinue = snake.Move(pressedKey, 0, 0, width, height);
        }
    }
    else
    {
        gameContinue = snake.Move(pressedKey,0 ,0, width, height);
    }
    if (!gameContinue)
    {
        break;
    }
}