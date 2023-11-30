namespace Week3_day11_PhonBookExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Phone Number System");

            PhoneBook Myphone = new PhoneBook(5);

            Myphone.addPerson("Khaloud", 987654);
            Myphone.addPerson("Sara", 998877);
            Myphone.addPerson("Reem", 981254);

            Myphone.GetAllNum();
            Console.WriteLine("----------------------------\n");

            Console.Write("The number of Khaloud is :");
            Console.WriteLine(Myphone.GetNumber("Khaloud"));//to get phone number of this name
            Myphone.EditNumber("Khaloud", 9955116);

            Console.Write("The new number is :");
            Console.WriteLine(Myphone.GetNumber("Khaloud"));


            //--------------------------------------------------------------------------------------------------------------

            // indexer propry
            //get phone number of this name
            Console.WriteLine("------------indexer propry----------------\n"); 

            Myphone.addPerson("Mona", 9112254); //add new person 

            Console.Write("The old number of Mona is :");
            Console.WriteLine(Myphone["Mona"]);//to get phone number of this name by indexer
            Myphone ["Mona"]= 9335116; //edit | update 
            Myphone.GetAllNum();


            //--------------------------------------------------------------------------------------------------------------



            Console.WriteLine("----------------------------\n");
            Console.WriteLine("Total count number of phone:");
            Console.WriteLine(PhoneBook.cnt);// to find the count of phone you have 


        }
    }
}