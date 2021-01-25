using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T,D>
    {
        T[] _key;
        D[] _value;
        T[] _tempKey;
        D[] _tempValue;
        public MyDictionary()
        {
            _key = new T[0];
            _value = new D[0];
        }
        public void Add(T key,D value)
        {
            _tempKey = _key;
            _key = new T[_key.Length + 1];
            for (int i = 0; i <_tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
            }
            _key[_key.Length - 1] = key;

            _tempValue = _value;
            _value = new D[_value.Length + 1];
            for (int i = 0; i < _tempValue.Length; i++)
            {
                _value[i] = _tempValue[i];
            }
            _value[_value.Length - 1] = value;


        }
        
    }
}
