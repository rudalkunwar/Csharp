using System;
using System.Collections.Generic;

public class ListPrac {
    public static void Main(string[] args) {
        List<Tuple<string, string, int>> mylist = new List<Tuple<string, string, int>>();

        mylist.Add(Tuple.Create("rudal", "9866115178", 21));
        mylist.Add(Tuple.Create("aaksh", "9866115177", 22));
        mylist.Add(Tuple.Create("dura", "9866115179", 23));
        mylist.Add(Tuple.Create("pratik", "9866115180", 21));
        mylist.Add(Tuple.Create("basant", "9866115188", 26));

        foreach (var item in mylist) {
            Console.WriteLine($"Name: {item.Item1}, Phone: {item.Item2}, Age: {item.Item3}");
        }
    }
}
