using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Validation_app
{

    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {

        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
               
                Console.WriteLine("Enter the user_name");
                string user_name=Console.ReadLine();
                Console.WriteLine("Enter the password");
                string password = Console.ReadLine();
                Console.WriteLine("Enter email_id");
               string email_id = Console.ReadLine();
                if(string.IsNullOrEmpty(email_id) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(user_name))
                {
                    throw new ValidationException("All fields are required");
                }
                else
                {
                    if (user_name.Length >= 6 && password.Length >= 8)
                    {

                        Console.WriteLine($"you are given user name is:  {user_name}  && password is: {password} are valid \n\n***** Welcome to {user_name} *****\n***************************************\nyour logined Successfully");

                    }
                    else
                    {
                        if (user_name.Length >= 6)
                        {
                            throw new ValidationException("password should have atleast 8 characters");
                        }
                        else if (password.Length >= 8)
                        {
                            throw new ValidationException("User name should have atleast 6 characters");
                        }
                        else
                        {
                            throw new ValidationException("User name should have atleast 6 characters && password should have atleast 8 characters");
                        }

                    }
                }
               

            }
            catch (ValidationException v) 
            { 
               Console.WriteLine($"Custom Error !!!{v.Message}");
               
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error !!!{e.Message}");
            }
            finally 
            {
                Console.WriteLine("End of the program");
                Console.ReadKey();
            }
        }
    }
}
