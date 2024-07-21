

using System.Threading.Channels;

int counter = 0;
Console.Write("Limit giriniz: ");
int limit = int.Parse(Console.ReadLine());
if (limit >= 0)
{
    while (counter <= limit)
    {
        Console.Write(counter + ": ");
        Console.WriteLine(" Ben bir Patika'lıyım ");
        counter++;
        
    }
    
}
else
{
    while (counter >= limit)
    {
        Console.Write(Math.Abs(counter) + ": ");
        Console.WriteLine(" Ben bir Patika'lıyım ");
        counter--;
    }
}




int counter2 = 0;
Console.Write("Limit giriniz: ");
var limit2 = Convert.ToInt16(Console.ReadLine());
do
{
    Console.Write(counter2 + ": ");
    Console.WriteLine(" Ben bir Patika'lıyım ");
    counter2++;
    
}
while (counter2 <= Math.Abs(limit2));

//Do while yaptığımızda koşulu sonda kontrol ediyor.



