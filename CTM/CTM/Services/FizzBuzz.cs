using CTM.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTM.Services
{
    public class FizzBuzz : IFizzBuzzService
    {

        /// <summary>
        /// FizzBuzz Actual Implementation
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
         List<string> IFizzBuzzService.FizzBuzz(int n)
        {
            List<string> resultvalue = new List<string>();
            try
            {
               
                foreach (int i in Enumerable.Range(1, n))
                {

                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        resultvalue.Add("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        resultvalue.Add("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        resultvalue.Add("Buzz");
                    }
                    else
                    {
                        resultvalue.Add(Convert.ToString(i));
                    }

                }
            }
            catch (Exception e) //Return Exception if any issues
            {
                return new List<string> { e.Message };
            }
            return resultvalue;
        }
    }
}
