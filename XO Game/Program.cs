using System;

namespace XO_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            char[] arr = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int cell = 0;
            bool isDone;

            Console.WriteLine("Name of the first Gamer");
            name = Console.ReadLine();

            Player player1 = new Player(name);

            Console.WriteLine("Name of the second Gamer");
            name = Console.ReadLine();

            Player player2 = new Player(name);

            table(arr);

            while (true)
            {
                Console.WriteLine("Gamer " + player1.GetName() + " is on the move");
                cell = int.Parse(Console.ReadLine());
                arr[cell - 1] = 'X';

                table(arr);

                isDone = check(arr);
                if (isDone)
                {
                    Console.WriteLine("Winner is " + player1.GetName());
                    break;
                }

                Console.WriteLine("Gamer " + player2.GetName() + " is on the move");
                cell = int.Parse(Console.ReadLine());
                arr[cell - 1] = 'O';

                table(arr);

                isDone = check(arr);
                if (isDone)
                {
                    Console.WriteLine("Winner is " + player2.GetName());
                    break;
                }

            }
        }

        private static bool check(char[] arr)
        {
            if (arr[0] == arr[1] && arr[1] == arr[2])
                {
                return true;
                }
            if (arr[3] == arr[4] && arr[4] == arr[5])
                {
                    return true;
                }
            if (arr[6] == arr[7] && arr[7] == arr[8])
                {
                    return true;
                }
            if (arr[0] == arr[3] && arr[3] == arr[6])
                {
                    return true;
                }
            if (arr[1] == arr[4] && arr[4] == arr[7])
                {
                    return true;
                }
            if (arr[2] == arr[5] && arr[5] == arr[8])
                {
                    return true;
                }
            if (arr[0] == arr[4] && arr[4] == arr[8])
                {
                    return true;
                }
            if (arr[2] == arr[4] && arr[4] == arr[6])
                {
                    return true;
                }
            return false;
        }

        private static void table(char[] arr)
        {
            
            Console.WriteLine("  {0}  |  {1}  |   {2}", arr[0], arr[1], arr[2]);
            Console.WriteLine("-----|-----|-----");
            Console.WriteLine("  {0}  |  {1}  |   {2}", arr[3], arr[4], arr[5]);
            Console.WriteLine("-----|-----|-----");
            Console.WriteLine("  {0}  |  {1}  |   {2}", arr[6], arr[7], arr[8]);
        }
    }
}
