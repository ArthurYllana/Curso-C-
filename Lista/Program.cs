using System;
using System.Collections.Generic;

List<string> list = new List<string> ();
list.Add("Maria");
list.Add("Arthur");
list.Add("Pedro");
list.Add("Ana Paula");
list.Add("João");
list.Add("Maria");
list.Insert(2, "Lucas");

foreach (string obj in list){
    System.Console.WriteLine(obj);
}

System.Console.WriteLine("List count: " + list.Count);
System.Console.WriteLine("------------------------------------");

string s1 = list.Find(x => x[0] == 'A');
System.Console.WriteLine("Fist 'A': " + s1);

string s2 = list.FindLast(x => x[0] == 'A');
System.Console.WriteLine("Last 'A': " + s2);

System.Console.WriteLine("---------------------");

int pos1 = list.FindIndex(x => x[0] == 'A');
System.Console.WriteLine("First positin 'A' : " + pos1);

int pos2 = list.FindLastIndex(x => x[0] == 'A');
System.Console.WriteLine("First positin 'A' : " + pos2);

System.Console.WriteLine("-------------------------");

List<string> list2 = list.FindAll(x => x.Length == 5);
foreach(string obj in list2){
    System.Console.WriteLine(obj);
}

System.Console.WriteLine("--------------------------------------");

list.RemoveAt(2);
foreach (string obj in list)
{
    System.Console.WriteLine(obj);
}

System.Console.WriteLine("-----------------");

list.RemoveAll(x => x[0] == 'M');
foreach (string obj in list)
{
    System.Console.WriteLine(obj);
}
