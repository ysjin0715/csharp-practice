using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Xml.Serialization;

namespace CSharp
{
	class TextRPG_1
	{
		enum ClassType
		{
			None = 0,
			Knight = 1,
			Archer = 2,
			Mage = 3
		}

		enum MonsterType
        {
			None = 0,
			Slime = 1,
			Orc = 2,
			Skeleton = 3
        }

		struct Monster
        {
			public int hp;
			public int attack;
		}

		static ClassType ChooseClass()
		{
			Console.WriteLine("직업을 선택하세요");
			Console.WriteLine("(1) 기사");
			Console.WriteLine("(2) 궁수");
			Console.WriteLine("(3) 마법사");

			ClassType choice = ClassType.None;
			string input = Console.ReadLine();

			switch (input)
			{
				case "1":
					choice = ClassType.Knight;
					break;

				case "2":
					choice = ClassType.Archer;
					break;


				case "3":
					choice = ClassType.Mage;
					break;
			}

			return choice;
		}

		static void CreatPlayer(ClassType choice, out Player player)
		{
			switch (choice)
			{
				case ClassType.Knight:
					player.hp = 100;
					player.attack = 10;
					break;

				case ClassType.Archer:
					player.hp = 75;
					player.attack = 12;
					break;

				case ClassType.Mage:
					player.hp = 50;
					player.attack = 15;
					break;

				default:
					player.hp = 0;
					player.attack = 0;
					break;
			}
		}

		static void CreatRandomMonster(out Monster monster)
        {
			Random rand = new Random();

			// 1이상 4미만 수 무작위 소환
			// 랜덤으로 몬스터 하나를 리스폰
			int randMonster = rand.Next(1, 4);
			switch (randMonster)
            {
				// enum -> int타입 변환
				case (int)MonsterType.Slime:
                    Console.WriteLine("슬라임이 스폰되었습니다");
					monster.hp = 20;
					monster.attack = 2;
					break;

				case (int)MonsterType.Orc:
					Console.WriteLine("오크가 스폰되었습니다");
					monster.hp = 40;
					monster.attack = 4;
					break;

				case (int)MonsterType.Skeleton:
					Console.WriteLine("스켈레톤이 스폰되었습니다");
					monster.hp = 30;
					monster.attack = 3;
					break;

				default:
					monster.hp = 0;
					monster.attack = 0;
					break;
			}
			
			
        }

		static void Fight(ref Player player, ref Monster monster)
        {
			while (true)
            {
				// 플레이어가 몬스터 선공격
				monster.hp -= player.attack;
				if (monster.hp <= 0)
                {
                    Console.WriteLine("승리했습니다!");
                    Console.WriteLine($"남은 체력{player.hp}");
					break;
                }

				// 몬스터의 반격
				player.hp -= monster.attack;
				if(player.hp <= 0)
                {
                    Console.WriteLine("패배했습니다");
                }
            }
        }

		static void EnterField(ref Player player)
        {
			while (true)
            {
				Console.WriteLine("필드에 접속했습니다");

				// 몬스터 무작위 생성
				Monster monster;
				CreatRandomMonster(out monster);

				// [1] 전투 모드로 돌입
				// [2] 일정 확률로 마을로 도망가기
				Console.WriteLine("[1] 전투 모드로 돌입하기");
				Console.WriteLine("[2] 일정 확률로 마을로 도망가기");

				string input = Console.ReadLine();
				if (input == "1")
				{
					Fight(ref player, ref monster);

				}
				else if (input == "2")
				{
					// 33%의 확률로 도주
					Random rand = new Random();
					int randValue = rand.Next(0, 101);

					if (randValue <= 33)
					{
						Console.WriteLine("도망치는데 성공했습니다");
						break;
					}
					else
					{
						Fight(ref player, ref monster);
					}
				}
			}
		}

		static void EnterGame(ref Player player)
        {
			while (true)
			{


				Console.WriteLine("게임에 접속했습니다");
				Console.WriteLine("[1] 필드로 간다");
				Console.WriteLine("[2] 로비로 돌아가기");

				string input = Console.ReadLine();
				if (input == "1")
                {
					EnterField(ref player);
                }
				else if(input == "2")
                {
					break;
                }

			}
        }

		struct Player
        {
			public int hp;
			public int attack;
        }

		static void Main(string[] args)
		{
			while (true)
			{
				ClassType choice = ChooseClass();
				if (choice != ClassType.None)
				{
					// 캐릭터 생성 (기사(100/10) 궁수(75/12) 마법사(50/15))
					Player player;
					CreatPlayer(choice, out player);

					// 필드사냥
					EnterGame(ref player);
				}

			}

		}
	}
}