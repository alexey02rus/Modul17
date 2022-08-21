using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class BankAccount<T>
    {
        T number;
        double balance;
        string name;

        public void SetInfo()
        {
            bool beBalance;
            Console.WriteLine("Введите номер счета");
            number = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите ФИО");
            name = Console.ReadLine();
            do
            {
                Console.WriteLine("Введите баланс");
                beBalance = double.TryParse(Console.ReadLine(), out balance);
                if (!beBalance)
                {
                    Console.WriteLine("Ошибка! Неверный формат данных. Попробуйте ещё раз.");
                }
            } while (!beBalance);
        }
        public string GetInfo()
        {
            return $"Счет номер: {number};\nФИО: {name};\nБаланс: {balance}";
        }

    }
}
