/*Task1. The user enters M numbers from the keyboard. 
Count how many numbers greater than 0 the user entered.
*/

/*
int count = 0;
Console.WriteLine("Please, input numder M: ");
int m = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    Console.WriteLine("Please, input next number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number >= 0)
    {
        count++; 
    }
    
}
Console.WriteLine($"The quantity of positive numbers is equal to { count }");
*/

/*Task2. Write a program that finds the intersection point of two straight lines
 given by the equations y = k1 * x + b1, y = k2 * x + b2; 
 the values b1, k1, b2 and k2 are set by the user.
 */


 double k1, b1, k2, b2, x, y;

Console.WriteLine("Input the coefficient k1: ");
k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the free coefficient b1: ");
b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the coefficient k2: ");
k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the free coefficient b2: ");
b2 = Convert.ToInt32(Console.ReadLine());
if (k1 == k2 && b1 != b2)
{
    Console.WriteLine("These lines coincide and are one line ");

}
else if(k1 == k2)

{
    Console.WriteLine("These lines are parallel and have no intersection ");
}


else if (k1 != k2 && b1 != b2)
{
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;

Console.WriteLine("The point of intersection of two straight lines: (" + x + "," + y + ")");
}

