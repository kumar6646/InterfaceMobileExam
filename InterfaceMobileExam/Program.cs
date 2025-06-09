using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMobileExam
{
    /*
     * 
     * Interface: To define a interface we have to use interface keyword
     * Interface looks like a class but it has no implementation
     * An Interface is a collection of abstract members.
     * By Default interface members are public and abstract.
     * syntax:
     * interface <interface name>
     * {
     * abstract members
     * }
     * note:Interface name should start with I
     * ex:Iemployee,Istudent
     * Interface members we should implement with in derived class 
     * without using override keyword
     * Interface cannot contain static members.
     * using Interface we can implement multiple inheritance
     * We cannot create an object for Interfaace but we can create reference variable.
     * for interfaces.
     */
    interface Inokia1
    {
        void calling();
        void receiving();
        void sendmesg();
        void endcall();
    }
    class nokia1100:Inokia1
    {
        public void calling()
        {
            Console.WriteLine("Nokia1100 is calling");
        }
        public void receiving()
        {
            Console.WriteLine("Nokia1100 is receving");

        }
        public void sendmesg()
        {
            Console.WriteLine("Nokia1100 is sending message");
        }
        public void endcall()
        {
            Console.WriteLine("Nokia1100 is ending call");
        }

    }
    interface INokia2
    {
        void wifi();
        void Videocalling();
    }
    class NokiaAsha:Inokia1, INokia2 
    {
        public void calling()
        {
            Console.WriteLine("Nokia asha is calling");
        }
        public void receiving()
        {
            Console.WriteLine("Nokia asha is receving");
        }
        public void sendmesg()
        {
            Console.WriteLine("Nokia asha is sending message");

        }
        public void endcall()
        {
            Console.WriteLine("Nokia asha is ending call");
        }
        public void wifi()
        {
            Console.WriteLine("Nokia asha wifi is on");

        }
        public void Videocalling()
        {
            Console.WriteLine("nokia asha video calling is supporting");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Inokia1 obj = new nokia1100();
            obj.calling();
            obj.receiving();
            obj.sendmesg();
            obj.endcall();
            obj=new NokiaAsha();
            obj.calling();
            obj.receiving();
            obj.sendmesg();
            obj.endcall();
            INokia2 obj2 =(INokia2)obj;
            obj2.wifi();
            obj2.Videocalling();
            
        }
    }
}
