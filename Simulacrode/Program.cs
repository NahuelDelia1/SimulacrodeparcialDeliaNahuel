using System;

namespace SimulaciondeparcialDeliaNahuel
{
	class program
	{

		static void Main(string[] args)
		{
			string formatohorario;
			int hh;
			int mm;
			string sistemahorario;
			int ss;
			Console.WriteLine("¿Desea usar el sistema horario de 24 horas?  SI / NO");
			sistemahorario = Console.ReadLine();
			if (sistemahorario.Equals("si") || sistemahorario.Equals("no"))
			{
				if (sistemahorario.Equals("si"))
				{
					Console.WriteLine("Has seleccionado el sistema horario de 24 horas.");
					Console.WriteLine("Ingrese hora/s");
					hh = int.Parse(Console.ReadLine());
					Console.WriteLine("Ingrese minuto/s");
					mm = int.Parse(Console.ReadLine());
					Console.WriteLine("Ingrese segundo/s");
					ss = int.Parse(Console.ReadLine());
					if (hh < 24 && mm < 60 && ss < 60)
					{
						if (hh < 10 && mm < 10 && ss < 10)
						{
							Console.WriteLine("la hora es 0" + hh + ":0" + mm + ":0" + ss + " en el sistema de 24 horas");
						}
						else
						{
							Console.WriteLine("la hora es " + hh + ":" + mm + ":" + ss + " en el sistema de 24 horas");
						}
					}
					else
					{
						Console.WriteLine("horario invalido");
					}
				}
				else
				{
					Console.WriteLine("Has seleccionado el sistema de 12 horas");
					Console.WriteLine("¿formato am o pm?");
					formatohorario = Console.ReadLine();
					if (formatohorario.Equals("am") || formatohorario.Equals("pm"))
					{
						if (formatohorario.Equals("am"))
						{
							Console.WriteLine("formato AM seleccionado");
							Console.WriteLine("ingrese hora/s");
							hh = int.Parse(Console.ReadLine());
							Console.WriteLine("ingrese minuto/s");
							mm = int.Parse(Console.ReadLine());
							Console.WriteLine("ingrese segundo/s");
							ss = int.Parse(Console.ReadLine());
							if (hh <= 12 && mm < 60 && ss < 60)
							{
								if (hh < 10 && mm < 10 && ss < 10)
								{
									Console.WriteLine("la hora es 0" + hh + ":0" + mm + ":0" + ss + formatohorario);
								}
								else
								{
									Console.WriteLine("la hora es " + hh + ":" + mm + ":" + ss + formatohorario);
								}
							}
							else
							{
								Console.WriteLine("horario invalido");
							}
						}
						else
						{
							Console.WriteLine("formato PM seleccionado");
							Console.WriteLine("ingrese hora/s");
							hh = int.Parse(Console.ReadLine());
							Console.WriteLine("ingrese minuto/s");
							mm = int.Parse(Console.ReadLine());
							Console.WriteLine("ingrese segundo/s");
							ss = int.Parse(Console.ReadLine());
							if (hh <= 12 && mm < 60 && ss < 60)
							{
								if (hh < 10 && mm < 10 && ss < 10)
								{
									Console.WriteLine("la hora es 0" + hh + ":0" + mm + ":0" + ss + formatohorario);
								}
								else
								{
									Console.WriteLine("la hora es " + hh + ":" + mm + ":" + ss + formatohorario);
								}
							}
							else
							{
								Console.WriteLine("horario invalido");
							}
						}
					}
					else
					{
						Console.WriteLine("Error");
					}
				}
			}
			else
			{
				Console.WriteLine("Error");
			}
		}

	}

}