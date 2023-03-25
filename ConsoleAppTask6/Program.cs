namespace ConsoleAppTask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //l1:
            //Console.Write("Massivler ile muqayise olunacaq c:");
            //int c;
            //if(!int.TryParse(Console.ReadLine(),out c)) 
            //{
            //    Console.WriteLine("Duz yazsan bele olmazdi");
            //    goto l1;
            //}
            //l2:
            //Console.Write("Massivin uzunlugu:");
            //int n;
            //if(!int.TryParse(Console.ReadLine(),out n))
            //{
            //    Console.WriteLine("Reqem,reqem yaz");
            //    goto l2;
            //}
            //int[] a = new int[n];

            //for(int i = 0;i < a.Length; i++)
            //{
            //    l3:
            //    Console.Write($"a[{i}]=");
            //    if(!int.TryParse(Console.ReadLine(), out a[i]))
            //    {
            //        Console.WriteLine("Reqem yaz");
            //        goto l3;
            //    }
            //}
            // for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] > c)
            //    {
            //        Console.WriteLine($"A[{i}]= {a[i]} > C = {c}");
            //    }

            //}
            #endregion
            #region task2
            //l1:
            //    Console.WriteLine("Massiv ile muqayise olacaq c:");
            //    int c;
            //    if (!int.TryParse(Console.ReadLine(), out c))
            //    {
            //        Console.WriteLine("Reqem");
            //        goto l1;
            //    }
            //l2:
            //    int n;
            //    Console.WriteLine("Massivin uzunlugu");
            //    if(!int.TryParse(Console.ReadLine(),out n ))
            //    {
            //        Console.WriteLine("Reqem");
            //        goto l2;
            //    }
            //    int[] a = new int[n];
            //    double eded = 0;
            //l3: for(int i = 0; i < n; i++) 
            //    {
            //        Console.WriteLine($"A[{i}]");
            //        if(!int.TryParse(Console.ReadLine(),out a[i]))
            //        {
            //            Console.WriteLine("Reqem");
            //            goto l3;
            //        }
            //        eded += a[i];
            //    }

            //    for(int i = 0;i<a.Length;i++)
            //    {


            //        if((eded / n) > c)
            //        {
            //            Console.WriteLine($"{eded / n} > C");
            //        }
            //    }
            #endregion
            #region task3
            //l1:
            //    Console.WriteLine("Massiv ile muqayise olacaq c:");
            //    int c;
            //    if (!int.TryParse(Console.ReadLine(), out c))
            //    {
            //        Console.WriteLine("Reqem");
            //        goto l1;
            //    }
            //l2:
            //    int n;
            //    Console.WriteLine("Massivin uzunlugu");
            //    if (!int.TryParse(Console.ReadLine(), out n))
            //    {
            //        Console.WriteLine("Reqem");
            //        goto l2;
            //    }
            //    int[] a = new int[n];
            //    double eded = 0;
            //l3: for (int i = 0; i < n; i++)
            //    {
            //        Console.WriteLine($"A[{i}]");
            //        if (!int.TryParse(Console.ReadLine(), out a[i]))
            //        {
            //            Console.WriteLine("Reqem");
            //            goto l3;
            //        }
            //        eded = a[i] * a[i];
            //    }

            //    for (int i = 0; i < a.Length; i++)
            //    {


            //        if ((eded / n) > c)
            //        {
            //            Console.WriteLine($"{eded / n} > C");
            //        }
            //    }
            #endregion
            #region task4
            //l1:
            //    Console.Write("Massivler ile muqayise olunacaq c:");
            //    int c;
            //    if (!int.TryParse(Console.ReadLine(), out c))
            //    {
            //        Console.WriteLine("Duz yazsan bele olmazdi");
            //        goto l1;
            //    }
            //l2:
            //    Console.Write("Massivin uzunlugu:");
            //    int n;
            //    if (!int.TryParse(Console.ReadLine(), out n))
            //    {
            //        Console.WriteLine("Reqem,reqem yaz");
            //        goto l2;
            //    }
            //    int[] a = new int[n];

            //    for (int i = 0; i < a.Length; i++)
            //    {
            //    l3:
            //        Console.Write($"a[{i}]=");
            //        if (!int.TryParse(Console.ReadLine(), out a[i]))
            //        {
            //            Console.WriteLine("Reqem yaz");
            //            goto l3;
            //        }
            //    }

            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (a[i] > c)
            //        {
            //            Console.WriteLine($"(A[{i}] = {a[i]}) > (C = {c})");
            //        }
            //    }
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        Array.Sort(a);
            //        Array.Reverse(a);
            //        foreach (var item in a)
            //        {
            //            if (item > c)
            //            {
            //                Console.WriteLine(item);
            //            }
            //        }

            //    }
            #endregion
            #region task5
            //l1:
            //    Console.Write("Massivler ile muqayise olunacaq c:");
            //    int c;
            //    if (!int.TryParse(Console.ReadLine(), out c))
            //    {
            //        Console.WriteLine("Duz yaz");
            //        goto l1;
            //    }
            //l2:
            //    Console.Write("Massivin uzunlugu:");
            //    int n;
            //    if (!int.TryParse(Console.ReadLine(), out n))
            //    {
            //        Console.WriteLine("Reqem yaz");
            //        goto l2;
            //    }
            //    int[] a = new int[n];

            //    for (int i = 0; i < a.Length; i++)
            //    {
            //    l3:
            //        Console.Write($"a[{i}]=");
            //        if (!int.TryParse(Console.ReadLine(), out a[i]))
            //        {
            //            Console.WriteLine("Reqem yaz");
            //            goto l3;
            //        }
            //    }
            //    int max = 0;
            //    int min = 0;
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //   
            //        if (max < a[i])
            //        {
            //            max = a[i];
            //        }
            //    }

            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (a[i] > c)
            //        {
            //            Console.WriteLine($"{max} > (C = {c})");
            //            break;
            //        }
            //    }


            #endregion
            #region task6
            //l1:
            //    Console.WriteLine("Massivin uzunlugu");
            //    int n;
            //    if (!int.TryParse(Console.ReadLine(), out n))
            //    {
            //        Console.WriteLine("Reqem");
            //        goto l1;
            //    }

            //    int[] x = new int[n];
            //    int[] y = new int[n];


            //    for (int i = 0; i < n; i++)
            //    {
            //    l2:
            //        Console.Write($"x[{i}]=");
            //        if (!int.TryParse(Console.ReadLine(), out x[i]))
            //        {
            //            Console.WriteLine("Reqem yaz");
            //            goto l2;
            //        }

            //     l3:  
            //        Console.Write($"y[{i}]=");
            //        if (!int.TryParse(Console.ReadLine(), out y[i]))
            //        {
            //            Console.WriteLine("Reqem yaz");
            //            goto l3;
            //        }
            //        if (x[i] == y[i] * y[i]) 
            //        {
            //            Console.WriteLine($"(x[{i}]={x[i]}) == (y[{i}]={y[i]}^2)");
            //        }
            //    }
            #endregion
            #region task7
            //l1:
            //Console.Write("Massivin uzunlugu:");
            //int n;
            //if (!int.TryParse(Console.ReadLine(), out n))
            //{
            //    Console.WriteLine("Reqem yaz");
            //    goto l1;
            //}
            //int[] a = new int[n];

            //for (int i = 0; i < a.Length; i++)
            //{
            //l2:
            //    Console.Write($"a[{i}]=");
            //    if (!int.TryParse(Console.ReadLine(), out a[i]))
            //    {
            //        Console.WriteLine("Reqem yaz");
            //        goto l2;
            //    }
            //}
            //decimal max = a[0];
            //decimal min = a[0];
            //decimal HendesiO = 0;
            //decimal EdediO = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (min > a[i])
            //    {
            //        min = a[i];
            //    }
            //    else if (max < a[i])
            //    {
            //        max = a[i];
            //    }
            //    HendesiO = (min * max) / 2;
            //    EdediO = (max + min) / 2;
            //}
            //Console.WriteLine($"Hendesi Orta:{HendesiO}");
            //Console.WriteLine($"Ededi Orta:{EdediO}");
            #endregion
            #region task8
            //int a1 = 2;
            //int[] mass = new int[a1];
            //int[] mass1 = new int[a1];
            //int[] mass2 = new int[a1];
            //for(int i = 0;i< a1;i++) 
            //{l1:
            //    Console.Write($"mass[{i}]=");

            //    if (!int.TryParse(Console.ReadLine(), out mass[i]))
            //    {
            //        Console.WriteLine("reqem");
            //goto l1;
            //    }
            //    Console.Write($"mass1[{i}]=");
            //l2:
            //    if (!int.TryParse(Console.ReadLine(), out mass1[i]))
            //    {
            //        Console.WriteLine("reqem");
            //goto l2;
            //    }
            //    if (mass1[i] * mass[i] < 0)
            //    {
            //        continue;
            //    }
            //    mass2[i] = mass1[i] * mass[i];

            //    Console.WriteLine($"Mass2[{i}]={mass2[i]}");

            //}



            #endregion
            #region task9
            //int a = 10;
            //int b = 8;
            //int c = 2;
            //int d = 4;
            //int e = 8;
            //decimal[] mass = new decimal[a];
            //decimal[] mass1 = new decimal[b];
            //decimal[] mass2 = new decimal[b];

            //for (int i = 0; i < c; i++)
            //{
            //l1:
            //    Console.Write($"Mass[{i}]=");
            //    if (!decimal.TryParse(Console.ReadLine(), out mass[i]))
            //    {
            //        Console.WriteLine("reqem");
            //        goto l1;
            //    }
            //    mass[i] = mass[i] * mass[i];

            //}

            //for (int i = c; i < d; i++)
            //{
            //l2:
            //    Console.Write($"Mass[{i}]=");
            //    if (!decimal.TryParse(Console.ReadLine(), out mass[i]))
            //    {
            //        Console.WriteLine("reqem");
            //        goto l2;
            //    }
            //    mass1[i] = mass[i] / 4;


            //}

            //for (int i = d; i < e; i++)
            //{
            //l3:
            //    Console.Write($"Mass[{i}]=");
            //    if (!decimal.TryParse(Console.ReadLine(), out mass[i]))
            //    {
            //        Console.WriteLine("reqem");
            //        goto l3;
            //    }
            //    mass2[i] = mass[i] / 4;
            //}
            //for (int i = 0; i < a; i++)
            //{
            //    Console.WriteLine($"mass[{i}]={mass[i]}");
            //}
            //Console.WriteLine("================================");
            //for (int i = 0; i < a; i++) 
            //{
            //    Console.WriteLine($"mass1[{i}]={mass1[i]}");
            //}
            //Console.WriteLine("================================");
            //for (int i = 0; i < a; i++)
            //{
            //    Console.WriteLine($"mass2[{i}]={mass2[i]}");
            //}
            #endregion
            #region task10
            //l1:
            //    Console.Write("Massivin uzunlugu:");
            //    int n;
            //    if (!int.TryParse(Console.ReadLine(), out n))
            //    {
            //        Console.WriteLine("Reqem yaz");
            //        goto l1;
            //    }
            //    int[] x = new int[n];

            //    for (int i = 0; i < x.Length; i++)
            //    {
            //    l2:
            //        Console.Write($"a[{i}]=");
            //        if (!int.TryParse(Console.ReadLine(), out x[i]))
            //        {
            //            Console.WriteLine("Reqem yaz");
            //            goto l2;
            //        }
            //    }
            //    int max = 0;
            //    int max1 = 0;
            //    for (int i = 0; i < x.Length; i++)
            //    {
            //        if (x[i] < 0)
            //        {
            //            if (max > x[i])
            //            {
            //                max = x[i];
            //            }

            //        }
            //       max1 = max;
            //    }
            //    Console.WriteLine(max1);
            #endregion
            #region task11

            //  Random r = new Random();
            //  int n;
            //l1:
            //  Console.Write("Massivin uzunlugun daxil edin:");
            //  if (!int.TryParse(Console.ReadLine(), out n))
            //  {
            //      goto l1;
            //  }
            //  int[] mass = new int[n];
            //  for (int i = 0; i < n; i++)
            //  {
            //      mass[i] = r.Next(100);
            //  }
            //  for (int i = 0; i < n; i++)
            //  {
            //      Array.Sort(mass);
            //      Array.Reverse(mass);
            //      Console.WriteLine($"mass[{i}]={mass[i]}");
            //  }

            #endregion
            #region task12
            //decimal EdediO = 0;
            //decimal HendesiO = 1;
            //int[] mass = new int[20];
            //for (int i = 0; i < 10; i++)
            //{ l1:
            //    Console.Write($"mass[{i}]:");
            //    if (!int.TryParse(Console.ReadLine(), out mass[i]))
            //    {
            //        goto l1;
            //    }
            //    EdediO += mass[i];

            //}
            //EdediO /= 10; 
            //for (int i = 10; i < 20; i++)
            //{
            //l1:
            //    Console.Write($"mass[{i}]:");
            //    if (!int.TryParse(Console.ReadLine(), out mass[i]))
            //    {
            //        goto l1;
            //    }
            //    HendesiO = HendesiO * mass[i];
            //}
            //HendesiO/= 10;
            //Console.WriteLine($"Ededi Orta:{EdediO}");
            //Console.WriteLine($"Hendesi Orta:{HendesiO}");
            #endregion
        }
    }
}