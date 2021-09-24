using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork18._09
{
    // 3.1
    enum bank_account
    {
        Savings, Current,
        Differentcard = 1
    }
    //3.2 
    struct credit
    {
        public string number;
        public string type;
        public string balance;
        public void DisplayInfo()
        {
            Console.WriteLine($"Number:{number}, Type: {type}, Balance {balance}");
        }
    }
    //3.3
    enum university
    {
        KGU, KHTI, KAI
    }
    struct work
    {
        public string name;
        public string university;
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, University: {university}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 3.1");
            bank_account num;
            num = bank_account.Differentcard;
            Console.WriteLine((int)num);
            Console.WriteLine(" 3.2");
            credit card;
            card.number = "77632569086";
            card.type = "credit";
            card.balance = "654400";
            card.DisplayInfo();
            Console.WriteLine(" 3.3");
            work worker;
            worker.name = "Alexander";
            worker.university = Convert.ToString(university.KHTI);
            worker.DisplayInfo();
            work worker_2;
            worker_2.name = "Valeria";
            worker_2.university = Convert.ToString(university.KGU);
            worker_2.DisplayInfo();
            work worker_3;
            worker_3.name = "Roman";
            worker_3.university = Convert.ToString(university.KAI);
            worker_3.DisplayInfo();

        }
    }
}
