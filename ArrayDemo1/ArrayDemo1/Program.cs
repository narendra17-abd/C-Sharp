// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] myarray = new int[5];                 // int[,] array = new int[2,3] 
Console.WriteLine("Enter 5 integer values ");      // learn jagged array
for (int i=0; i<5; i++)
{
    myarray[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Array Elements are ");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(myarray[i]);
}
Console.WriteLine("Length (or) size of an Array " + myarray.Length);
Array.Reverse(myarray);

Console.WriteLine("Array reversing Array Elements are ");
for (int i=0; i<5; i++)
{
    Console.WriteLine(myarray[i]);
}

Console.ReadLine();