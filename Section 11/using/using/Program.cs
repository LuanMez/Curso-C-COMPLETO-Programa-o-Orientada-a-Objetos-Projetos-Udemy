﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomeDoPrograma {
    class Program {
        static void Main(string[] args) {

            string path = @"c:\temp\file1.txt";

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            } catch (IOException e) {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}