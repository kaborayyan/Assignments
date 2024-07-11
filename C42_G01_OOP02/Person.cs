using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_OOP02
{
    internal class Person
    {
        string[] Names;
        int[] Ages;
        int ArraySize;

        // Properties
        public int Size
        {
            get { return ArraySize; }
        }

        // Constructors
        public Person(int _size)
        {
            ArraySize = _size;
            Names = new string[ArraySize];
            Ages = new int[ArraySize];
        }

        // Methods
        public void AddPerson(int position, string name, int age)
        {
            if (Names is not null && Ages is not null)
            {
                if (position < Size)
                {
                    Names[position] = name;
                    Ages[position] = age;
                }
            }
        }

        public string TheOldest()
        {
            int OldestAge = 0;
            int Index = 0;
            for (int i = 0; i < Ages.Length; i ++)
            {
                if (Ages[i] > OldestAge)
                {
                    OldestAge = Ages[i];
                    Index = i;
                }
            }
            return $"{Names[Index]} is the oldest and his age is {Ages[Index]}";
        }

        public string this[int index]
        {
            get
            {
                return $"{index} :: {Names[index]} :: {Ages[index]}";
            }
        }
        
    }
}
