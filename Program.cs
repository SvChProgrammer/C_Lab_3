/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.*/
int num,r,sum=0, newValue;
    Console.WriteLine("Введите число: ");
         num = Convert.ToInt32(Console.ReadLine());  
            for(newValue=num; num!=0; num=num/10){
                r=num % 10;
                sum=sum*10+r;
                }
        if(newValue==sum)
             Console.Write("Число {0} Это палиндром!.\n",newValue);
        else
              Console.Write("Число {0} Это не палиндром!.\n",newValue);

/* 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.*/


int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");

int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Distance(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}

double distance =  Math.Round (Distance(x1, x2, y1, y2, z1, z2), 2);
Console.WriteLine($"Расстояние =  {distance}");


/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
 //int i = 1;
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine("Результат");
        Console.WriteLine("{0}^3 = {1}", i, Math.Pow(i, 3));
     }

