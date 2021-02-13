using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    class MyDictionary<Key, Value>
    {
        Key[] keys;
        Value[] values;
        public MyDictionary()
        {
            keys = new Key[0];
            values = new Value[0];
        }

        public void Add(Key key, Value value)
        {
            Key[] tempKey = keys;
            Value[] tempValue = values;

            keys = new Key[keys.Length + 1];
            values = new Value[values.Length + 1];
            int i;
            int j;
            for (i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                for (j = 0; j < tempValue.Length; j++)
                {
                    values[j] = tempValue[j];
                }
                
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
    }
}
