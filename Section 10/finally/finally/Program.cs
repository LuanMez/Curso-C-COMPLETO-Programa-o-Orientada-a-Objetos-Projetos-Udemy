﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class ProcessFile {
    public static void Main() {
        FileStream fs = null;
        try {
            fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            Console.WriteLine(line);
        } catch (FileNotFoundException e){
            Console.WriteLine(e.Message);
        } finally {
            if (fs != null) {
                fs.Close();
            }
        }
    }
}