﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AtmApp.BLL.HelperFunctions
{
    public class GenerateRandomNumbers
    {
        public static string RandomDigits(int length)
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < length; i++)
                s = String.Concat(s, random.Next(10).ToString());
            return s;
        }
    }
}
