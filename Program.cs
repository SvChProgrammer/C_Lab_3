// See https://aka.ms/new-console-template for more information
/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.*/
int num,r,sum=0,t;
    Console.WriteLine("Введите число: ");
         num = Convert.ToInt32(Console.ReadLine());  
            for(t=num; num!=0; num=num/10){
                r=num % 10;
                sum=sum*10+r;
                }
        if(t==sum)
             Console.Write("{0} Это палиндром!.\n",t);
        else
              Console.Write("{0} Это не палиндром!.\n",t);

