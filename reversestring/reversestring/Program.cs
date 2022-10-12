/*using System;
namespace reversestring
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int len = 0;
            str =Console.ReadLine();
            Console.WriteLine(str);
            foreach(char c in str)
            {
                len++;
            }
            Console.Write("The length of string is:");
            Console.WriteLine(len);
            if(len == 1)
            {
                Console.WriteLine(str);
            }
            else
            {
                int i=0;
                string resultstr = " ";
                while (i<len)
                {

                    /*while (i<len && str[i] != ' ')
                    {
                        substr[k] = str[i];
                        k++;
                        ++i;
                    }*/
/*while (i < len && str[i] == ' ')
{
    i++;
}
int j = i + 1;
while(j<len && str[j]!=' ')
{
    j++;
}
string[] newstr=str.Split(' ');

if (resultstr.Length==0)
{
    resultstr = newstr+" ";

}
else
{
    resultstr = newstr+" "+resultstr;

}
i = j + 1;
}
Console.WriteLine(resultstr);
}
}
}

}*/
using System;
namespace reversestring
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string str;
            int len = 0;
            Console.WriteLine("Enter the string:");
            str = Console.ReadLine();
            Console.WriteLine(str);
            foreach (char c in str)
            {
                len++;
            }
            Console.Write("The length of string is:");
            Console.WriteLine(len);
            for(int i = len-1; i>=0; i--)
            {
                
                if (str[i]!=' ')
                {
                    count++;
                }
                else if (str[i]==' ')
                {
                    for(int j = i+1;count>0; j++,count--)
                    {
                        Console.Write(str[j]);
                    }
                    Console.Write(" ");
                }
            }
            for (int j = 0; j < count; j++)
            {
                Console.WriteLine(str[j]);
            }

        }
    }
}
