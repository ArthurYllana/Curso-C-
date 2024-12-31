string[] vect = new string[]{"Maria", "Alex","Bob"};

for(int i = 0; i < vect.Length; i++){
    System.Console.WriteLine(vect[i]);
}

System.Console.WriteLine("------------------------------");

foreach (string obj in vect){
    System.Console.WriteLine(obj);
}