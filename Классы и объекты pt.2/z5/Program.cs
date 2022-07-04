using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z5
{
    class Program
    {
        public class products
        {
            public string article;
            public string name;
            public double price;

            public products(string article_, string name_, double price_)
            {
                article = article_;
                name = name_;
                price = price_;
            }
        }

        class Bill
        {
            List<products> ProdList = new List<products>();

            private int account_;
            private string customer_;
            private string provider_;

            private string article_;
            private int quantity_;

            public Bill(int account, string customer, string provider)
            {
                account_ = account;
                customer_ = customer;
                provider_ = provider;

                ProdList.Add(new products("Ylylyl01imt", "Wallpaper", 1209.90));
                ProdList.Add(new products("Iwlludy2B", "Paint", 456.50));
                ProdList.Add(new products("SlBlaCuHls7", "Brush", 190.00));

            }

            public int account { get { return account_; } }
            public string customer { get { return customer_; } }
            public string provider { get { return provider_; } }


            public void Order(string article, int quantity)
            {
                Console.WriteLine("\nВведите артикул товара: ");
                string article_ = Console.ReadLine();
                Console.WriteLine("Введите количество товара: ");
                int quantity_ = Convert.ToInt32(Console.ReadLine());

                products pr = ProdList.FirstOrDefault(c => c.article == article);
                double all = pr.price * quantity;

                Console.WriteLine("Аккаунт: " + account_ + "\nПокупатель: " + customer_ + "\nПоставщик: " + provider_ + "\nАртикул: " + article + "\nОбщая стоимость заказа: " + all);
            }

            public void NDS()
            {
                products cost = ProdList.FirstOrDefault(c => c.article == article_);
                double all = cost.price * quantity_ + (cost.price * quantity_ * 0.15);
                Console.WriteLine("Аккаунт: " + account_ + "\nПокупатель: " + customer_ + "\nПоставщик: " + provider_ + "\nАртикль: " + article_ + "\nОбщая стоимость заказа: " + all);
            }
        }


        static void Main(string[] args)
        {
            bool check = true;

            Console.WriteLine("Введите номер аккаунта: ");
            int account_ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваше имя: ");
            string customer_ = Console.ReadLine();
            Console.WriteLine("Введите поставщика: ");
            string provider_ = Console.ReadLine();

            Bill b = new Bill(account_, customer_, provider_);

            while (check)
            {
                b.Order("Ylylyl01imt", 1);
            }
            b.NDS();

            Console.ReadKey();
        }
    }
}
