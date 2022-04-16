using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingProject
{
    public class VendingMachine
    {
        public void DisplayNumberNotes()
        {
            int[] notes = {1000,500,100,50,20,10,5,2,1};
            int length=notes.Length;
            int[] notes_Number=new int[notes.Length];
            int length1= notes_Number.Length;
            Console.WriteLine("Enter the Amount");
            int amount=Convert.ToInt32(Console.ReadLine());
            int temp = amount;
            for (int i =0; i <length; i++)
            {
                if (amount > 0)
                {
                    notes_Number[i] = amount / notes[i];
                    amount -=notes_Number [i]*notes[i];
                }
            }
            for (int i = 0; i < length1; i++)
            {
                if (notes_Number[i] != 0)
                { 
                Console.WriteLine(temp+ "Number of note of the amount"+notes[i]+"------->"+notes_Number[i]);
                }
            }
        }
    }
}
