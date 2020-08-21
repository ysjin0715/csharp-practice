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


