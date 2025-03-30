using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaces
{
    public interface IPerson
    {
        void HowAmI();
    }

    public interface ICommunication
    {
        void SendEmail(string Title, string Body);
        void SendSMS(string Message);
        void CallPhone();
    }

    public class Person : IPerson, ICommunication
    {
        public void HowAmI()
        {
            Console.WriteLine("Im a Person.");
        }

        public void CallPhone()
        {
            Console.WriteLine("Calling a phone...");
        }


        public void SendEmail(string Title, string Body)
        {
            Console.WriteLine("Sending a mail...");
        }

        public void SendSMS(string Message)
        {
            Console.WriteLine("Sending a SMS...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.HowAmI();
            person.CallPhone();
            person.SendEmail("Hello","Eid Mubarak.");
            person.SendSMS("Hello, Eid Mubarak.");
        }
    }
}
