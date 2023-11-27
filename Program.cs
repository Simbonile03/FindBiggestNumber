namespace FindBiggestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] myNumbers = {2, 1, 7, 4, 9, 5 };
            int biggest = Numbers.BiggestNumber(myNumbers);
            int secondbiggest = Numbers.SecondBiggestNumber(myNumbers);

            Console.WriteLine("The biggest number is " + biggest);
            Console.WriteLine("The second biggest number is " + secondbiggest);

            string inputString = "I hope you had a good weekend?";
            string capitalString = Words.CapitalizeFirstWord(inputString);
            Console.WriteLine(capitalString);
        }
    }
     

}
   