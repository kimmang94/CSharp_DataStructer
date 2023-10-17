using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    /*
     * 여러 흐름으로 분기하기
     * 흐름을 반복하기
     * 흐름 중간에 점프하기
     * 
     * 흐름제어 (Flow of Control)
     *  코드 실행 순서를 결정 하는 것
     * 
     * 
     * 분기
     *  제어 흐름을 여러 갈래로 나누는 것
     *  단, 프로그램은 한번에 하나의 갈래로만 실행 할 수 있음
     *  
     *  if문
     *   조건을 만족하는 경우에만 분기 수행
     *   else if, else 절은 옵션
     *   
     *  switch 문
     *   입력식/값이 어떤 사례(case)와 매치 되는지를 평가하여 분기수행
     *   분기 수행 후엔 break 문을 이용하여 switch문을 탈출
     *   
     *  반복
     *   특정 구간의 제어 흐름을 반복 실행
     *   
     *   while
     *      조건을 만족하는 동안 반복 수행
     *      
     *   do while
     *      코드 실행후, 조건을 평가하여 반복 수행
     *      
     *   for 
     *      조건을 만족하는 동안 반복 수행
     *      
     *   점프
     *      흐름을 특정 위치로 단번에 이동
     *          break
     *          continue
     *          goto
     *          return
     *          throw
     *          
     *    break
     *      반복문이나 switch 문의 실행을 중단
     *      
     *    continue
     *      반복을 건너 뛰어 반복을 계속 수행
     *      
     *    goto
     *      지정한 레이블로 제어를 이동
     *      
     *    패턴 매칭
     *      식이 특정 패턴(형태) 와 일치하는지를 검사 하는 것
     *      
     *      장황하고 거추장스러운 분기문을 간결하게
     *      
     *      선언 패턴
     *          주어진 식이 특정 형식과 일치하는지를 평가
     *          if (foo is int bar) // foo 식이 int 와 데이터형식이 일치하면 변수 bar을 선언 
     *          해당 스코프에서 사용 가능
     *          
     *      형식 패턴
     *          형식 패턴은 선언패턴과 거의 같은 방식으로 동작
     *          단, 변수생성 없이 형식일치 여부만 테스트
     *          if (foo is int)  // foo가 int 형식인지 판단
     *          
     *      상수 패턴
     *          식이 특정 상수와 일치하는지검사
     *          var GetCountryCode = (string nation) => nation switch
     *          {
     *              "KR" => 82,
     *              "US" => 1,
     *              "UK" => 44,
     *              - => throw new ArgumentException( "Not supported Code" )
     *          };
     *          
     *        프로퍼티 패턴
     *          식의 속성이나 필드가 패턴과 일치하는 지를 검사
     *          class Car
     *          {
     *              public string Model { get; set; }
     *              public DateTime ProducedAt{ get; set;}
     *          }
     *          
     *          static string GetNickname(Car car)
     *          {
     *              var GenerateMessage = (Car car, string nickname) =>
     *                  $ "{car.Model} produced in {car.ProducedAt.Year} is {nickname}";
     *                  
     *              if (car is Car {Model:"Mustang", ProducedAt.Year: 1967})
     *                  return GenerateMessage(car, "Fastback");
     *              else if (car is Car {model : "Mustang", ProducedAt.Year: 1976})
     *                  return GenerateMessage(car, "Cobra II");
     *              else
     *                  return GenerateMessage(car, "Unknown");
     *           }
     *         
     *         관계 패턴
     *          관계 연산자를 이용하여 입력받은 상수와 비교
     *          관계연산자 : >, >=, ==, !=, <, <=
     *          static string GetGrade(double scroe) => scroe switch
     *          {
     *              < 60 => "F",
     *              >= 60 and < 70 => "D",
     *              >= 70 and < 80 => "C",
     *              >= 80 and < 90 => "B",
     *              _ => "A",
     *           };
     *           
     *          논리 패턴
     *              복수의 패턴을 패턴 논리 연산자 (and, or, not)로 조합
     *              class OrderItrm
     *              {
     *                  public int Amount {get; set;}
     *                  public int Price {get; set;}
     *              }
     *              
     *              static double GetPrice(OrderItem orderItem) => orderItem switch
     *              {
     *                  OrderItem { Amount: 0 } or OrderItem { Price:0 }
     *                      => 0.0,
     *                  OrderItem { Amount: >= 100 } and OrderItem { Price: >= 10_000 }
     *                      => orderItem.Amount * orderItem.Price * 0.8,
     *                  not OrderItem { Amount: < 100 }
     *                      => orderItem.Amount * orderItem.Price * 0.9,
     *                     => orderItem.Amount * orderItem.Price,
     *              };
     *           
     *           위치 패턴
     *              식의 결과를 분해(Deconstruct)하고, 분해된 값들이 내장된 복수의 패턴과 일치하는지를 검사
     *              내장되는 패턴에는 형식 패턴, 상수 패턴 등 모든 패턴 사용 가능
     *              Tuple<string, int> itemPrice  = new Tuple<string, int> ("espresso", 3000);
     *              
     *              if ( itemPrice is ("espresso", < 5000) )
     *              {
     *                  Console.WriteLine ("The Coffee is Affordable.");
     *              }
     *             
     *           var 패턴
     *              null 을 포함한 모든 식의 패턴 매칭을 성공시키고, 그식의 결과를 변수에 할당
     *              식의 결과를 임시 변수에 할당한 다음 추가적인 연산을 수행하고자 할때 유용
     *              
     *              // 평균이 60점 이상인 경우에만 Pass
     *              var IsPassed = 
     *                  (int[] scroes) => scores.Sum() / scores.Length is var average
     *                  && average >= 60;
     *                  
     *              int[] scores1 = { 90, 80, 60, 80, 70};
     *              Console.WriteLine($"{string.Join(",", scores1)}: Pass:{IsPassed(scores1)}"} // true
     *              
     *              int[] scores2 = { 90, 80, 59, 80, 70 };
     *              Console.WriteLine($"{string.Join(",", scores2)}: Pass {IsPassed(scores2)}"} //false
     *              
     *           무시 패턴
     *              var 패턴처럼 모든 식과의 패턴 일치 검사를 성공
     *              단, is식에서는 사용할 수 없고 switch 식에서만 사용 가능
     *              
     *           static string GetGrade(double scroe) => scroe switch
     *          {
     *              < 60 => "F",
     *              >= 60 and < 70 => "D",
     *              >= 70 and < 80 => "C",
     *              >= 80 and < 90 => "B",
     *              _ => "A",
     *           };
     *           여기서의 _ 가 무시패턴
     *           
     *           목록 패턴
     *              배열이나 리스트(List)가 패턴의 시퀀스가 일치하는 지를 검사
     *              패턴의 시퀀스는[와 ] 사이에 패턴의 목록을 입력하여 생성
     *              
     *              var match = (int[] array) => array is [int, >10, _];
     *              Console.WriteLine(match(new int[] {1, 100, 3})); // true
     *              Console.WriteLine(match(new int[] {100, 10, 999})); // false
     *              
     *              var match = (int[] array) => array is [int, >10, ..];
     *              Console.WriteLine(match(new int[] {1, 100, 101, 102, 103, 104})); // true
     *              Console.WriteLine(match(new int[] {100, 10, 999})); // flase
     */

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
