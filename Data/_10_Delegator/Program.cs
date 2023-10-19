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
     */
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
