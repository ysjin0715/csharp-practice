# 객체지향 여행
## 절차지향과 객체지향
### 절차(Procedural) 지향
- 프로그램의 처리과정이 순차적으로 진행되는 것처럼 코드 또한 해당 흐름에 맞게 구성하는 것
- 프로그램이 직관적이라는 장점이 있다.
- 함수가 순서에 종속되어 있으므로 프로그램의 규모가 커질 수록 유지보수가 힘들어지는 단점이 있다
- 기능을 추가시킬수록 각 기능을 담당하는 함수가 추가되므로 프로그램이 필요 이상으로 비대해진다.

### 객체(OOP : Object Oriented Programing) 지향
- 모든 구성을 객체 위주로 생각하는 방법
- 객체를 설계하기 위해서는 속성과 기능으로 분류할 수 있다
- 예시 : (1) 객체 : Knight, (2) 속성 : hp, attack, pos.. , (3) 기능 : Move, Attack, Die..
- class : 객체를 묘사하고 싶을 때 사용한다. (class "변수명")으로 사용한다.
- class 내 코드(설계도)를 이용하여 여러 객체를 만들 수 있다.
- public : 변수를 내부에서만 사용할지, 외부에서만 사용할지 여부를 알려준다. public을 입력하면 외부에서도 사용할 것임을 의미한다.
- new : 새로운 객체를 생성할 때 사용한다. (new "class명"();)형태를 유지한다.
```
class Knight				// "Knight"라는 이름을 가진 객체 설계도 생성
{
	public int hp;
	public int attack;

	public void Move()
	{
		Console.WriteLine("Knight move")
	}

	public void Attack()
	{
		Console.WriteLine("Knight Attack")
	}
}

class Program
{
	static void Main(string[] args)
	{
		Knight knight = new Knight();	// "Knight"라는 설계도를 이용하여 "knight"라는 객체 생성
	
		knight.hp = 100;			// "knight"의 속성 설정
		knight.attack = 10;

		knight.Move();			// "knight"는 Knight객체 내에 담긴 기능을 모두 이용할 수 있다!
		knight.Attack();
	}
}
```

- null : 객체를 존재하지 않는 것으로 여긴다. null로 선언된 객체에 지속적으로 접근할 경우 프로그램이 오류가 발생할 수 있다. {null crash)
```
Knight knight = null;		// knight라는 객체는 없는 것으로 치부한다.

knight.hp = 100;			// 없는 객체로 치부하기로 약속한 객체에 지속적으로 접근하는 모양을 띄므로 오류출력
knight.attack = 10;

knight.Move();
knight.Attack();
```

- null : 객체를 존재하지 않는 것으로 여긴다. null로 선언된 객체에 지속적으로 접근할 경우 프로그램이 오류가 발생할 수 있다. {null crash)
```
Knight knight = null;		// knight라는 객체는 없는 것으로 치부한다.

knight.hp = 100;			// 없는 객체로 치부하기로 약속한 객체에 지속적으로 접근하는 모양을 띄므로 오류출력
knight.attack = 10;

knight.Move();
knight.Attack();
```


## 복사(값)와 참조
### class와 struct
- struct : 변수 이용 시 해당 값을 복사하여 사용한다.
- class : 변수 이용 시 해당 값을 참조한다.
```
class Knight				// 비교1. class Knight
{
	public int hp;
	public int attack;

	public void Move()
	{
		Console.WriteLine("Knight move")
	}

	public void Attack()
	{
		Console.WriteLine("Knight Attack")
	}
}

struct Mage				// 비교2. struct Mage
{
	public int hp;
	public int attack;
}

class Program
{
	static void Killmage(Mage mage)
	{
		mage.hp = 0;		// 결과2. mage.hp의 복사값을 이용했으므로 실제 mage.hp는 100이다.
	}

	static void Killknight(Knight knight)
	{
		knight.hp = 0;		// 결과1. knight.hp의 값을 참조했으므로 실제 knight.hp는 0이다.
	}
	
	static void Main(string[] args)
	{
		Knight knight = new Knight();	// knight 객체 생성 (class 이용)
		knight.hp = 100;			
		knight.attack = 10;

		Knight knight2 = knight;
		knight.hp = 0;		// knight와 knight2의 객체는 서로 같은 것으로 취급한다. (knight에서 원본을 가져왔기 때문)

		Mage mage;		// mage 객체 생성 (struct 이용)
		mage.hp = 100;
		mage.attack = 50;

		Mage mage2 = mage;
		mage2.hp = 0;		// mage와 mage2 객체는 서로 다른 것으로 취급된다.
	
	}
}
```

### 딥 카피
- 객체를 내부 속성까지 완전히 복사하는 것.
- 내부 속성은 별도의 참조값을 가지고 있어 서로 독립적이다.
```
class Knight
{
	public int hp;
	public int attack;

	public Knight Clone()	// 딥 카피 구현 (이미 생성되어 있는 knight 객체의 hp와 attack 값을 그대로 복사한다.
{
	Knight knight = new Knight();
	knight.hp = hp;
	knight.attack = attack;
	return knight;
}
}

//...

Knight knight1 = new Knight();
knight1.hp = 100;
knight1.attack = 10;
knight1.Move();
knight1.Attack();

Knight knight2 = knight1.Clone();	// 딥 카피 실행. (knight1의 속성을 knight2로 복사)
knight2.hp = 0;			// knight1의 hp는 100이나, kngiht2의 hp는 0으로 서로 독립적임을 알 수 있다.
```

## 스택과 힙
### 스택 (stack)
- 불안정한 메모리로 임시로 사용한다.
- 함수 안에 선언되는 변수들은 모두 스택 영역으로 이동한다.
- 임시공간이므로, 공간의 크기가 알아서 커지거나, 줄어든다.
- 스택 내에서 함수가 참조(ref, out)를 통해 스택 내에서 만들어진 함수를 가리킬 경우, 스택이 스택을 참조하는 형태가 만들어지기도 한다. (참조라고 해서 반드시 힙 메모리를 가리키는 것은 아니다)
```
// 예시1. 해당 코드가 저장되는 방식을 도식화한다.
static void Main(string[] args)
{
	Mage mage;
	mage.hp = 100;
	mage.attack = 50;

	Mage mage2 = mage;
	mage2.hp = 0;

	Knight knight = new Knight();
	knight.hp = 100;
	knight.attack = 10;

	Knight knight2 = knight.Clone();
}

// 스택 : 불안정한 메모리로 임시저장소와 같다.
// 모든 함수는 스택 안에 저장된다.

// <스택>
// 1. mage : (원본구조체 Mage에서 복사된 복사본1)
// 2. mage2 : (원본구조체 Mage에서 복사된 복사본2)
// 3. knight : (주소1을 가리킨다 (참조1))
// 4. knight2 : (주소2를 가리킨다 (참조2))
```

### 힙 (heap)
- 참조 타입의 메모리를 할당하는 장소이다.
- 힙 메모리는 반영구적인 공간이므로 별도의 작업이 없는 이상 값이 계속 유지되기도 한다.
- C++은 프로그래머가 할당된 값을 지워주어야 하는 작업이 반드시 요구되나, C#은 참조값을 가리키는 값이 없으면 자동으로 해당 값을 지워준다. (C++에 비해 C#은 메모리를 관리하기 용이하다!)
```
// 힙 : 참조 타입의 메모리를 할당하는 장소

// 1. knight의 주소1
// 2. knight의 주소2
```


