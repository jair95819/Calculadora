﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Funciones
    {
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Substraction(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        public double Division(double num1, double num2)
        {
            double division_num1 = (double) num1;
            double division_num2 = (double) num2;

            if(num2 == 0)
            {
                //Returns -1 'cause you can't divide any number by 0
                return -1;
            }
            else
            {
                return division_num1 / division_num2;
            }
        }
    }
}
