﻿﻿using System;

namespace Kiemtranamnhuan 
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            bool isLeapYear = false;
            Console.WriteLine("Nhap so nam: ");
            year = Convert.ToInt32(Console.ReadLine());

            /*            bool isDivisibleBy4 = year % 4 == 0;
                        if (isDivisibleBy4)
                        {
                            bool isDivisibleBy100 = year % 100 == 0;
                            if (isDivisibleBy100)
                            {
                                bool isDivisibleBy400 = year % 400 == 0;
                                if (isDivisibleBy400)
                                {
                                    isLeapYear = true;
                                }
                            }
                            else
                            {
                                isLeapYear = true;
                            }
                        }
                        if (isLeapYear)
                        {
                            Console.WriteLine("{0} is a leap year", year);
                        }
                        else
                        {
                            Console.WriteLine("{0} is NOT a leap year", year);
                        }
            */
            /*            if (year % 4 == 0)
                        {
                            if (year % 100 == 0)
                            {
                                if (year % 400 == 0)
                                {
                                    isLeapYear = true;
                                }
                            }
                            else
                            {
                                isLeapYear = true;
                            }
                        }

                        if (isLeapYear)
                        {
                            Console.WriteLine("{0} is a leap year", year);
                        }
                        else
                        {
                            Console.WriteLine("{0} is NOT a leap year", year);
                        }
            */
            bool isDivisibleBy4 = year % 4 == 0;
            if (isDivisibleBy4)
            {
                bool isDivisibleBy100 = year % 100 == 0;
                if (isDivisibleBy100)
                {
                    bool isDivisibleBy400 = year % 400 == 0;
                    if (isDivisibleBy400)
                    {
                        isLeapYear = true;
                    }
                }
                else
                {
                    isLeapYear = true;
                }
            }

            if (isLeapYear)
            {
                Console.WriteLine("{0} la nam nhuan", year);
            }
            else
            {
                Console.WriteLine("{0} khong PHAI nam nhuan", year);
            }

        }
    }
}
