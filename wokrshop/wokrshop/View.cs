using System;
using System.Collections.Generic;
using System.Text;


namespace wokrshop
{

    class View
    {
        public string ReadInput()
        {
            string Input = " ";
            while (true)
            {
                Console.WriteLine("veuillez inserer un message (entre 1 et 8 characteres) :");
                Input = Console.ReadLine();
                if (Input.Length > 1 && Input.Length <= 8)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("veuillez saisir un truc logique mecque");
                }
                
            }
            return Input;
        }
        public void PrintOutput(string output)
        {

            Console.WriteLine("En maj :{0}", output);
 
        }
    }
}
