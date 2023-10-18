using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        /*
         * 인터페이스
         * 추상클래스
         * 
         * 인터페이스는 청사진
         *  클래스는 객체의 청사진
         *  인터페이스는 클래스의 청사진
         *  클래스가 해야하는 행동을 결정 : 즉, 클래스가 어떤 메소드를 가질지 결정
         * 
         *  인터페이스 선언
         *      interface 키워드를 이용하여 선언
         *      대개 interface의 I로 시작하는 이름으로 명명
         *      인터페이스는 (기본적으로) 메소드 구현부를 갖지않음
         *      인터페이스는 필드를 갖지 않음
         *      
         *      interface 인터페이스명
         *      {
         *          반환형식 메소드이름(매개변수목록);
         *      }
         *      
         *      ex:
         *      interface ILogger
         *      {
         *          void WriteLog( string log );
         *      }
         *      
         *   인터페이스는 약속
         *      인터페이스를 상속하는 실체 클래스는 반드시 인터페이스에서 선언된 메소드를 모두 구현해야함
         *      실체 클래스가 어떤 인터페이스의 파생클래스인지를 알고 있다면 그 클래스가 어떤 public 메소드를 제공하는지도 파악할 수 있음
         *      
         *   인터페이스는 커넥터
         *      커넥터는 두 부품을 연결하는 중간 부품
         *      인터페이스는 두 클래스를 이어주는 커넥터
         *      
         *      class ClimateMonitor
         *      {
         *          private ILogger logger;
         *          public ClimateMoitor(ILogger logger)
         *          {
         *              this.logger = logger;
         *          }
         *      }
         *      
         *      class FileLogger : ILogger
         *      {
         *          private StreamWriter writer;
         *          public FileLogger(string path)
         *          {
         *              writer = File.CreateText(path);
         *              writer.AutoFlush = true;
         *          }
         *          public void WriteLog(string message)
         *          {
         *              writer.WriteLine(message);
         *          }
         *          
         *      }
         *      
         *      var monitor = new ClimateMonitor (new FileLogger("log.txt));
         * 
         * 
         *     추상 클래스 : 인터페이스와 클래스 사이
         *      추상 클래스에서 구현을 가지지 않는 메소드를 추상 메소드 (Abstract Method)라고함
         *      추상 클래스의 파생 클래스는 추상 메소드를 구현 해야 함
         *      
         *     추상 클래스는 객체를 생성할 수 없음. (인터페이스와 같음)
         *     인터페이스를 제공하되 기본적인 구현을 함께 제공하고 싶을 경우 사용
         *     
         *     추상클래스 선언하기
         *      abstract class 키워드를 이용하여 선언
         *      구현체를 갖지 않는 메소드는 abstract 한정자로 수식
         *      
         *      abstract class 클래스이름
         *      {
         *          abstract 추상메소드이름();
         *          
         *          메소드이름()
         *          {
         *          }
         *          
         *      }
         *      
         *      ex:
         *      abstract class AbstractBase
         *      {
         *          public abstract void SomeMethod();
         *      }
         *      
         *      class Derived : AbstractBase
         *      {
         *          public ovveride void SomeMethod()
         *          {
         *          }
         *      }
         */
        static void Main(string[] args)
        {
        }
    }
}
