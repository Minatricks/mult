using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Conccurency;

namespace Client
{
    class Program
    {
        private static CommonQueue<int> _commonQueue;

        static void Main(string[] args)
        {
            //Example1();
            //Example2();
            //Example3();
            //Example4();
            Console.ReadKey();
        }

        #region Example4

        public static void Example4()
        {
            SharedCollection shared = new SharedCollection();
            for(int i =0;  i < 5; i++)
            {
                Task.Run(() => Console.WriteLine(shared[2]));
            }
        }


        #endregion

        #region Example3
        public static void Example3()
        {
            Task3();
            string S = Console.ReadLine();
        }

        static async void Task3()
        {
            await Task.Run(() => Thread.Sleep(10000));
            Console.WriteLine("All data received");
        }
        #endregion

        #region Example2
        static void Example2()
        {
            SelfMultiplyArray array = new SelfMultiplyArray((int)Math.Pow(10, 6), 20);
            var result = array.Multiply();
        }

        #endregion

        #region Example1

        static void Example1()
        {
            _commonQueue = new CommonQueue<int>();
            List<int> checkList = new List<int>();
            for (int i = 0; i < 66; i++)
            {
                new Thread(() => PutElements(i)).Start();
                new Thread(() => GetElements()).Start();
            }
            Console.ReadLine();

        }

        static void PutElements(int element)
        {
            Thread.Sleep(100 * element);
            Console.WriteLine("Count " + _commonQueue.Count);
            _commonQueue.Enqueue(element);
        }

        static void GetElements()
        {
            Console.WriteLine(_commonQueue.Dequeue());
        }
        #endregion
    }
}
