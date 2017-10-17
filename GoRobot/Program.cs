using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCrawler;
namespace GoRobot
{
    public class Program
    {
        static void Main(string[] args)
        {
            Start start = new Start();
            start.Run();
        }

        public class Start
        {
            public void Run ()
            {
                Site site = new Site();
                site.CarregaPosts();
            }
        }
    }
}
