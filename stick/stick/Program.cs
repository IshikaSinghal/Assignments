using System;
using System.Linq;

namespace stick
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            Console.Write("Enter the length of array:");
            length = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[length];
            
            //input array
            for (int i = 0; i < length; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //outer for loop
            for(int k = 0; k < length; k++)
            {
                if(arr[k]!=0)
                {
                    int min;
                    if (arr[0] != 0)
                    {
                        min = arr[0];
                    }
                    else
                    {
                        min = arr.Max();
                    }
                    for (int i = 0; i < length; i++)
                    {
                        if (arr[i] < min && arr[i] > 0)
                        {
                            min = arr[i];

                        }
                    }
                    Console.WriteLine("The min is:{0}", min);
                    int n = 0;
                    for (int i = 0; i < length; i++)
                    {
                        if (arr[i] == min || arr[i] > min)
                        {
                            arr[i] = arr[i] - min;
                            ++n;
                        }
                    }
                    Console.WriteLine("The stic out is {0}", n);
                    for (int i = 0; i < length; i++)
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
                
            }   

        }

    }
}
/*if (arr[i] == arr[j])
{
    for (int k = j; k < length - 1; k++)
    {
        arr[k] = arr[k + 1];
    }
    length--;
    j--;

static void stick(int[] arr, int length)
        {
                
            
            

        }



    for (i = 0; i < length; i++)
                {
                    for (int j = i + 1; j < length; j++)
                    {
                        if (arr[i] == 0)
                        {
                            for (int k = j; k < length - 1; k++)
                            {
                                arr[k] = arr[k + 1];
                            }
                            length--;
                            j--;
                            
                        }
                    
                    }
                
                }
/////////////////////////////////////////////////////
///


int min, i, k=0, count;
            int[] lenofcut = new int[10];
            min = arr[0];
            for (i = 0; i < length; i++)
            {
                if (arr[i] < min && arr[i] > 0)
                {
                    min = arr[i];

                }
                lenofcut[i] = min;
                k++
            }
            count = 0;
            for (i = 0; i < length; i++)
            {
                arr[i] = arr[i] - min;
                if (arr[i] == 0)
                {
                    count++;
                }
            }
            for (i = 0; i < k++; i++)
            {
                Console.WriteLine(lenofcut[i]);
            }


}*/

/*
 Console.WriteLine("Stick cut-");
            //Function for stick out
            void stick()
            {
                int min = arr[0];
                //This loop will calculate the minimum element

                for (int i = 0; i < length; i++)
                {
                    if (arr[i] < min && arr[i] > 0)
                    {
                        min = arr[i];

                    }
                }
                int n = 0;
                for (int i = 0; i < length; i++)
                {
                    if ((arr[i] == min) || (arr[i] > min))
                    {
                        arr[i] = arr[i] - min;
                        n++;
                    }
                }

                Console.WriteLine(n);

            }
            //This loop will recursively calls the function
            for (int i = 0; i < length; i++)
            {
                if (arr[i] != 0)
                {
                    stick();
                }
            }
 */