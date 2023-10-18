using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    internal class Program
    {
        /*
         * 프로퍼티
         * 자동구현 프로퍼티
         * 프로퍼티를 이용한 객체 초기화
         * 무명 형식
         * 
         * public 필드는 외부 객체에 의해 오염될 가능성을 열어두는것
         * 자바같은 언어에서는 Get/Set 메소드를 이용하여 내부 필드에 접근하도록 함
         * C# 에서는 Get/Set 메소드 뿐 아니라, 필드만큼 편리한 프로퍼티를 제공
         * 
         * class MyClass
         * {
         *      private int myField;
         *      public int GetMyFierId() { return myField; }
         *      public void SetMyField ( int NewValue ) { myField = NewValue; } ;
         *  }
         *  
         *  MyClass obj = new MyClass();
         *  obj.SetMyField(3);
         *  Console.WriteLine(obj.GetMyField());
         *  
         *  
         *  프로퍼티란?
         *   public 필드를 다루듯 내부 필드에 접근하게 해주는 멤버
         *   외부에 데이터를 출력 할 때는 get접근자
         *   내부에 데이터를 입력 할 때는 set접근자
         *   
         *   class 클래스이름
         *   {
         *      데이터형식 필드이름;
         *      접근한정자 데이터형식 프로퍼티이름
         *      {
         *          get
         *          {
         *              return 필드이름;
         *          }
         *          set
         *          {
         *              필드이름 = value;
         *          }
         *       }
         *    }
         *    
         *    ex :
         *    class MyClass
         *    {
         *      private int myField;
         *      public int MyField
         *      {
         *          get
         *          {
         *              return myField;
         *          }
         *          set
         *          {
         *              myField = value;
         *          }
         *      }
         *    }
         *    
         *    MyClass obj = new MyClass();
         *    obj.MyField = 3;
         *    Console.WriteLine(obj.MyField);
         *         
         *         
         *    자동구현 프로퍼티
         *     프로퍼티 구현시, 뻔하게 작성되는 코드를 생략할 수 있음
         *     필드 이름 생략
         *     get 접근자의 반환문(return 필드;) 생략
         *     set 접근자의 필드 수정 (필드 = value;) 코드 생략
         *     
         *     public class NameCard
         *     {
         *          private string name;
         *          private string phoneNumber;
         *          
         *          public string Name
         *          {
         *              get { return name; }
         *              set { name = value; }
         *          }
         *          
         *          public string PhoneNumber
         *          {
         *              get { return phoneNumber; }
         *              set { phoneNumber = value; }
         *          }
         *      }
         *      
         *      VS 
         *      
         *      public class NameCard
         *      {
         *          public string Name
         *          {
         *              get; set;
         *          }
         *          public string PhoneNumber
         *          {
         *              get; set;
         *          }
         *      }
         *      
         *      
         *      프로퍼티를 이용한 객체 초기화
         *          객체를 생성할 때 프로퍼티를 이용한 초기화 가능
         *          프로퍼티를 이용한 초기화는 다음과 같은 형식으로 함
         *          
         *          클래스 이름 인스턴스 = new 클래스이름()
         *          {
         *              프로퍼티1 = 값,
         *              프로퍼티2 = 값,
         *              프로퍼티3 = 값,
         *          }
         *          
         *          프로퍼티를 이용한 초기화의 예
         *          BirthdayInfo birth = new BirthdayInfo()
         *          {
         *              Name = "고윤정",
         *              Birthdat = new DateTime(1996,6,28);
         *          }
         *          
         *      무명 형식
         *      public 프로퍼티로만 이루어진 이름없는 클래스
         *      1회용 데이터형식 으로 사용
         *      무명 형식은 var 키워드와 프로퍼티를 이용하여 선언함
         *      무명 형식의 선언예와 사용 예는 다음과 같음
         *      
         *      var myInstance = new { Name = "고윤정", Age = "28" };
         *      Console.WriteLine (myInstance.Name, myInstance.Age);
         * 
         */
        static void Main(string[] args)
        {
        }
    }
}
