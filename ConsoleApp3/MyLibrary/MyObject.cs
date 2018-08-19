﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class MyObject
    {
        //This is a constructor
        public MyObject()
        {
            _number1 = 5;
            _number2 = 7;
        }

        public MyObject(int number1,int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }

        private int _number1 = 0;
        private int _number2 = 0;
        private int _number3 = 0;

        public int number1
        {
            get { return _number1; }
            set { _number1 = value; }
        }

        public int number2
        {
            get { return _number2; }
            set { _number2 = value; }
        }

        public int number3
        {
            get { return _number1 + _number2; }
        }

        public int Calculate(int number1,int number2)
        {
            return number1 + number2;
        }

        public int Calculate()
        {
            return number1 + number2;
        }

        public string MyMethod()
        {
            return "some value";
        }
    }
    }
