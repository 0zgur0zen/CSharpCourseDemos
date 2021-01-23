using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemos
{
    class MyDictiionary<T,T1,T2>
    {
        T[] ad;
        T1[] soyad;
        T2[] ıdNo;
        public MyDictiionary()
        {
            ad = new T[0];
            soyad = new T1[0];
            ıdNo = new T2[0];
        }
        public void Add(T yeniad,T1 yenisoyad,T2 yeniıdNo)
        {
            T[] tempad = ad;
            T1[] tempsoyad = soyad;
            T2[] tempıdNo = ıdNo;
            ad = new T[ad.Length + 1];
            soyad = new T1[soyad.Length + 1];
            ıdNo = new T2[ıdNo.Length + 1];
            for (int i = 0; i < tempad.Length; i++)
            {
                ad[i] = tempad[i];
               
                ıdNo[i] = tempıdNo[i];
            }          
            ad[ad.Length - 1] = yeniad;
            soyad[soyad.Length - 1] = yenisoyad;
            ıdNo[ıdNo.Length - 1] = yeniıdNo;
        }
        public int Lenght
        {
            get { return ad.Length; }            
        }
       
           
        

    }
}
