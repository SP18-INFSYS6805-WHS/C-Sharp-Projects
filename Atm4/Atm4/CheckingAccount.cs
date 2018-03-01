using System;
using System.Collections.Generic;
using System.Text;

namespace Atm4
{
    //class CheckingAccount : Account
    //{
    //    private decimal _interest;
    //    private DateTime dtDayOne = new DateTime(2015,10,28,12,0,0);

    //    //public CheckingAccount(decimal balance, decimal fee) : base(balance)
    //    //{
    //    //    Fee = fee;
    //    //}

    //    //public decimal Fee
    //    //{
    //    //    get { return _fee; }
    //    //    set
    //    //    {
    //    //        if(value >= 0 )
    //    //        {
    //    //            _fee = value;
    //    //        }
    //    //        else
    //    //        {
    //    //            throw new Exception("Fee Error! Fee cannot be less than zero");
    //    //        }
    //    //    }
    //    //}

    //    public override void Credit(decimal amount)
    //    {
            
    //        base.Credit(amount);
    //        Balance -= Fee;

    //    }

    //    public override bool Debit(decimal amount)
    //    {
    //        if (base.Debit(amount))
    //        {
    //            Balance -= Fee;
    //            return true;
    //        }
    //        return false;
           
    //    }

    //    //Calc interest

    //    public decimal CalcInterest()
    //    {
    //        Console.WriteLine("Days Difference inside CalcInterest: {0}", CalcDays());

    //        decimal interest = (InterestRate / 365) * CalcDays();
    //        Console.WriteLine("The interest in CalcInterest: {0}", interest);
    //        return Balance * InterestRate;
    //    }

    //    // Calc number of days since last update
    //    public int CalcDays()
    //    {
    //        DateTime curDate = DateTime.UtcNow;
    //        //Console.WriteLine("last date..{0}", dtDayOne);
    //        //Console.WriteLine("Current date..{0}", curDate);
    //        TimeSpan ts = curDate.ToUniversalTime().Subtract(dtDayOne.ToUniversalTime());
    //        int daysDif = Convert.ToInt32(Math.Floor(ts.TotalDays));   //get rid of partial days
    //        //Console.WriteLine("Days Difference: " + daysDif);
    //        // Console.WriteLine(dtDayOne);
    //        dtDayOne = curDate.ToUniversalTime();
    //        Console.WriteLine("dtDayOne is now: {0}", dtDayOne);
    //        return daysDif;

    //    }


    //}
}
