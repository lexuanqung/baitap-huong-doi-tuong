using System;
using System.Collections.Generic;
using System.Text;

namespace bai_seach3
{
    public class PersonList
    {
        private Person[] list = null;
        private int count = 0;
        public PersonList(int size)
        {
            if (size < 10) size = 10;
            list = new Person[size];
        }
        int find(String aCode)
        {
            for (int i = 0; i < count; i++)
            {
                if (aCode.Equals(list[i].getCode())) return i;
                return -1;
            }
        }
        public void add()
        {
            if (count == list.Length) Console.WriteLine("List is full!");
            else
            {

            }
        }
    }
}
