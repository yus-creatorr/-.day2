// task1
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];
// int sum1=0;
// int sum2=0;
// for(int i = 0; i < a; i++)
// {
//     arr[i]=Convert.ToInt32(Console.ReadLine());
// }

// for(int i = 0; i < a; i++)
// {
//     if (arr[i] % 2 == 0)
//     {
//         sum1+=arr[i];
//     }
//     if (arr[i] % 2 != 0)
//     {
//         sum2+=arr[i];
//     }
// }
// System.Console.WriteLine("Evens sum: "+sum1);
// System.Console.WriteLine("Ods sum: "+sum2);
// if (sum1 > sum2)
// {
//     System.Console.WriteLine("Sum of evens more "+sum1);
// }
// else
// {
//     System.Console.WriteLine("Sum of odds more");
// }

// task2
// int a =Convert.ToInt32(Console.ReadLine());
// int[] arr= new int[a];
// for(int i = 0; i < a; i++)
// {
//     arr[i]=Convert.ToInt32(Console.ReadLine());
// }
// int max=int.MinValue;
// int maxI=0;
// for(int i = 0; i < a; i++)
// {
//     if (arr[i] > max)
//     {
//         max=arr[i];
//         maxI=i;
//     }
// }
// System.Console.WriteLine("Max number is: "+ max);
// System.Console.WriteLine("The index of max number is: "+ maxI);


// task 3
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr= new int[a];
// int cnt=0;
// for(int i = 0; i < a; i++)
// {
//     arr[i]=Convert.ToInt32(Console.ReadLine());
// }
// for(int i = 0; i < a-1; i++)
// {
//     if (arr[i+1] > arr[i ])
//     {
//         cnt++;
//     }
// }
// System.Console.WriteLine("The answer is: "+ cnt);


// task4
// int a=Convert.ToInt32(Console.ReadLine());
// int[] arr=new int[a];
// int cnt=0;
// for(int i = 0; i < a; i++)
// {
//     arr[i]=Convert.ToInt32(Console.ReadLine());
// }
// for(int i = 0; i < a; i++)
// {
//     if (arr[i] < 0)
//     {
//         cnt++;
//         arr[i]=-arr[i];
//     }

// }
// System.Console.WriteLine("Changed: "+cnt);


// task5
// int a= Convert.ToInt32(Console.ReadLine());
// int cnt=0;
// int[] arr=new int[a];
// for(int i = 0; i < a; i++)
// {
//     arr[i]=Convert.ToInt32(Console.ReadLine());
// }
// for(int i = 0; i < a; i++)
// {
//     if(arr[i]%2==0 && arr[i + 1] % 2 == 0)
//     {
//         cnt++;
//     }
// }
// System.Console.WriteLine("The max lenght: "+cnt);


// task 6??
// int a=Convert.ToInt32(Console.Read());
// int rev=0;
// int[ ] arr= new int[a];
// for(int i = 0; i < a; i++)
// {
//     arr[i]=Convert.ToInt32(Console.Read());
// }
// for(int i = a; i > 0; i /= 10)
// {
//     rev= rev * 10+i%10;
// }
// if (rev == a)
// {
//     System.Console.WriteLine("Yes it's a palindrom");
// }
// else
// {
//     System.Console.WriteLine("No it's not a palindrom");
// }


// task8
// int a = Convert.ToInt32(Console.ReadLine());

// int[] arr = new int[a];

// for (int i = 0; i < a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// int left = arr[0];

// for (int i = 0; i < a - 1; i++)
// {
//     arr[i] = arr[i + 1];
// }

// arr[a - 1] = left;

// for (int i = 0; i < a; i++)
// {
//     Console.Write(arr[i] + " ");
// }



