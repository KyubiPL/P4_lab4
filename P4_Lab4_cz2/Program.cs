using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace P4_Lab4_cz2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            var google = new Website("http://google.pl", "/");
            var ath = new Website("http://ath.bielsko.pl", "/");
            var wikipedia = new Website("http://pl.wikipedia.org", "/wiki/.Net_Core");
            var yt = new Website("http://youtube.com", "/");
            var ath2 = new Website("http://ath.bielsko.pl", "/graficzne-formy-przekazu-informacji");

            var tasks = new List<Task<string>>();

            stopwatch.Start();
             tasks.Add(google.Download());
            Console.WriteLine(stopwatch.Elapsed);
             tasks.Add(ath.Download());
            Console.WriteLine(stopwatch.Elapsed);
             tasks.Add(wikipedia.Download());
            Console.WriteLine(stopwatch.Elapsed);
             tasks.Add(yt.Download());
            Console.WriteLine(stopwatch.Elapsed);
             tasks.Add(ath2.Download());
            Console.WriteLine(stopwatch.Elapsed);

            Console.WriteLine("---------------");

            await Task.WhenAny(tasks);
            Console.WriteLine(stopwatch.Elapsed);
            var htmls=await Task.WhenAll(tasks);
            Console.WriteLine(stopwatch.Elapsed);

            foreach (var html in htmls)
            {
                Console.WriteLine(html.Length);
            }

            //var html = google.Download();
            //Console.WriteLine(stopwatch.Elapsed);
            //Console.WriteLine(html);
            //Console.WriteLine(stopwatch.Elapsed);
        }
    }
}
