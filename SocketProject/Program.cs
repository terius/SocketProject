using System;
using System.Threading;
using System.Threading.Tasks;

namespace SocketProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }



        #region Task Test
        static void TestTask()
        {
            string c = "";
            Action<string, string> a1 = (aa, bb) => { c = aa + bb; };
            Action a2 = () => { c = "CCCCCCC"; };
            var t = Task.Run(async () =>
            {
                return await GetNowTime();
            });

            Console.WriteLine("start ThreadId:" + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(t.Result);
            Console.WriteLine("end ThreadId:" + Thread.CurrentThread.ManagedThreadId);
        }
        static async Task<string> GetNowTime()
        {
            Thread.Sleep(1000);
            var t = await Task.FromResult(DateTime.Now.ToLongTimeString() + "   ThreadId:" + Thread.CurrentThread.ManagedThreadId);
            return t;
        }

        #endregion



    }
}
