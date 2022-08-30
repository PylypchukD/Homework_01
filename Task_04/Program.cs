using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class Program
    {
        /*
         * Используя Visual Studio, создайте проект по шаблону Console Application. 
         * Требуется: Создать класс с именем Address. В теле класса требуется создать поля: index, country, city, street, house, apartment. 
         * Для каждого поля, создать свойство с двумя методами доступа. Создать экземпляр класса Address. 
         * В поля экземпляра записать информацию о почтовом адресе. Выведите на экран значения полей, описывающих адрес.
         */

        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = 03100;
            address.Country = "Ukraine";
            address.City = "Kyiv";
            address.House = "Good";
            address.Apartment = "123";

            Console.WriteLine($"{address.Index},{address.Country},{address.City},{address.House},{address.Apartment}");

            Console.ReadKey();
        }
    }
}
