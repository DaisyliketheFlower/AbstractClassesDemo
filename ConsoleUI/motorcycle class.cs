using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
		
        public Motorcycle()
		{
			
		}

		public bool HasSideCart { get; set;}
        public override void DriveAbstract()
        {
			Console.WriteLine($"This motorcycle is driving abstractly");
			Console.WriteLine($"Has side cart:{HasSideCart}");
        }

        public override void DriveVirtual()
        {
			Console.WriteLine("This motorcycle is driving virtually");
			Console.WriteLine($"Has side cart{HasSideCart}");
        }
    }
}

