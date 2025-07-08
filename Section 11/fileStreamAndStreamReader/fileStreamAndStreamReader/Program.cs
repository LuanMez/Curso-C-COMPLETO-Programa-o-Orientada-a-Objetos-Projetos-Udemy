using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileStreamAndStreamReader {
    class Program {
        static void Main(string[] args) {

            /* Logica com open atraves do ileStream
            string path = @"c:\temp\file1.txt";
            FileStream fs = null; //abrir o arquivo
            StreamReader sr = null; //tratar o arquivo

            try {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            } catch (IOException e) {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            } finally {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }*/

            //Logica com o File.OpenText

            string path = @"c:\temp\file1.txt";

            StreamReader sr = null; //tratar o arquivo

            try {
                sr = File.OpenText(path);
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            } catch (IOException e) {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            } finally {
                if (sr != null) sr.Close();
            }
        }
    }
}