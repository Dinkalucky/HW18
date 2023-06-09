﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class MyDictionary
    {
        public Dictionary<int, string> dictionary = new Dictionary<int, string>();
        public void AddElements(int key, string value)
        {
            dictionary.Add(key, value);
        }

        public string this[int index]
        {
            get => dictionary[index];
        }

        public int NumberOfElements
        {
            get { return dictionary.Count; }
        }
    }
}
