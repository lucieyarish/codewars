using System;

namespace CreatePhoneNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
            //return (123) 456-7890
            Console.WriteLine(CreatePhoneNumber(numbers));
        }

        public static string CreatePhoneNumber(int[] numbers) 
        {
            string joinedString = String.Join(String.Empty, numbers);
            string phoneNumber = String.Format("{0:(###) ###-####}", Convert.ToInt64(joinedString));
            if(phoneNumber.Length < 14)
            {
                phoneNumber = String.Format("{0:(0##) ###-####}", Convert.ToInt64(joinedString));
            }
            return phoneNumber;
        }
    }
}