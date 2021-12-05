using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Program
    {
        //Работа с обобщенными типами
        static void Main(string[] args)
        {
            //Создаем экземпляр банковского счета с номером счета в виде числа
            BankAccount<int> bankAccount1 = new BankAccount<int>();
            bankAccount1.BankAccountSet(12345, 45789.23, "Иванов");

            //Создаем экземпляр банковского счета с номером счета в виде строки
            BankAccount<string> bankAccount2 = new BankAccount<string>();
            bankAccount2.BankAccountSet("A100B560899", 123456789.12, "Петров");

            //Выводим информацию о банковских счетах
            bankAccount1.BankAccountGet();
            bankAccount2.BankAccountGet();

            Console.ReadKey();
        }
    }
    
    //Класс, моделирующий счет в банке
    class BankAccount<T> //класс обобщенного типа
    {
        //Закрытые поля информации о счете
        private T AccountNumber { get; set; }//поле обобщенного типа
        private double AccountBalance { get; set; }
        private string AccountOwner { get; set; }
        //Метод для заполнения данных
        internal void BankAccountSet(T acc_number, double acc_balance, string acc_owner)
        {
            AccountNumber = acc_number;
            AccountBalance = acc_balance;
            AccountOwner = acc_owner;
        }
        //Метод для чтения данных
        internal void BankAccountGet()
        {
            Console.WriteLine("\nИнформация о запрошенном счете\nНомер счета: {0,16:000000000000}\nБаланс:  {1,20:###,###,###.##}\nВладелец:  {2,18}",AccountNumber, AccountBalance, AccountOwner);
        }

    }
}
