using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Lambda
{
    /*
     *  람다식의 개념
     *  문 형식의 람다식
     *  Func와 Action
     *  식으로 이루어지는 멤버
     * 
     *  람다식 (Lambda Expression)
     *  
     *  다음과 같은 꼴로 이루어진 식(expression)
     *  
     *  식 람다  (매개변수목록) => 식
     *  
     *  문 형식의 람다  (매개변수목록) =>
     *                 {
     *                      문장1;
     *                      문장2;
     *                      ...
     *                 
     *                 
     *                 }
     *                 
     *  람다식으로 무명함수 정의
     *    무명함수(Anonymous Function) : 람다식으로 만드는 익명 메소드
     *    무명함수를 작성하기 위해서는 먼저 대리자로 무명함수의 모습을 결정
     *    ex:
     *    delegate int clculate (int a, int b);
     *    
     *    static void Main(string[] args)
     *    {
     *      Calculate calc = (int a, int b) => a + b;
     *      Console.writeLine(calc(1,2));
     *    }
     *    
     *    delegate int Calculate(int a, int b);
     *    
     *    static void Main(string[] args)
     *    {
     *      Calculate calc = (a, b) => a + b;
     *      Console.WriteLine(calc(1,2));
     *    }
     *    
     *  문 형식의 람다식
     *      람다식 body를 식이 아닌 코드 블록으로 작성
     *      
     *      (매개변수목록) =>
     *      {
     *          문장1,
     *          문장2,
     *          ...
     *      }
     *      
     *      ex:
     *      delegate void DoSomethind();
     *      
     *      static void Main(string[] args)
     *      {
     *          DoSomething DoIt = ( ) =>
     *          {
     *              // 실행 구문
     *          }
     *          
     *          DoIt();
     *      }
     *  
     *  
     *  Func 대리자와 Action 대리자
     *      .NET 라이브러리에 사전 정의되어 있는 대리자
     *      익명 메소드/ 무명함수 정의를 위해 매번 대리자를 새롭게 정의하는 불편을 제거
     *      일반화와 최대 16개 매개변수를 지원
     *      Func 대리자 : 반환 값이 있는 익명 메소드 / 무명 함수용 대리자
     *      Action 대리자 : 반환 값이 없는 익명 메소드 / 무명 함수용 대리자
     *      
     *  Func 대리자
     *      ex:
     *      public delegate TResult Func<out TResult>()
     *      .....
     *      public delegate TResult Funt<in T1, ...... out Tresult>(T1 arg1 ,..... T16 arg16)
     *      
     *      Func<int> func1 = (0) => 10;
     *      Console.WriteLine(func1());
     *      
     *      Func<int,int> func2 = (x) => x * 2;
     *      Console.WriteLine(func2(3));
     *      
     *  Action 대리자
     *      ex:
     *      public delegate TResult Action<out TResult>()
     *      .....
     *      public delegate TResult Action<in T1, ...... out Tresult>(T1 arg1 ,..... T16 arg16)
     *      
     *      Action act1 = () => Console.WriteLine("Action()");
     *      act1();
     *      
     *      Action<double, double> act3 = (x,y) =>
     *      {
     *          double pi = x / y;
     *          Console.WriteLine("Action<T1, T2>({0}, {1}) : {2}, x, y, pi);
     *      };
     *      act3(22.0, 7.0);
     *      
     *  식 트리 (Expression Tree)
     *      코드를 트리 자료 구조로 표현 한것
     *      C#에서는 런타임에 식트리를 생성하고 실행할 수 있음
     *          프로그램 실행 중에 추가적인 코드를 생성하여 실행 가능
     *      앞으로 배울 LINQ, DLR 에서 사용된다
     *      식트리 구축에 주로 람다식을 사용 (API 도 사용 가능)
     *  
     *  식트리의 구조
     *      트리는 노트(Node)로 구성
     *      각 노드는 서로 부모 자식 관계로 연결
     *      
     *  식 트리는 한 부모 노드가 단 두 개만의 자식 노드를 가질 수 있는 이진 트리 (Binary Tree)
     *      연산자 : 부모 노드, 피연산자 : 자식 노드
     *      잎 노드부터 루트 노드까지 계산해 나가면 전체 식의 결과 도출
     *      잎노드 : 더이상 자식 노드를 갖지않은 노드
     *      이진트리 : 자식 노드가 2개인 노드
     *      
     *  식트리 예제(API)
     *      식트리를 이용하여 동적으로 1 + x 무명함수 생성 및 실행
     *      
     *      Expression const1 = Expression.Constant(1); 
     *      Expression param1 = Expression.Parameter(typeof(int), "x")
     *      
     *      Expression exp = Expression.Add( const1, param1);
     *      
     *      Expression<Func<int, int>> lambda1 = Expression<Func<int, int>>.Lambda<Func<int, int>>( exp, new ParameterExpression[] {(ParameterExpression)param1});
     *      Func<int,int> compiledExp = lambda1.Compile();
     *      
     *      Console.WriteLine(compiledExp(3));
     */

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
