using Pain;
GeneticCustomList<int> generic = new GeneticCustomList<int>();

generic.Add(9);
generic.Add(8);
generic.Add(7);
generic.Add(6);
generic.Add(5);
generic.Add(4);

generic.Remove(4);

//************CONSOLE******************
foreach (int i in generic.FindAll(num => num < 10))
{
    Console.WriteLine(i);
}

//Console.WriteLine(generic.Find(num => num < 10));
//Console.WriteLine(generic.Find(num => num > 10));
//Console.WriteLine(generic.Contains(10));
//Console.WriteLine(generic.Exists(num => num > 1));
//Console.WriteLine(generic.Count);
//Console.WriteLine(generic.Capacity);
