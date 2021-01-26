using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    /// <summary>
    /// 1 undo和redo：备忘模式和命令模式的区别
    /// 2 备忘录模式(Memento Patern)，一次恢复和多次恢复
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班公开课之设计模式特训，今天是Eleven老师为大家带来的备忘录模式");
                //int i = 12345;
                //i += 100;//动作  命令和反命令

                //List<War3> war3List = new List<War3>();

                War3 war3 = new War3()
                {
                    Race = "Undead",
                    Hero = "Level 1 DK",
                    Army = "5只食尸鬼",
                    Resource = "200G 200W"
                };
                //war3List.Add(war3);

                //war3.Save();
                war3.Save("Start");
                war3.Show();

                Console.WriteLine("*****MF*******");
                //War3 war31 = new War3()
                //{
                //    Race = "Undead",
                //    Hero = "3级DK1级Lich",
                //    Army = "5只蜘蛛2只食尸鬼",
                //    Resourse = "500G 300W"
                //};//全新的对象来备份，太耗资源

                war3.Hero = "3级DK1级Lich";
                war3.Army = "5只蜘蛛2只食尸鬼";
                war3.Resource = "500G 300W";
                //war3.Save();
                war3.Save("MF");
                //war3List.Add(war3);
                war3.Show();

                Console.WriteLine("*****交战*******");
                war3.Hero = "4级DK 3级Lich 1级小强";
                war3.Army = "1只憎恶6只蜘蛛1只雕像";
                war3.Resource = "1000G 1500W";
                war3.Save("交战");
                //war3.Save();

                Console.WriteLine("*****决战*******");
                war3.Hero = "5级DK 4级Lich 3级小强";
                war3.Army = "2只憎恶8只蜘蛛2只雕像";
                war3.Resource = "1000G 1500W";
                war3.Save("决战");
                //war3.Save();

                Console.WriteLine("*****决战后*******");
                war3.Hero = "6级DK 6级Lich 3级小强";
                war3.Army = "1只憎恶2只蜘蛛1只冰龙";
                war3.Resource = "10G 1200W";
                war3.Save("决战后");
                //war3.Save();

                //war3.Load();
                war3.Load("Start");
                war3.Show();
                war3.Load("MF");
                war3.Show();
                war3.Load("交战");
                war3.Show();
                war3.Load("决战");
                war3.Show();
                war3.Load("决战后");
                war3.Show();
                //Console.WriteLine("********月光宝盒**********");
                //war3 = war3List[0];
                //war3.Show();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
