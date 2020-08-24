# Csharp 사용 시 오류모음
## "(변수명)이 현재 컨택스트에 없습니다."
- (변수명)이 현재 유효범위 (중괄호)에서 벗어났음을 알리는 오류
- (변수명)을 유효범위 내 설정해주면 오류가 해결된다.
```
// 오류발생 ("answer이 현재 컨택스트에 없습니다")
do
{
	Console.WriteLine("강사님은 잘생기셨나요? (y/n) : ");
	string answer = Console.ReadLine();
} while (answer != "y");

// 오류해결
static void Main(string[] args)
{
	// 유효범위 내 변수설정
	string answer;

	do
	{
	Console.WriteLine("강사님은 잘생기셨나요? (y/n) : ");
	answer = Console.ReadLine();
	} while (answer != "y");
	Console.WriteLine("정답입니다!");
}	
```