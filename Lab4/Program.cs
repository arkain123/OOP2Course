using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // оригинальный класс, который требуется адаптировать
            Original original = new Original();
            // создание адаптера
            Adapter adapter = new Adapter();

            Client client = new Client(adapter);

            // вызов метода Out
            client.ValuesOut(10, 3.5, 'A');
        }
    }
}
