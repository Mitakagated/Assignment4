using System;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mailCheck();
            capitalString();
        }

        private static void mailCheck()
        {
                Console.WriteLine("Please type an email adress: ");
                string email = Console.ReadLine();

            try
            {
                var address = new System.Net.Mail.MailAddress(email); // this is setting up the check for the email validation
                if (address.Address == email)
                {
                    Console.WriteLine("Thank you for typing a valid email adress.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("This is not a valid email adress."); // shows an error massage if it is not in a valid email format
            }

            Console.WriteLine("-----------------------------"); // end of the function
        }
        private static void capitalString()
        {
            string sentence = "My chair is comfy today.";
            Console.WriteLine(sentence); // this prints the sentence in the window without any modifications

            int charPos = sentence.IndexOf('t'); // this is finding the start of the word "today"
            string capitalWord = sentence.Substring(charPos); // this is making a substring of the word "today"

            Console.WriteLine(capitalWord.ToUpper()); // this is making the word "today" capitalized and prints it in the window
            Console.WriteLine(sentence.ToUpper()); // this is making the whole sentence capitalized and prints it in the window

            Console.WriteLine("-----------------------------"); // end of the function
        }
    }
}
