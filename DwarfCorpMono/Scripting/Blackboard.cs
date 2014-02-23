﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DwarfCorp
{
    public class Blackboard
    {
        public Dictionary<string, ActData> Data { get; set; }

        public Blackboard()
        {
            Data = new Dictionary<string, ActData>();
        }

        public void Clear()
        {
            Data.Clear();
        }

        public T GetData<T>(string key)
        {
            if (Data.ContainsKey(key))
            {
                return Data[key].GetData<T>();
            }
            else
            {
                return default(T);
            }
        }

        public void SetData(string key, object value)
        {
            Data[key] = new ActData(value);
        }

        public ActData this[string key]
        {
            get { return Data[key]; }
            set { Data[key] = value; }
        }


    }

}
