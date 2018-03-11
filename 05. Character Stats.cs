using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC_05.Character_Stats
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			int currentHealth = int.Parse(Console.ReadLine());
			int maxHealth = int.Parse(Console.ReadLine());
			int currentEnergy = int.Parse(Console.ReadLine());
			int maxEnergy = int.Parse(Console.ReadLine());

			string healthAsText = new string('|',currentHealth);
			string healthMissing = new string('.', maxHealth-currentHealth);
			string energyAsText = new string('|', currentEnergy);
			string energyMissing = new string('.', maxEnergy - currentEnergy);

			Console.WriteLine($"Name: {name}");
			Console.WriteLine($"Health: |{healthAsText}{healthMissing}|");
			Console.WriteLine($"Energy: |{energyAsText}{energyMissing}|");
		}
	}
}
