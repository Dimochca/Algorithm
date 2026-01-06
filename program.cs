using System;
using System.Threading;

namespace AlgorithmApp
{
    class Program
    {
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            Thread.Sleep(1000);
            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            Thread.Sleep(2000);
            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            Thread.Sleep(3000);
        }

        static void Main()
        {
            User currentUser = GetUser();

            Console.WriteLine($"Привет, {currentUser.Name}!");

            if (!currentUser.IsPremium)
            {
                ShowAds();
            }
            else
            {
                Console.WriteLine("Премиум-подписка активна.");
            }
        }

        static User GetUser()
        {
            return new User();
        }
    }
}
