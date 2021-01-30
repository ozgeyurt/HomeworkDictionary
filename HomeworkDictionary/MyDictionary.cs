using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkDictionary
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;

        public MyDictionary()   //program cs de new yaptığımız an burası çalışıyor
        {
            keys = new K[0];    //dizinin eleman sayısını sıfırlıyoruz 
            values = new V[0];  
        }
        public void Add(K key,V value)
        {
            K[] tempKeys = keys;
            V[] tempValue = values; //newleme yaptığımız an eski elemanlar silineceği için onları(referans tutucu) burada tutturuyoruz
            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];//eleman sayısını 1 arttırcaz

            for (int i = 0; i < tempKeys.Length ; i++)
            {
                keys[i] = tempKeys[i];
            }
            
            for (int j = 0; j < tempValue.Length; j++)
            {
                values[j] = tempValue[j];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

            
        }
        
    }
}
