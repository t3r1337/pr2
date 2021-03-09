using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    class Warehouse
    {
        public string street;
        public int area;
        public Warehouse(string s, int a) { street = s; area = a; }
        public void DisplayWarehouse()
        {
            Console.WriteLine($"Улица склада: {street}, Площадь склада: {area} кв.м");
        }
    }
    class Product
    {
        public string name;
        public int cost;
        public Product(string n, int c) { name = n; cost = c; }
        public void DisplayProduct()
        {
            Console.WriteLine($"Наименование товара: {name}, Цена услуги: {cost} руб");
        }
    }
    class Client
    {
        public string firstName;
        public string lastName;
        public Client(string f, string l) { firstName = f; lastName = l; }
        public void DisplayClient()
        {
            Console.WriteLine($"Имя клиента: {firstName}, Фамилия: {lastName}");
        }
    }
    class Consultant
    {
        public string firstName;
        public string lastName;
        public int age;
        public Consultant(string f1, string l1, int a1) { firstName = f1; lastName = l1; age = a1; }
        public void DisplayComsultant()
        {
            Console.WriteLine($"Имя консультанта: {firstName}, Фамилия: {lastName}, Возраст: {age}");
        }
    }
    struct KindOfSport
    {
        public string name;
        public KindOfSport(string n1) { name = n1; }
        public void DisplaySport()
        {
            Console.WriteLine($"Вид спорта: {name}");
        }
    }
    enum streets
    {
        Пушкина = 1,
        Лермониова,
        Королёва
    }
    
    enum KindOfSports
    {
        Волеёбол = 1,
        Футбол,
        Баскетбол
    }
    class Program
    {
        static void Main(string[] args)
        {
            Warehouse pshk = new Warehouse("Пушкина", 250);
            pshk.DisplayWarehouse();

            Product Balls = new Product("Спортивные мячи", 1000);
            Balls.DisplayProduct();

            KindOfSport fut;
            fut.name = "Футбол";
            fut.DisplaySport();

            Client den = new Client("Денис", "Паджиков");
            den.DisplayClient();

            Consultant chel = new Consultant("Роберт", "Петров", 22);
            chel.DisplayComsultant();


            Console.ReadKey();
        }
    }
}
