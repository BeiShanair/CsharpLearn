using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3_15
{
    class GameScene : ISceneUpdate
    {
        Map map;
        Snake snake;
        int updateId = 0;
        Food food;

        public GameScene()
        {
            map = new Map();
            snake = new Snake(40, 10);
            food = new Food(snake);
        }

        public void Update()
        {
            if (updateId % 5000 == 0)
            {
                map.Draw();
                food.Draw();

                snake.Move();
                snake.Draw();
                
                if (snake.CheckEnd(map))
                {
                    Game.ChangeScene(ESceneType.End);
                }

                snake.CheckEatFood(food);

                updateId = 0;
            }
            updateId++;

            if (Console.KeyAvailable)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        snake.ChangeDir(EMoveDir.Up);
                        break;
                    case ConsoleKey.S:
                        snake.ChangeDir(EMoveDir.Down);
                        break;
                    case ConsoleKey.A:
                        snake.ChangeDir(EMoveDir.Left);
                        break;
                    case ConsoleKey.D:
                        snake.ChangeDir(EMoveDir.Right);
                        break;
                }
            }
        }
    }
}
