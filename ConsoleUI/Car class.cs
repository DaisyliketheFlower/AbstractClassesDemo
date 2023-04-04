using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleUI
{

	public class Car : Vehicle
	{
		
        public Car()
		{
			
		}

		public bool HasTrunk { get; set; }

		public override void DriveAbstract()
		{
          Console.WriteLine($"This{GetType().Name}is abstractly in drive");
			Console.WriteLine($"Has Trunk?:{HasTrunk}");

		}
	}
}
