using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace c0725450
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Download();
            Console.ReadLine();
        }

        static async void Download()
        {
            await Network.Download();
            Console.WriteLine("Download complete");
        }

        //static void Download()
        //{
        //    Task.Run( () =>
        //    {
        //        Thread.Sleep(7000);
        //        Console.WriteLine("Download complete");
        //    }
        //        );
            
        //}
    }
    class Network
    {
        static public Task Download()
        {
            return Task.Run(() => Thread.Sleep(3000));
        }
    }
}
