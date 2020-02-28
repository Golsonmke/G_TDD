using System.Collections;
using System.Linq;

namespace PraseodymiumTDD
{
    public class CustomList<T> : IEnumerable
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
            //item needs to land at next available index  
            //check to make sure it persists
            //count == maxcapacity, we need to increase capacity and copy
            if (Count == capacity)
            {
                capacity = capacity * 2;
                T[] temporaryArray = new T[Capacity];


                for (int i = 0; i < count; i++)
                {
                    temporaryArray[i] = myArray[i];
                }

                myArray = temporaryArray;

            }
            myArray[count] = item;
            count++;
        }
        public void Remove(T item)
        {
            //Copy myArrray without item to be removed
            // temp. array transfer to items
            T[] temporaryArray = new T[capacity];
            bool hasFound = false;

            for (int i = 0; i < count; i++)
            {
                if (myArray[i].Equals(item) && hasFound == false)
                {
                    hasFound = true;
                    count--;
                }

                if (hasFound == true)
                {

                    temporaryArray[i] = myArray[i + 1];
                }
                else
                {
                    temporaryArray[i] = myArray[i];
                } // need to shift numbers or copy numbers to new Array
            }
            myArray = temporaryArray;
        }
        public override string ToString()
        {
            string item = "";

            for (int i = 0; i < count; i++)
            {
                myArray[i].ToString();
                if (i == (count - 1))
                {
                    item += (myArray[i]);
                }
                else { item += (myArray[i]) + "," + " "; }

            }
            return item;
        }

        public IEnumerator GetEnumerator()
        {


            for (int i = 0; i < Count; i++)
            {
                yield return myArray[i];
            }
        }

        public static CustomList<T> operator+(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> List3 = new CustomList<T>();
            for (int i = 0; i < list1.count; i++)
            {
                List3.Add(list1[i]);
            }
            for (int j = 0; j < list2.count; j++)
            {
                List3.Add(list2[j]);
            }
            return List3;
        }
    }   
}