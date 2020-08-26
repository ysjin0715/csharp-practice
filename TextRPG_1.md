# TextRPG 만들기
## 디버깅 기초
### 디버깅
- 코드를 분석하여 문제가 있는 부분을 찾아내는 일련의 과정
- breakpoint : 코드줄이 표시되어 있는 숫자 앞을 클릭하면 (F9) 빨간색 원이 표시된다. 이후 코드 실행 시 해당 지점에서 코드실행이 멈춘다.
- 프로시저 단위 실행(F10) : 메소드 단위로 실행을 지시한다. 세부사항이 아닌 결과값만을 확인하고자 할 때 사용된다.
- 한 단계씩 코드 실행(F11) : 메소드 내 세항까지 살펴본다. 어떠한 문제가 있는지 세부적으로 검토할 때 사용된다. 
- 조사식 : 디버깅모드일 때 좌측 하단 세 번째 탭에서 확인가능하며, 이름을 지정해 해당 값을 찾아볼 수 있다.
- 호출스택 : 현재까지 호출되어 있는 함수가 몇 개인지를 확인할 수 있다. 함수의 경로를 간략하게 알 수 있다.
```
class Program
{
	static void Print(int value)			// 호출A
	{
		Console.WriteLine(value);
	}

	static int addandprint(int a, int b)		// 호출B
	{
		int ret = a + b;
		Print(ret);
		return ret;
	}

	static void Main(string[] args)		// 호출C, breakpoint
	{
		int ret = Program.addandprint(10, 20);
	}
}
// 프로시저 단위로 실행할 경우 : 호출C (호출스택 (이하 스택) : 1)
// 한 단계씩 코드를 실행할 경우 : 호출C (스택 : 1)- 호출B(스택 : 2) - 호출A (스택 : 3) - 호출B (스택 : 2)- 호출C (스택 : 1)
```
- 조건 : breakpoint에서 우클릭을 하면 등장하는 옵션 중 하나. 조건을 설정하여 해당 조건이 맞을 경우 중단점이 자동으로 실행된다.

## 구조체 (Struct)
- 필요한 변수를 하나의 구성으로 만든다.
- 선언을 통해서 사용할 수 있으며, 구조체 내부에 public을 명시하지 않을 경우 변수가 숨어 사용하기 힘들다.
```
struct Player
{
	public int hp;
	public int attack;
	public ClassType Type;
}

Player player;    // 선언 (구조체 Player를 player의 명의로 사용한다)

player.hp;	
player.attack;	
```
