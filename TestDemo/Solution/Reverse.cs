﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestDemo.Solution
{
    class ReverseInt
    {
        public static int Reverse(int x)
        {
            var charX = x.ToString().ToCharArray();
            var len = charX.Length;
            var newChar = new char[len];
            for (var i = 0; i < len; i++)
            {
                if (charX[0] == '-')
                {
                    if (charX[i] == '-')
                    {
                        newChar[i] = charX[i];
                    }
                    else
                    {
                        newChar[len - i] = charX[i];
                    }
                }
                else
                {
                    newChar[len - i - 1] = charX[i];
                }

            }
            var parse = int.TryParse(new string(newChar), out int newInt);
            if (parse)
                return newInt;
            else
                return 0;
        }
    }
}
