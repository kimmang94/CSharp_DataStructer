using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Delegator
{
    /*
     *
     *  대리자
     *  익명 메소드
     *  이벤트
     *  
     *  대리자 (Delegator)
     *      코드(메소드)를 대신 실행하는 객체
     *      메소드를 호출하듯 사용 (즉, 인수를 입력하고 결과를 반환 받음)
     *      단, 대리자가 실행할 코드는 컴파일 시점이 아닌 실행 시점에 결정
     *      
     *  대리자의 선언과 사용
     *    delegate 키워드를 이용하여 선언
     *    메소드와 같이 대리자 또한 매개변수 목록과 반환 형식을 가짐
     *    한정자 delegate 반환형식 델리게이트이름 ( 매개변수목록 );
     *    
     *    ex:
     *    private delegate int MyDelegate( int a, int b);
     *    
     *    MyDelegate Callback;
     *    
     *    Callback = new MyDelegate(Plus);
     *    Console.WriteLine( Callback(3,4));
     *    
     *    Callback = new MyDelegate (Minus);
     *    Console.WriteLine( Callback(7,5));
     *    
     *    int Plus(int a, int b)
     *    {
     *      return a + b;
     *    }
     *    
     *    int Minus(int a, int b)
     *    {
     *      return a - b;
     *    }
     *    
     *  익명 메소드(Anonymous Method)
     *      다른 코드 블록에서 재사용될 일이 없는 이름 없는 메소드
     *      익명 메소드 구현 절차
     *          사전 정의된 대리자 형식(반환형식, 매개변수)에 맞춰 익명 메소드 작성
     *          익명 메소드 정의시 delegate 키워드로 시작하며, 정의된 코드는 대리자 참조에 할당
     *          익명 메소드를 할당받은 대리자 참조 호출
     *          
     *          대리자참조 = delegate(매개변수목록)
     *                      {
     *                           // 익명 메소드 본문
     *                      }
     *                      
     *          ex:
     *          public static void Main()
     *          {
     *              Calculate Calc;
     *              Calc = delegate (int a, int b)
     *              {
     *                  return a + b;
     *              }
     *              Console.WriteLine( " 3 + 4 : {0}", Calc(3,4));
     *          }
     *  
     *  이벤트(Event)
     *      C# 에서 객체의 사건을 표현하는 형식
     *      이벤트 처리기 (Event Handler) : 이벤트 발생시 실행되는 메소드
     *      동작 원리는 대리자와 유사
     *          이벤트는 외부에서 직접 "호출"할 수 없음. 객체의 은닉성 표현을 위해
     *      대리자를 event 한정자로 수식하여 선언
     *  
     *  이벤트와 이벤트 처리기 선언
     *      대리자 선언
     *      delegate void EventHandler(string message);
     *      
     *      클래스 내에 대리자 선언을 한 인스턴스를 event 한정자로 수식
     *      class MyNotifier
     *      {
     *          public event EventHandler SomethingHappend;
     *          public void DoSomething(int number)
     *          {
     *              int temp - number % 10;
     *              if (temp != 0 && temp % 3 == 0)
     *              {
     *                  SomethingHappened(String.Format("{0} : 짝", number));
     *              }
     *      }
     *      
     *  이벤트 처리기 작성
     *  
     *      void EventHanleder(string messgae);
     *       
     *      class MainApp
     *      {
     *          static public void MyHandler (string messgae)
     *          {
     *              Console.WriteLine(message);
     *          }
     *      }
     *      
     *  클래스의 인스턴스 생성 및 해당 인스턴스의 이벤트에 처리기 등록
     *  class MainApp
     *  {
     *      static public void MyHandler (string message)
     *      {
     *          Console.WriteLine(message);
     *      }
     *      
     *      static void Main(string[] args)
     *      {
     *          MyNotifier notifier = new MyNotifier();
     *          notifier.SomethingHappended += new EventHandler (MyHandler);
     *          for (int i = 1; i < 30; i++)
     *          {
     *              notifier.DoSomethind(i);
     *          }
     *      }
     *  }
     *  
     */
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
