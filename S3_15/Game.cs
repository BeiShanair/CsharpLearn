using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3_15
{
    enum ESceneType
    {
        Begin,
        Game,
        End
    }

    class Game
    {
        public const int width = 80;
        public const int height = 20;

        public static ISceneUpdate nowScene;

        public Game()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);

            ChangeScene(ESceneType.Begin);
        }

        public void Start()
        {
            while (true)
            {
                if (nowScene != null)
                {
                    nowScene.Update();
                }
            }
        }

        public static void ChangeScene(ESceneType sceneType)
        {
            Console.Clear();

            switch (sceneType)
            {
                case ESceneType.Begin:
                    nowScene = new BeginScene();
                    break;
                case ESceneType.Game:
                    nowScene = new GameScene();
                    break;
                case ESceneType.End:
                    nowScene = new EndScene();
                    break;
            }
        }
    }
}
