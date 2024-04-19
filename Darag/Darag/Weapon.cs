using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darag
{
	internal class Weapon

	{
		public int CapacityBullet;
		public int CurrentBullet;
		bool Firemood; //true avtomatik,false tekli


		public void Shoot(bool Firemood)
		{
			if (Firemood == true)
			{
				CurrentBullet-=1;
				Console.WriteLine("1 gulle atildi");
			}
			else
			{
				CapacityBullet= 0;
				Console.WriteLine("DARAG TEMMIZ BOSHADILDI");

			}
			
		}

		public void GetRemainBulletCount(int CapacityBullet, int CurrentBullet)
		{
			int a =  CapacityBullet-CurrentBullet;
			Console.WriteLine($"Daragin tam dolmasi ucun lazim olan gulle sayi: {a}"); 

		}


		public void Reload(int CapacityBullet, int CurrentBullet)
		{
			//b tamamlamaq uchun lazim olan gulle sayidir (max tutum -mende olan)
			int b = CapacityBullet - CurrentBullet;
			CurrentBullet += b;
			Console.WriteLine($"{b} dene Gulle Elave edilerek,Yeniden dolma bash verdi");

		}

		public void ChangeFireMood(bool Firemood)
		{
			if(Firemood== true) { 

				Firemood = false;
				Console.WriteLine("Atish modu ugurla deyishdirildi! Tekli oldu ");

			}

			else
			{
				Firemood= true;
				Console.WriteLine("Atish modu ugurla deyishdirildi! Avtomatik oldu ");
			}



		}


	}

	

	}


