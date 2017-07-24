using System;
using System.Collections.Generic;
//using System.Linq;
public class Kata
{
    #region Convert string to camel case
    public static string ToCamelCase(string str)
    {
        string[] tmp = str.Replace('_', '-').Split('-');
        if (tmp.Length == 1)
            return str;
        for (int i = 1; i < tmp.Length;i++ )
        {
            tmp[i] = tmp[i].Substring(0, 1).ToUpper() + tmp[i].Substring(1);
        }
        return string.Join("",tmp);
    }
    #endregion

    #region Gap in Primes
    public static long[] Gap(int g, long m, long n)
    {
        long start, stop = nextPrime(m-1);
        do
        {
            start = stop;
            stop = nextPrime(start);
            if (stop > n)
                return null;

        } while ((stop - start) != g);

        return new long[] { start, stop } ;
    } 
    static long nextPrime(long m)
    {
        for(long i=m+1;;i++)
        {
            if (isPrime(i))
                return i;
        }
    }

    static bool isPrime(long m)
    {
        if (m == 2 || m == 3)
            return true;

        for(long i=2;i<m;i++)
        {
            if (m % i == 0)
                return false;
            if (i > (m / i))
                break;
        }
        return true;
    }
    #endregion

    #region Good vs Evil
    public static string GoodVsEvil(string good, string evil)
    {
        int[] gw = { 1, 2, 3, 3, 5, 10 };
        int[] bw = { 1, 2, 2, 2, 3, 5, 10 };

        int gsum = 0, bsum = 0;
        string[] gnum= good.Split(' ');
        string[] bnum = evil.Split(' ');

        for (int i = 0; i < gnum.Length; i++)
            gsum += int.Parse(gnum[i]) * gw[i];

        for (int i = 0; i < bnum.Length; i++)
            bsum += int.Parse(bnum[i]) * bw[i];

        if (gsum > bsum)
            return "Battle Result: Good triumphs over Evil";
        else if (gsum < bsum)
            return "Battle Result: Evil eradicates all trace of Good";
        else
            return "Battle Result: No victor on this battle field";
    }

    #endregion

    #region Car Park Escape
    public string[] escape(int[,] carpark)
    {
        List<string>  rt = new List<string>();

        int curPos;
        //int stairPos;
        
        for(int i=0;i<carpark.GetLength(1);i++)
        {
            if (carpark[0,i]==2)
            {
                curPos=i;
                break;
            }
        }

         for(int i=0;i<carpark.Length;i++)
        {
            
            if (i<carpark.Length -1)
            {
                for (int j = 0; j < carpark.GetLength(1); j++)
                {
                    if (carpark[0, i] == 1)
                    {
                        curPos = i;
                        break;
                    }
                }
            }
            else
            {

            }
        }
        return rt.ToArray();
    }
    public int findindex(int[] level,int s)
    {
        for(int i=0;i<level.Length;i++)
        {
            if (level[i] == s)
                return i;
        }
        return -1;
    }
    #endregion

    #region Twice linear
    public static int DblLinear(int n)
    {
         SortedSet<int> lst= new SortedSet<int>() {1};
        for (int i = 0; i < n; i++)
        {
            int first = lst.Min;
            lst.Add(first * 2 + 1);
            lst.Add(first * 3 + 1);
            lst.Remove(first);
        }
        return lst.Min;
    }
    #endregion

    #region Wave Sorting
    public static void WaveSort(int[] arr)
    {
        List<int> lst = new List<int>(arr);
        lst.Sort();
        for (int i = 0; i < arr.Length-1 ; i++)
        {
            arr[i] = i % 2 == 0 ? lst[lst.Count -1-i/2] : lst[i / 2];
        }
    }
    #endregion
}
