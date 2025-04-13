using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3_15
{
    class BeginScene : BeginOrAnd
    {
        public BeginScene()
        {
            strTitle = "贪吃蛇";
            strOne = "开始游戏";
        }
        public override void EnterJDoSomething()
        {
            if (nowSelectId == 0)
            {
                Game.ChangeScene(ESceneType.Game);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
