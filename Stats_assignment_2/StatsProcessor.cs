using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsAssignment
{
    internal class StatsProcessor

    {

        internal int[] Numbers { private get; set; }



        //function to sort the array
        internal void sorting(int[] data, int n)
        {
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[i] > data[j])
                    {
                        int temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }

                }

            }
        }


        //function to find mean
        internal double findmean(int[] data, int n)
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += data[i];

            }

            return (double)sum / (double)n;

        }

        //function to find median
        internal double findmedian(int[] data, int n)
        {
            if (n % 2 != 0)
            {
                return (double)data[n / 2];

            }
            else
            {
                return (double)(data[(n - 1) / 2] + data[n / 2]) / 2.0;
            }

        }


        //function to find mode
        internal double findmode(int[] data, int n)
        {
            int maximum_num = -1;
            int max_repeat = -1;

            for (int i = 0; i < n; i++)
            {
                int count = 0;

                for (int j = 0; j < data.Length; j++)
                {

                    if (data[i] == data[j])
                    {
                        count++;
                    }
                }

                if (count > max_repeat)
                {
                    maximum_num = data[i];
                    max_repeat = count;
                }

            }

            return maximum_num;

        }



    }
}
