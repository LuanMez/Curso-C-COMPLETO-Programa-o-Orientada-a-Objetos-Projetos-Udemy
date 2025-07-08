using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomeDoPrograma {
    class Program {
        static void Main(string[] args) {
            //arquivo de origiem
            string sourcePath = @"c:\temp\file1.txt"; //o @ faz com que n precise de duas barras

            //arquivo de destino
            string targetPath = @"c:\temp\file2.txt";

            try {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                //instancioando um vetor com a linha do arquivo
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines) {
                    Console.WriteLine(line);
                }

            } catch (IOException e) {
                Console.WriteLine("An error ocorrued");
                Console.WriteLine(e.Message);
            }
        }
    }
}