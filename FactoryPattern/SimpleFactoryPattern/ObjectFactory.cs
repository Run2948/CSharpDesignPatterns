using FactoryPattern.War3.Interface;
using FactoryPattern.War3.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    /// <summary>
    /// 工厂类
    /// </summary>
    public class ObjectFactory
    {
        public static IRace CreateInstance(RaceType raceType)
        {
            IRace race = null;
            switch (raceType)
            {
                case RaceType.Human:
                    race = new Human();
                    break;
                case RaceType.NE:
                    race = new NE();
                    break;
                case RaceType.ORC:
                    race = new ORC();
                    break;
                case RaceType.Undead:
                    race = new Undead();
                    break;
                default:
                    throw new Exception("wrong raceType");
            }

            return race;
        }

        private static string IRaceTypeConfig = ConfigurationManager.AppSettings["IRaceTypeConfig"];
        public static IRace CreateInstanceConfig()
        {
            RaceType raceType = (RaceType)Enum.Parse(typeof(RaceType), IRaceTypeConfig);

            IRace race = null;
            switch (raceType)
            {
                case RaceType.Human:
                    race = new Human();
                    break;
                case RaceType.NE:
                    race = new NE();
                    break;
                case RaceType.ORC:
                    race = new ORC();
                    break;
                case RaceType.Undead:
                    race = new Undead();
                    break;
                default:
                    throw new Exception("wrong raceType");
            }

            return race;
        }


        private static string IRaceTypeConfigReflection = ConfigurationManager.AppSettings["IRaceTypeConfigReflection"];
        private static string DllName = IRaceTypeConfigReflection.Split(',')[0];
        private static string ClassName = IRaceTypeConfigReflection.Split(',')[1];
        public static IRace CreateInstanceConfigReflection()
        {
            Assembly assembly = Assembly.Load(DllName);
            Type type = assembly.GetType(ClassName);
            Object oObject = Activator.CreateInstance(type);
            return (IRace)oObject;
        }



    }

    public enum RaceType
    {
        Human = 1,
        NE = 2,
        ORC = 3,
        Undead = 4
    }
}
