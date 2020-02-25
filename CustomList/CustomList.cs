using System;

namespace PraseodymiumTDD
{
    public class CustomList<T>
    {

        private int capacity;
        private int count;
        public T[] myArray;


        public CustomList()
        {
            count = 0;
            capacity = 4;
            myArray = new T[Capacity];
        }

        public int Count { get { return count; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }
        public T this[int i]
        {
            get
            {
                return myArray[i];
            }
            set
            {
                myArray[i] = value;
            }
        }


        public void Add(T item)
        {
            //increment count

            if (Count == capacity)
            {
                capacity = capacity * 2;
                T[] temporaryArray = new T[Capacity];
                
                
                for (int i = 0; i < count; i++)
                {
                    temporaryArray[i] = myArray[i];
                }

                myArray = temporaryArray;

                //item needs to land at next available index  



                //check to make sure it persists
                //count == maxcapacity, we need to increase capacity and copy

            }
            myArray[count] = item;
            count++;
        }
        public void Remove(T item)
        {

        }
    }
}
