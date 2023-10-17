using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    /*
     *  메소드란?
     *  메소드 선언하기
     *  메소드 호출하기
     *   참조로 매개변수 전달하기
     * 출력전용 인수, 가변길이 인수, 명명된 인수, 선택적 인수
     * 
     *  메소드(Method)
     *   일련의 코드를 하나의 이름 아래 묶은것
     *   묶은 코드는 메소드의 이름을 불러주는 것만으로 실행
     *   C/C++ 에서는 함수(Function), 파스칼에서는 프로시저(Procedure) 등으로 부름
     * 
     *  메소드의 선언
     *   클래스 내부에 선언
     *   메소드 선언 필수 요소 3가지
     *       1. 반환형식
     *       2. 메소드 이름
     *       3. 매개변수 목록
     *   결과를 반환할 때 return 문을 사용
     *  
     *   class 클래스의이름
     *   {
     *       한정자 반환형식 메소드의이름 ( 매개변수 목록 )
     *      {
     *      
     *          return 메소드결과;
     *      }
     *   }
     *  
     *  입력(매개변수에 의해) -> Method -> 출력(결과값)
     *  
     *  메소드 호출
     *  클래스명.메소드명(매개변수가있다면 매개변수);
     *  
     *  return
     *      호출자에게 결과를 반환
     *      프로그램의 제어를 즉시 호출자에게 이동시킴
     *          메소드 중간에 호출하는 경우 메소드에 실행되지 않은 코드가 생길 수 있음
     *      반환 형식과 일치하는 데이터를 반환해야함
     *      메소드가 void 형식인 경우 반환값 없이 사용 가능
     *      
     *  참조로 인수 전달하기
     *      매개변수가 인수를 참조
     *      ref 키워드를 이용하여 선언, 호출
     *      
     *      public static void Swap(int a, int b)
     *      {
     *          int temp = b;
     *          b = a;
     *          a = temp;
     *      }
     *      
     *      static void Main(string[] args)
     *      {
     *          int x = 3;
     *          int y = 4;
     *          
     *          Swap(x, y);
     *      }
     *      
     *      public static void Swap(ref int a, ref int b)
     *      {
     *          int temp = b;
     *          b = a;
     *          a = temp;
     *      }
     *      
     *      static void Main(string[] args)
     *      {
     *          int x = 3;
     *          int y = 4;
     *          
     *          Swap(ref x, ref y);
     *      }
     *      
     *  출력 전용 매개변수 : return 과 유사
     *      메소드는 out 키워드로 한정한 매개변수에 결과를 입력해야 함
     *      out 키워드는 ref 키워드와 비슷하지만, 참조로 인수 전달을 하는 경우 인수의 값이 수정되지 않아도 컴파일러가 에러를 출력하지 않음
     *      void Divide(int a, int b, out int quotient, out int remainder)
     *      {
     *          quotient = a / b;
     *          remainder = a % b;
     *      }
     *      
     *      int a = 20;
     *      int b = 3;
     *      int c;
     *      int d;
     *      Divide (a, b, out c, out d);
     *      Console.WriteLine("Quotient : {0}, Remainder {1}", c, d);
     *      
     *      ref 는 인수변환에 따라 에러발생x
     *      out 은 인수변환이 없으면 에러발생o
     *      
     *  메소드 오버로딩
     *      하나의 메소드 이름에 여러 버전의 구현을 올리는것
     *      Overloading : 과적하다
     *      기능은 같으나 데이터 형식이 다른경우 사용
     *      int Plus(int a, int b)
     *      {
     *          return a + b;
     *      }
     *      
     *      double Plus(double a, double b)
     *      {
     *          return a + b;
     *      }
     *      
     *  가변길이 인수
     *      개수를 유연하게 조절할 수 있는 인수
     *      params 키워드와 배열을 이용하여 선언
     *      데이터 형식이 같다면 가변길이 인수를 통해 오버로딩 대신 사용
     *    구현
     *      int Sum( params int[] args)
     *      {
     *          int sum = 0;
     *          for (int i = 0; i < args.Length; i++)
     *          {
     *              sum += args[i];
     *          }
     *          return sum;
     *       }
     *     호출
     *      int total = 0;
     *      total = Sum(1,2);
     *      total = Sum(1,2,3,4);
     *      total = Sum(1,2,3,4,5,6,7,8,...);
     *      
     *   선택적 인수
     *      메소드 선언시 매개변수에 기본값을 할당
     *      호출자가 인수를 입력하지 않는 경우 메소드는 기본값이 할당된 매개변수 사용
     *      따라서 호출자는 매개 변수에 대한 인수입력 여부 선택이 가능해짐
     *     선언
     *      void MyMethod(int a = 0, int b = 0)
     *      {
     *          Console.WriteLine( "{0}, {1}", a, b);
     *      }
     *      
     *      매개변수를 생략하고 호출하면 a와 b의 기본값이 출력된다
     */
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
