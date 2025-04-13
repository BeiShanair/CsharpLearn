using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3_15
{
    class EndScene : BeginOrAnd
    {
        public EndScene()
        {
            strTitle = "游戏结束";
            strOne = "回到开始界面";
        }
        public override void EnterJDoSomething()
        {
            if (nowSelectId == 0)
            {
                Game.ChangeScene(ESceneType.Begin);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
