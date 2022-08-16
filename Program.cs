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

