using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomeDoPrograma {
    class Program {
        static void Main(string[] args) {

            string path = @"c:\temp\myfolder";

            try {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders) {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in files) {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(@"c:\temp\myfolder\newfolder");
            } catch (IOException e) {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}