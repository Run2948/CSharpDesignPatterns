using DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// 1 装饰器模式 Decorator
    /// 2 对象在运行的过程中，不断的增加新功能(AOP)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班公开课之设计模式特训，今天是Eleven为大家带来的装饰器模式");
                {
                    BaseCharacter mage = new Mage();
                    mage.Show();
                    BaseCharacter minister = new Minister();
                    minister.Show();
                }
                Console.WriteLine("**************************************");
                {
                    BaseCharacter mage = new MageWithHelmet();
                    mage.Show();
                }
                Console.WriteLine("**************************************");
                {
                    BaseCharacter mage = new MageWithShoulder();
                    mage.Show();
                }
                Console.WriteLine("**************************************");
                {
                    BaseCharacter character = new Mage();

                    //BaseDecorator decorator = new BaseDecorator(character);
                    //decorator = new DecoratorHelmet(decorator);

                    //decorator.Show();

                    character = new BaseDecorator(character);//

                    character = new DecoratorHelmet(character);//

                    character = new DecoratorShoulder(character);//

                    character = new DecoratorBreastplate(character);

                    character = new DecoratorCuish(character);

                    character = new DecoratorGlove(character);



                    character.Show();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
