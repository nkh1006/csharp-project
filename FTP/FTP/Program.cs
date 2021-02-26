using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FTP
{
    class Program
    {
        static void Main(string[] args)
        {
            // 다운로드를 받을 주소
            string start = "ftp://addr";

            // 다운로드를 받은 주소
            string end = "1kb.zip";

            using(WebClient client = new WebClient())
            {
                client.DownloadFile(start, end);
            }
            
        }
    }
}
