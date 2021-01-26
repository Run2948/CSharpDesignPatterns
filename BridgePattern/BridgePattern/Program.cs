using BridgePattern.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// 1 多重继承与变化封装
    /// 2 桥接模式：解决多维度的变化
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎来到.net高级班公开课之设计模式特训课，今天是Eleven为大家带来的桥接模式");
            Console.WriteLine("******************************");
            {
                BasePhone phone = new iPhone();
                phone.Call();
                phone.Text();
            }
            Console.WriteLine("******************************");
            {
                BasePhone phone = new Galaxy();
                phone.Call();
                phone.Text();
            }
            Console.WriteLine("******************************");
            {
                BasePhone phone = new iPhoneAndroid();
                phone.Call();
                phone.Text();
            }
            Console.WriteLine("******************************");
            {
                BasePhone phone = new GalaxyIOS();
                phone.Call();
                phone.Text();
            }
            ISystem android = new AndroidSystem();
            ISystem ios = new IOSSystem();
            ISystem winphone = new WinphoneSystem();

            Console.WriteLine("******************************");
            {
                BasePhoneBridge phone = new GalaxyBridge();
                phone.SystemVersion = android;
                phone.Call();
                phone.Text();
            }
            {
                BasePhoneBridge phone = new GalaxyBridge();
                phone.SystemVersion = ios;
                phone.Call();
                phone.Text();
            }
            {
                BasePhoneBridge phone = new GalaxyBridge();
                phone.SystemVersion = winphone;
                phone.Call();
                phone.Text();
            }
            Console.Read();
        }
    }
}
