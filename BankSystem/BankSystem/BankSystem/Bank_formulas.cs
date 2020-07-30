using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class Bank_formulas
    {
        //function for  calculating of pension

        public int finish_pension(int ages_of_the_work , int level_of_clasification)
        {
            int sum_fp = ages_of_the_work * level_of_clasification;

            int sum_fp_result = sum_fp *22 / 100;

            return sum_fp_result;
        }
       
    }
}
