using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMobileExam
{
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
