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

