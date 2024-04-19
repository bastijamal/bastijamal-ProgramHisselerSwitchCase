using System.Linq.Expressions;

namespace Darag
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Weapon weapon = new Weapon();

			//weapon.Shoot(false);
			weapon.ChangeFireMood(false);
			weapon.GetRemainBulletCount(40, 10);
			weapon.Reload(80, 20);


			Console.WriteLine("---------------------------");


			Console.WriteLine("0.Informasiya almaq ucun basin");
			Console.WriteLine("1.Atesh achmaq");
			Console.WriteLine("2.GetRemainBulletCount metodu");
			Console.WriteLine("3.Reload Methodu");
			Console.WriteLine("4.ChangeFiremood");
			Console.WriteLine("5.Exit");


			Console.WriteLine("Secim edin:");
			string input = Console.ReadLine();
			switch (input)
			{
				case "0":
					Console.WriteLine($" capacity {weapon.CapacityBullet} current : {weapon.CurrentBullet} ");

					break;

				case "1":
					bool isAutomatic = Convert.ToBoolean(Console.ReadLine());
					weapon.Shoot(isAutomatic);
					break;


				case "2":
					weapon.GetRemainBulletCount(30, 10);
					
					break;

				case "3":
					weapon.Reload(30, 10);

					break;

				case "4":
					Console.WriteLine("Enter Mode to Change:");
					bool IsChange = Convert.ToBoolean(Console.ReadLine());
					weapon.ChangeFireMood(IsChange);

					break;

				case "5":

					break;

				default:
					
					break;
			}



		}
	}
}
