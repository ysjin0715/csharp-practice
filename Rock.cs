using System;

namespace CSharp
{
	class Rock
	{
		static void Main(string[] args)
		{
			// 0: 가위, 1: 바위, 2: 보

			Random rand = new Random();
			int aiChoice = rand.Next(0,3); // 0~2 사이의 랜덤값 반환 (0이상 3미만)

			// Console.ReadLine()) : 사용자가 엔터를 누를 때까지 기다린다
			int choice = Convert.ToInt32(Console.ReadLine());
			
			switch (choice)
            {
				case 0:
					Console.WriteLine("당신의 선택은 가위입니다");
					break;
				case 1:
					Console.WriteLine("당신의 선택은 바위입니다");
					break;
				case 2:
					Console.WriteLine("당신의 선택은 보입니다");
					break;
			}

			switch (aiChoice)
			{
				case 0:
					Console.WriteLine("컴퓨터의 선택은 가위입니다");
					break;
				case 1:
					Console.WriteLine("컴퓨터의 선택은 바위입니다");
					break;
				case 2:
					Console.WriteLine("컴퓨터의 선택은 보입니다");
					break;
			}

			// 승리, 무승부, 패배의 판결
			if (choice == aiChoice)
				Console.WriteLine("무승부");

			else
			{
				switch (choice)
				{
					case 0:
						if (aiChoice == 1)
							Console.WriteLine("패배");
						else
							Console.WriteLine("승리");
						break;

					case 1:
						if (aiChoice == 2)
							Console.WriteLine("패배");
						else
							Console.WriteLine("승리");
						break;

					default:
						if (aiChoice == 0)
							Console.WriteLine("패배");
						else
							Console.WriteLine("승리");
						break;
				}
			}
		}
	}
}
