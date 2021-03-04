using System;
using System.Collections.Generic;
using System.Text;

namespace Køen
{
    public class ToDo
    {
        private string activity { get; set; }
        private int amount { get; set; }
        public string Activity
        {
            get { return activity; }
            set { activity = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public ToDo()
        {

        }
        
    }
}
