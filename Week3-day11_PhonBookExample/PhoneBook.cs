
using System.Drawing;

namespace Week3_day11_PhonBookExample
{
    internal class PhoneBook
    {

        //is attribute by default is private Member
        public static int cnt ;
        string[] Name;
        long[] Number;
        int size;

        public PhoneBook(int size)
        {
            this.size = size;
            this.Name = new string[size];
            this.Number = new long[size];
        }

        public  int GetSize()
        {
            return this.size;
        }

        //this function use to add person with name and number
        public void addPerson( string name, long number)
        {
            
            Name[cnt] = name;
            Number[cnt] = number;
            cnt++;
        }

        public void GetAllNum()
        {
            for (int i = 0; i < this.Number.Length; i++)
            {
                if (this.Name[i] != null)//why i write name not number becouse nuber by defult is 0 but name is 1
                    Console.WriteLine($"In Index {i} :Name:{this.Name[i]} , Phone Number = {this.Number[i]}");
            }
        }

        //-----------------------get and set  number  by using indexer property ------------------------ 
        // this ==>   Myphone[] object
        public long this[string name ,bool flag =false]
        {
            get {
                for (int i = 0; i < this.size; i++)
                {
                    if (Name[i] == name)
                    {
                        return this.Number[i];
                    }
                }
                return -1;
            }
            set
            {
                if (!flag)
                {
                    ////if you want To add value write this code :
                    Name[cnt] = name;
                    Number[cnt] = value;
                    cnt += 1;
                }
                else
                {
                    //update value :
                    for (int i = 0; i < this.size; i++)
                    {
                        if (Name[i] == name)
                        {
                            this.Number[i] = value;
                        }
                    }
                }
            }
        }



        //-----------------------get number ------------------------

        public long GetNumber( string name)
        {
            for (int i = 0; i < this.size; i++)
            {
                if (Name[i] == name) {
                    return this.Number[i];
                }    
            }
            return -1;


        }

        public void EditNumber(string name, long number)
        {
            for (int i = 0; i < this.size; i++)
            {
                if (Name[i] == name)
                {
                     this.Number[i]=number;
                    Console.WriteLine($"{Name[i]} is updated with New number {Number[i]}");
                }
            }
            


        }

        //set the name of number



    }
}
