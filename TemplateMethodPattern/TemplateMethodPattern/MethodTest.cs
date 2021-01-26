using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 知识同步：普通方法  虚方法  抽象方法
    ///          
    /// 编译时决定普通方法的调用
    /// 运行时决定虚方法的调用
    /// </summary>
    public class MethodTest
    {
        public static void Show()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");

            //ParentClass p = new ParentClass();//抽象类不能直接实例化

            Console.WriteLine(" ParentClass abstractTest1 = new ChildClass();");
            ParentClass abstractTest1 = new ChildClass();
            abstractTest1.Show();

            Console.WriteLine(" ChildClass abstractTest2 = new ChildClass();");
            ChildClass abstractTest2 = new ChildClass();
            abstractTest2.Show();


            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");

            Console.WriteLine(" NewTest newTest1 = new NewTest();");
            NewTest newTest1 = new NewTest();
            newTest1.Show();

          
            Console.WriteLine(" NewTest newTest2 = new NewTestChild();");
            NewTest newTest2 = new NewTestChild();
            //newTest2.Show();
            newTest2.Show();

            Console.WriteLine(" NewTestChild newTest3 = new NewTestChild();");
            NewTestChild newTest3 = new NewTestChild();
            newTest3.Show();

            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");


            Console.WriteLine(" VirtualTest virtualTest1 = new VirtualTest();");
            VirtualTest virtualTest1 = new VirtualTest();
            virtualTest1.Show();

            Console.WriteLine(" VirtualTest virtualTest2 = new VirtualTestChild();");
            VirtualTest virtualTest2 = new VirtualTestChild();
            virtualTest2.Show();

            Console.WriteLine(" VirtualTestChild virtualTest3 = new VirtualTestChild();");
            VirtualTestChild virtualTest3 = new VirtualTestChild();
            virtualTest3.Show();


            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");


        }
    }

    #region abstract
    public abstract class ParentClass
    {
        /// <summary>
        /// 抽象方法
        /// </summary>
        public abstract void Show();
    }

    public class ChildClass : ParentClass
    {
        /// <summary>
        /// virtual
        /// </summary>
        public override void Show()
        {
            Console.WriteLine("This is ChildClass");
        }
    }
    #endregion abstract
    //重写overwrite(new)  覆写override 重载overload(方法) 

    #region New
    public class NewTest
    {
        public void Show()
        {
            Console.WriteLine("This is NewTest");
        }
    }

    public class NewTestChild : NewTest
    {

        /// <summary>
        /// new 要不要都没区别 都会隐藏掉父类方法
        /// 不要new会提示警告
        /// </summary>
        public new void Show()
        {
            Console.WriteLine("This is NewTestChild");
        }
    }
    #endregion New

    #region Virtual
    public class VirtualTest//virtual 只能修饰方法
    {
        /// <summary>
        /// virtual  虚方法  必须包含实现 但是可以被重载
        /// </summary>
        public virtual void Show()
        {
            Console.WriteLine("This is VirtualTest");
        }
    }
    public class VirtualTestChild : VirtualTest
    {
        public override void Show()
        {
            Console.WriteLine("This is VirtualTestChild");
        }
    }

    #endregion Virtual
}
