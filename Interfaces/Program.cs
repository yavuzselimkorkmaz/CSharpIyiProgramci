using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        //interfaceler newlenemez
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
            projectManager.Add(new EmployeeManager());    

            Console.ReadLine();
        }
    }

    interface IPersonManager
    {
        //unimplemented operation
        void Add();
        void Update();
    }

    //inherits - class ------------ implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        { 
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }

    class EmployeeManager:IPersonManager
    {
      public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi");
        }

    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("stajyer güncellendi");
        }
    }

}
