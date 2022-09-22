using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
      Console.WriteLine("posejfdldjsf");
      string s = Console.ReadLine();

      hash h = new hash();
      int res = h.compute_hash(s);
      
      Console.WriteLine(res.ToString());

      SortedList<int,byte> li = new SortedList<int,byte>();
      

    }
}