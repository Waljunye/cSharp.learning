using System;
namespace cSharp.learning
{
    // number of month enumeration 
    enum Month
    {
        JANUARY = 1,
        FEBRUARY = 2,
        MARCH = 3,
        APRIL = 4,
        MAY = 5,
        JUNE = 6,
        JULY = 7,
        AUGUST = 8,
        SEPTEMBER = 9,
        OCTOBER = 10,
        NOVEMBER = 11,
        DECEMBER = 12
    }
    // Days in mounth Enumeration 
    enum DaysInMounth
    {
        JANUARY = 31,
        FEBRUARY = 28,
        MARCH = 31,
        APRIL = 30,
        MAY = 31,
        JUNE = 30,
        JULY = 31,
        AUGUST = 31,
        SEPTEMBER = 30,
        OCTOMBER = 31,
        NOVEMBER = 30,
        DECEMBER = 31
    }

    // Data class
    public struct Date
    {
        private int day;
        private int mounth;
        private int year;
        private bool leap;
        public Date(int _day, int _mounth, int _year)
        {
            day = _day;
            mounth = _mounth;
            year = _year;
            leap = (year % 4 != 0) ? false : (year % 100 == 100) ? (year % 400 == 0) ? true : false : true;
        }
        // Set Date methods
        // Set day 
        public void SetDay(int value)
        {
            switch (mounth)
            {
                // 31 days in month
                case ((int)Month.JANUARY):
                case ((int)Month.MARCH):
                case ((int)Month.MAY):
                case ((int)Month.JULY):
                case ((int)Month.AUGUST):
                case ((int)Month.OCTOBER):
                case ((int)Month.DECEMBER):
                    if(value <= 31 && value > 0)
                    {
                        day = value;
                    }
                    else
                    {
                        Console.WriteLine("UnexpectedValueException");
                    }
                    break;
                // February 29/28
                case ((int)Month.FEBRUARY):
                    if (value <= 29 && value > 0 && leap)
                    {
                        day = value;

                    }else if(value <= 28 && value > 0 && !leap)
                    {
                        day = value;
                    }
                    else
                    {
                        Console.WriteLine("UnexpectedValueException");
                    }
                    break;
                // 30 days in month
                case ((int) Month.APRIL):
                case ((int) Month.JUNE):
                case ((int) Month.SEPTEMBER):
                case ((int)Month.NOVEMBER):
                    if (value <= 30 && value > 0)
                    {
                        day = value;
                    }
                    else
                    {
                        Console.WriteLine("UnexpectedValueException");
                    }
                    break;
            }
        }
        // Set Mounth
        public void SetMounth(int value)
        {
            if(value <= 12 && value > 0)
            {
                mounth = value;
            }
            else
            {
                Console.WriteLine("UnexpectedValueException");
            }
        }
        // Set Year
        public void SetYear(int value)
        {
            if (value > 0)
            {
                year = value;
            }
            else
            {
                Console.WriteLine("UnexpectedValueException");
            }
        }

        // Final date set
        public void SetDate(int _day, int _mounth, int _year)
        {
            SetDay(_day);
            SetMounth(_mounth);
            SetYear(_year);
        }

        // is year leap
        public bool isLeap()
        {
            return leap;
        }
        // AddDays
        public void AddDays(int _value)
        {
            int value = _value;

            while(value != 0)
            {
                switch (mounth)
                {
                    case ((int)Month.JANUARY):
                    case ((int)Month.MARCH):
                    case ((int)Month.MAY):
                    case ((int)Month.JULY):
                    case ((int)Month.AUGUST):
                    case ((int)Month.OCTOBER):
                    case ((int)Month.DECEMBER):
                        if (day + value <= 31)
                        { 
                            day += value;
                            value -= value;
                        }
                        else
                        {
                            AddMonths(1);
                            if (value >= 31) {
                                day = (day + 31) % 31;
                                value -= 31;
                            } else if (value < 31)
                            {
                                day = (day + value) % 31;
                                value -= value;
                            }
                        }
                        break;
                    case ((int)Month.FEBRUARY):
                        if ((day + value <= 29 && leap) || (day + value <= 28 && !leap))
                        {
                            day += value;
                            value -= value;
                        }
                        else
                        {
                            if (leap)
                            {
                                AddMonths(1);
                                if (value >= 29)
                                {
                                    day = (day + 29) % 29;
                                    value -= 29;
                                }
                                else if (value < 29)
                                {
                                    day = (day + value) % 29;
                                    value -= value;
                                }
                            }
                            else
                            {
                                AddMonths(1);
                                if (value >= 28)
                                {
                                    day = (day + 28) % 28;
                                    value -= 28;
                                }
                                else if (value < 28)
                                {
                                    day = (day + value) % 28;
                                    value -= value;
                                }
                            }
                        }
                        break;
                    case ((int)Month.APRIL):
                    case ((int)Month.JUNE):
                    case ((int)Month.SEPTEMBER):
                    case ((int)Month.NOVEMBER):
                        if (day + value <= 30)
                        {
                            day += value;
                            value -= value;
                        }
                        else
                        {
                            AddMonths(1);
                            if (value >= 30)
                            {
                                day = (day + 30) % 30;
                                value -= 30;
                            }
                            else if (value < 30)
                            {
                                day = (day + value) % 30;
                                value -= value;
                            }
                        }
                        break;
                }
            }
            
        }
        // Subtract days #
        public void SubtractDays(int _value)
        {
            int value = _value;

            //while (value != 0)
            //{

            //}

        }
        // Add Months
        public void AddMonths(int value)
        {
            AddYears((value + (mounth - 1)) / 12);
            SetMounth((mounth + value) % 13);
        }
        // Subtract Months # 
        public void SubtractMonths(int _value)
        {

        }
        // Add Years
        public void AddYears(int value)
        {
            year += value;
            leap = (year % 4 != 0) ? false : (year % 100 == 100) ? (year % 400 == 0) ? true : false : true;
        }
        // Subtract Years #
        public void SubtractYears(int _value)
        {
            if(year - _value >= 0)
            {
                year -= _value;
            } else
            {
                Console.WriteLine("Чет как то далеко. А где Иисус?");
                year -= _value;
            }
        }
        
    }
}
