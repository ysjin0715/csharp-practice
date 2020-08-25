# 코드의 흐름제어
## if와 else, else if
- "변수명"이 참일 경우, 바로 아래줄의 코드가 실행된다.
- 들여쓰기를 하지 않아도 코드는 정상적으로 작동되지만, 가독성을 위해 들여쓰기는 해주도록 하자.
```
if ("변수명")
	Console.WriteLine("You Are Dead");
```
```
if ("변수명")
Console.WriteLine("You Are Dead");
```
- if문 아래줄 코드에 중괄호가 기입될 경우, if가 참일 때 중괄호 안의 모든 코드가 실행된다.
```
if ("변수명")
{
	Console.WriteLine("You are Dead!");
	Console.WriteLine("You are Dead!");
	Console.WriteLine("You are Dead!");
}
```
- if문이 거짓일 경우의 코드는 아래와 같이 작성한다.
```
if ("변수명"==false)
{
	Console.WriteLine("You are Alive");
}
```

- 다만 위와 같은 방법을 이용하기보다는, if문 첫번째에 제시한 조건이 아닐 경우 사용하는 else문을 적극 사용하기를 권장한다.
```
// "변수명"이 참이라면 aa를 입력한다.
if ("변수명")
{
	Console.WriteLine("aa");
}

// "변수명" 거짓이라면 bb를 입력한다.
else
{
	Console.WriteLine("bb");
}

```

- 선택지가 3개 이상의 다수일 경우, else if를 사용한다.
- 첫 번째, 두 번째 조건이 맞으면 나머지 코드를 보지 않는 것으로, 메모리를 크게 절약할 수 있다.
```
// 0: 가위 1: 바위 2: 보
int choice = 0;

if (choice == 0)
{
Console.WriteLine("가위입니다");
}

else if (choice == 1)
{
Console.WriteLine("바위입니다");
}

else
{
Console.WriteLine("보입니다");
}
```

## switch
- 반복되는 구절을 생략하기 위하여 사용하는 구문
- 한정적으로 사용되는 유사 if문이다.
- case : "정수 혹은 문자열"의 값이 case 옆에 붙어있는 숫자일 경우, 해당 case 아래의 코드를 모두 실행한다.
- break : case 아래 코드가 모두 실행되면 코드실행을 중단하고 빠져나온다.
- default : else와 비슷한 경우로, 모든 case에 속하지 않은 값을 받을 경우 default를 실행한다.
- switch로 구현가능한 것들은 if로 구현가능하나, 그 역은 성립하지 않는다.
- 가독성이 뛰어나므로 switch문으로 구현가능하면 되도록 해당 구문을 사용한다.
- switch문에서 변수는 사용될 수 없고 오직 상수만 사용가능하다.
```
switch ("변수명")
{
	case0:
		Console.WriteLine ("가위입니다");
		break;
	case1:
		Console.WriteLine ("바위입니다");
		break;
	case2:
		Console.WriteLine ("보입니다");
		break;
	default:
		Console.WriteLine ("모두 실패했습니다");
		break;
}
```

## 삼항연산자
- 연산자에서 뒤에 조건을 달아주어 해당 조건에 충족할 경우 true의 값을, 틀릴 경우 false의 값을 출력하도록 지시한다
- 반드시 불리언일 필요는 없으나, 편의상 불리언으로 예시를 든다.
- 예시 : bool ("변수명") = (("조건") ? ("참일 경우 유도할 값") : ("거짓일 경우 유도할 값"))
- 간단한 if else 문을 한 줄에 작성할 수 있다.
```
int number = 25
bool isPair = ((number % 2) == 0? true : false);
```

## 상수와 열거형
### 상수
- 변수 내 설정한 값을 고정시킨다. 타입명 앞에 const를 입력한다. (const "타입명" "변수명")
```
const int rock = 0
const int scissors = 1
const int paper = 2
```
- 상수에서 const로 설정된 값은 차후 다른 값으로 변경하려고 시도할 경우 오류가 난다.
- switch구문에서 변수는 사용될 수 없으므로 반드시 상수값으로 변경 후 사용해주어야 한다.
- 상수항은 일반 변수와 같이 변수이름만으로 값을 호출할 수 있다.

### 열거형
- 서로 관련되어있으나 따로 나열되어 연관성을 한눈에 보기 힘들다는 단점을 극복하기 위해 열거형을 사용한다.
- 열거형은 반드시 class 아래서 입력해야 한다.
```
class Program
{
	enum Choice	// enum "그룹명"
	{	// 만일 변수 옆에 별도로 값을 지정하지 않을 경우, 기본값으로 0, 1, 2가 차례대로 부여된다.
		rock = 1,
		paper = 2,
		scissors = 0
	}
	
	static void Main(string[] args)
// 이하 생략
```
- 열거형은 상수항, 일반 변수와 달리 값을 호출하는 방법이 다르다.
- 예시 : (int)Choice.Scissors (("타입명") "그룹명"."변수명")

## while문
- while ("조건") 형식으로 입력하며, 만일 조건이 참일경우, while아래 중괄호의 코드가 실행된다. if문과는 다르게 "조건"을 여러번 판독하여 해당 값이 거짓이 될 때까지 반복한다.
```
int count = 5;

while (count > 0)    // while ("조건 =  count가 0 이상일 경우, 아래 코드를 실행한다")
{
	Console.WriteLine('hello world")	// hello world를 출력한다.
	count--;				// count에서 1을 차감한다.
}
```
- while문을 사용할 때, "무한루프"현상이 발생하지 않도록 조심해야 한다.

### do while문
- do 안의 코드를 먼저 실행한다.
- 이후 while문의 조건에 따라서 다음코드의 실행여부를 결정한다.
- 만일 while문의 조건이 미충족할 경우, do 안의 코드를 재실행한다.
- 만일 while문의 조건이 충족될 경우, while문 다음의 코드를 실행한다.
```
{
	string answer;
	// do 안에 있는 코드를 우선실행
	do
	{
	Console.WriteLine("강사님은 잘생기셨나요? (y/n) : ");
	answer = Console.ReadLine();
	
	// 이후 while문 조건에 따라 다음코드의 실행여부 결정, 조건 미충족시 do내 코드 재실행
	} while (answer != "y");

	Console.WriteLine("정답입니다!");
}	
```

## for문
- for ("초기화식"; "조건식"; "반복식")
- "초기화식" : 변수의 초기값을 입력한다
- "조건식" : 변수가 조건식에 해당할 경우, for문 아래의 코드를 실행한다. for문 코드는 "조건식" 내 값이 false가 될 때까지 반복한다.
- "반복식" : for문이 반복될 때마다 추가/감소해줄 조건을 추가로 입력한다.
```
for (int i = 0; i < 5; i++)
{
	Console.WriteLine("hello world!");
}
```
- while문에 비해 적용이 쉽고 가독성이 좋아 자주 사용된다.
- for문에서 "초기화식", "조건식", "반복식"을 모두 채울 필요는 없다.
- for문 실행순서 : "초기화식", "조건식", "for문 하단코드", "반복식"

## continue, break
### break
- 특정 조건 만족 시 "반복문"에서 탈출한다.
```
int num = 10000002;

for (int i = 2; i < num; i++)		// i의 초기값 : 2, i가 num보다 작다면 반복한다, 반복할 때마다 i에 1씩 더한다.
{
	if((num % i) == 0)					// 만약 num이 i로 나누었는데 나머지가 없다면
	{
		Console.WriteLine("소수가 아닙니다");		// "소수가 아닙니다"를 출력한다.
		break;					// for문에서 탈출한다.
	}
}
```

### continue
- 특정 조건 만족 시 아래 코드를 무시하고 다음 값에 따라 반복문을 진행시킨다.
```
for (int i = 1; i <= 100; i++)		// i의 초기값 : 1, i가 100 이하이면 반복한다, 반복할 때마다 i에 1씩 더한다.
{
	if (i % 3 != 0)		// i의 값을 3으로 나누었을 때 0이 아니라면
		continue;		// 아래 코드를 무시하고 다음 값에 따라 반복문을 진행한다.
	
	Console.WriteLine($"3으로 나뉘는 숫자 발견 : {i}");   // (i의 값이 3일 경우 아래 코드로 진행된다)
}
```
- if, else문을 하나하나 적을 경우 코드가 굉장히 복잡해지므로 continue문을 적어 가독성을 높여야 한다.


## Method (Function, Procedure)
- "한정자" "반환형식" "이름" ("매개변수목록") 순으로 작성 가능하다.
```
static void helloworld()
```
- 반드시 class 안에서만 사용이 가능하다.
- 별도의 명령을 미리 입력하고, 이를 호출하여 직접 명령을 내리는 것과 비슷한 효과를 낼 수 있다.
```
class Program
{
	static void helloworld()
	{
		Console.WriteLine("hello world");
	}
	static void Main(string[] args)
	{
		Program.helloworld();		// helloworld();로 입력하여도 크게 상관없다.
	}
}
```

- 입력결과를 받아야 할 경우, "매개변수목록"칸에 입력을 받아야 하는 변수를 적는다.
```
class Program
{
	static int Add(int a, int b)
	{
		int result = a + b;
		return result;
	}
	static void Main(string[] args)
	{
		int result = Program.Add(4, 5);
		Console.WriteLine(result);		// 9
	}
}
```

- 메소드 안의 매개변수는 해당 메소드 안에서만 유효하다.
```
class Program
{
	static int Add(int a, int b)
	{
		int result = a + b;
		return result;
	}
	static void Main(string[] args)
	{
		int a = 4;
		int b = 5;
		int result = Program.Add(b, a);	// int a => b의 값으로 적용, int b => a의 값으로 적용. 즉 5, 4
		Console.WriteLine(result);		// 9
	}
}
```

### 매개변수의 참조
- 기본적으로 매개변수를 적을 경우, "복사"의 형태를 주로 사용한다.
```
class Program
{
	static void Addone(int number)
	{
		number = number + 1;
	}
	static void Main(string[] args)
	{
		int a = 0;
		Program.Addone(a) ; 		// int a의 값인 0이 복사된다.
		Console.WriteLine(a);		
       // 메소드 안에서는 1이 더해졌으나, int a의 값이 곧바로 참조된 것이 아니므로 실질적으로는 아무 일도 벌어지지 않는다.
       // 결과값 : 0
	}
}
```

- ref : 매개변수에 대입하는 변수의 값만 복사하는 것이 아닌, 참조를 시킮으로서 변수 자체를 매개변수로 이용하는 것이 가능
-  "한정자" "반환형식" "이름" (ref "매개변수목록") 순으로 작성한다.
```
class Program
{
	static void Addone(ref int number)		// ref를 매개변수 앞에 입력한다.
	{
		number++;
	}
	static void Main(string[] args)
	{
		int a = 0;
		Program.Addone(ref a) ; 		// 참조할 때도 ref를 입력한다.
		Console.WriteLine(a);		
       // ref를 입력하면서 a의 값을 복사하는 게 아니라 참조하는 형태이기 때문에 int a의 값 또한 변화한다.
       // 결과값 : 1
	}
}
```

### ref와 return을 통한 반환의 차이
- ref를 사용한 값과 return을 사용한 값에서는 실질적인 출력의 차이는 없다.
```
class Program
{
	static void AddOne(ref int number)
	{
		number ++;
	}
	static int AddOne2(int number)
	{
		return number+1;
	}

	static void Main(string[] args)
	{
		int a = 0;
		Program.AddOne(ref a);
		Console.WriteLine(a);	// 0+1 = 1

		a = Program.AddOne2(a);
		Console.WriteLine(a);	// 1+1 = 2
	}
}
```
- 다만 ref와는 달리 return을 통하여 반환된 값은 다른 변수에 저장하는 등 보다 유동적으로 사용할 수 있으므로 ref보다는 return 을 자주 사용하는 편이 좋다.
- ref는 반드시 해당 값을 참조해야 하는 경우에 이용한다.
```
class Program
{
	static void swap(ref int a, ref int b)
	{
		int temp = a;
		a = b;
		b = temp;
	}

	static void Main(string[] args)
	{
		int num1 = 1;
		int num2 = 2;
		Program.swap(ref num1, ref num2);
		Console.WriteLine(num1);		// 2
		Console.WriteLine(num2);		// 1
	}
}
```

### out
- ref와 같이 변수를 참조한다는 개념은 같으나, ref와는 달리 out 이후에 쓰인 매개변수가 사용되지 않으면 오류를 발생시킨다.
- 값 여러 개를 반환해야 할 경우 주로 사용한다.
```
class Program
{
	static void divide(int a, int b, out int result, out int result2)
	{
		result = a / b;	// a / b만 적을 경우 오류가 발생한다. 반드시 out 뒤에 적힌 매개변수를 적어야 한다.
		result2 = a % b;	// a % b만 적을 경우 오류가 발생한다. 반드시 out 뒤에 적힌 매개변수를 적어야 한다.
	}

	static void Main(string[] args)
	{
		int num1 = 10;
		int num2 = 3;

		divide(10, 3, out result1, out result2);

		Console.WriteLine(result1);		// 3
		Console.WriteLine(result2);		// 1
	}
}
```

## 오버로딩
- 메소드의 이름을 똑같이 사용하는 것을 말한다. (메소드의 오버로딩)
- 메소드의 오버로딩 시 메소드 간 타입이 겹치지 않게 주의한다.
- 오버로딩 시 고려대상 : 함수의 이름, 매개변수의 타입 및 개수 (반환형식 및 매개변수의 순서 등은 오버로딩의 고려대상에 들어가지 않는다)
```
class Program
{
	static int add(int a, int b)		// 메소드 이름 : add, 타입 : int, 개수 : 2 (원본)
	{
		Console.WriteLine("add int 호출")
		return a + b;
	}

	static float add(float a, float b)	// 메소드 이름 : add, 타입 : float, 개수 : 2 (타입의 변형)
	{
		Console.WriteLine("add int 호출")
		return a + b;
	}

	static int add(int a, int b, int c)		// 메소드 이름 : add, 타입 : int, 개수 : 3 (갯수의 변형)
	{
		Console.WriteLine("add int2 호출")
		return a + b + c;
	}



	static void Main(string[] args)
	{
		int ret = Program.add(2, 3);
		float ret2 = Program.add(2.0f, 3.0f);
		int ret3 = Program.add(2, 3, 4);
	}
}
```

### 선택적 매개변수
- 매개변수에서 기본값을 지정하여, 해당 값을 입력하지 않을 경우 기본값을 출력하도록 한다.
- 매개변수 내에서 특정 매개변수에 값을 지정하여 대입할 수도 있다.
```
class Program
{
	static int add(int a, int b, int c = 0)		// int a와 int b는 반드시 입력해야하나, int c는 선택사항이다.
	{
		return a + b + c;			// int c를 입력하지 않으면 기본값인 0이 출력된다.
	}

	static int add(int a, int b, int c = 0, float d = 1.0f, double e = 3.0)
	{
		return a + b + c + d + e;			// int c를 입력하지 않으면 기본값인 0이 출력된다.
	}

	static void Main(string[] args)
	{
		Program.add(1, 2, d:2.0f)		// int a와 b 외에 d를 지정하여 값을 넣을 수 있다.
	}
}

```

## 연습문제
1. 구구단을 출력하시오.
```
namespace CSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int a = 2; a <= 9; a++)
			{
				for (int b =1; b<=9; b++)
					{
						Console.WriteLine($"{a} * {b} = {a*b}");
					}
			}
		}
	}
}
```

2. 피라미드 출력하기
```
namespace CSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int a = 1; a < 6; a++)
			{
				for (int b =0; b < a; b++)
					{
						Console.Write("*");
					}
			Console.WriteLine()'
			}
		}
	}
}
```

3. 팩토리얼 계산기

```
namespace CSharp
{
	class Program
	{
		static int Factorial(int n)
		{
			int result = n;
			
			for (int a = n-1; a > 1; a--)
			{
				result = result * a;
			}
			return result;
		{

		static void Main(string[] args)
		{
			int ret = Factorial(10);
			Console.WriteLint(ret);
		}
	}
}
```

### 재귀함수
- 메소드가 메소드 자신을 호출하는 것
- 재귀함수를 사용하는 것 자체는 문제는 없으나, 재귀함수의 한계점을 설정해주지 않으면 오류를 출력한다.
```
class Program
	{
		static int Factorial(int n)
		{
			if (n <= 1)
				return 1;		// 한계치를 지정해주지 않으면 "stack overflow"라는 오류를 출력
			return n * Factorial(n-1);	// 반환값에서 Factorial이 사용되었으므로 다시 Factorial을 호출한다.
		{

		static void Main(string[] args)
		{
			int ret = Factorial(10);
			Console.WriteLint(ret);
		}
	}
```
