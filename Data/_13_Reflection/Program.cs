using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Reflection
{
    /*
     * 리플렉션
     *  런타임에 객체의 형식 정보를 들여다 보는 기능
     *  System.Object은 형식 정보를 반환하는 GetType() 메소드 보유
     *  즉, 모든 데이터 형식은 System.Object 형식을 상속하므로 GetType() 메소드 또한 보유
     *  
     *  Object.GetType()과 System.Type
     *      Object.GetType() 메소드는 System.Type 형식 결과를 반환
     *      Type 형식은 .NET 데이터 형식의 모든 정보(메소드, 필드, 프로퍼티 등)를 표현
     *      ex:
     *          int a = 0;
     *          Type type = a.GetType();
     *          FieldInfo[] fileds = type.GetFileds();
     *          
     *          foreach(FieldInfo field in fields)
     *          {
     *              Console.WriteLine("Type: {0}, Name : {1}", field.FieldType.Name, field.Name);
     *          }
     *  
     * System.Type의 주요 메소드
     *  메소드                      반환 형식                설명
     *  GetConstructors()          ConstructorInfo[]        해당 형식의 모든 생성자 목록을 반환
     *  GetEvents()                EventInfo[]              해당 형식의 이벤트 목록을 반환
     *  GetFields()                FieldInfo[]              해당 형식의 필드 목록을 반환
     *  GetGenericArguments()      Type[]                   해당 형식의 형식 매개 변수 목록을 반환
     *  GetInterfaces()            Type[]                   해당 형식이 상속하는 인터페이스 목록을 반환
     *  GetMembers()               MemberInfo[]             해당 형식의 멤버 목록을 반환
     *  GetMethods()               MethodInfo[]             해당 형식의 메소드 목록을 반환
     *  GetNestedTypes()           Type[]                   해당 형식의 내장 형식 목록을 반환
     *  GetProperties()            PropertyInfo[]           해당 형식의 프로퍼티 목록을 반환
     *  
     *  System.Type.GetXXX() 검색 옵션
     *   System.Reflection.BindingFlags 열거형의 상수를 조합
     *     ex:
     *      Type type = a.GetType();
     *      // public 인스턴스 필드 조회
     *      var fileds1 = type.GetFields( BindingFlags.Public | BindingFlags.Instance);
     *      // 비 public 인스턴스 필드 조회
     *      var fields2 = type.GetFields( BindingFlags.NonPublic | BindingFlags.Instance);
     *      // public 정적 필드 조회
     *      var fields3 = type.GetFields( BindingFlags.Public | BindingFlags.Statc);
     *      // 비 public 정적 필드 조회
     *      var fields4 = type.GetFields( BindingFlags.NonPublic | BindingFlags.Statc);
     *  
     *  리플렉션을 이용한 객체 생성 및 활용
     *      System.Ativator 클래스에게 System.Type 객체를 입력하여 인스턴스를 생성
     *      PropertyInfo 클래스의 GetValue()로 값을 읽고, SetValue()로 값 기록
     *      MethodInfo 클래스의 Invoke() 메소드를 통해 메소드 호출
     *      ex:
     *          class Profile
     *          {
     *              public Name {get; set;}
     *              public Phone {get; set;}
     *              
     *              public void Print()
     *              {
     *                  Console.WriteLine("{0}", "{1}", Name, Phone);
     *              }
     *          }
     *          
     *          static void Main()
     *          {
     *              Type type = typeof(Profile);
     *              Profile profile = (Profile)Activator.CreateInstance(type);
     *              
     *              PropertyInfo name = type.PropertyInfo("Name");
     *              PropertyInfo phone = type.PropertyInfo("Phone");
     *              name.SetValue(profile, "박찬호", null);
     *              phone.SetValue(profile, "997-5511", null);
     *              
     *              Console.WriteLine("{0}, {1}, name.GetValue(profile, null), phone.GetValue(profile, null);
     *              
     *              MethfoInfo method = type.GetMethod("Print");
     *              method.Invoke(profile, null);
     *          }
     *  리플렉션을 이용한 형식 생성(내보내기)
     *      ex:
     *          AssemblyBuilder newAssebly = AssemblyBuilder.DefineDynamicAssembly( new AssemlyName("CalculatorAssembly"), AssemblyBuilderAccess.Run);
     *          ModuleBuilder newModule = newAssembly.DefineDynamicModule("Calculator");
     *          TypeBuilder newType = newModule.DefineType("Sum1To100");
     *          
     *          MethodBuilder newMethod = newType.DefineMethod("Calculate", MethodAttributes.Public, typeof(int), new Type[0]);
     *          ILGenerator generator = newMethod.GetILGenerator();
     *          generator.Emit(Opcodes.Ldc_I4,1);
     *          for (int i = 2; i <= 100; i++)
     *          {
     *              generator.Emit(OpCodes.Ldc_I4, i);
     *              generatoe.Emit(OpCodes.Add);
     *          }
     *          generator.Emit(OpCodes.Ret);
     *          
     *          object sum1To100 = Activator.CreateInstance(newType);
     *          MethodInfo Calculate = sum1To100.GetType().GetMethod("Calculate");
     *          Console.WriteLine(Calculate.Invoke(sum1To100, null));
     *          
     *  애트리뷰트(Attribute)
     *      메타데이터(코드에 대한 정보)를 담는 코드 요소
     *      컴파일을 거치면 실행파일(어셈블리)안에 저장되며, 컴퓨터가 런타임에 읽을 수 있음
     *      이와는 달리, 주석은 사람만 읽을 수 있으며 컴파일을 거치면 실행 파일에서는 제거됨
     *      
     *  애트리뷰트 사용
     *      [ ] 사이에 애트리뷰트 명과 매개변수 입력
     *      
     *      [애트리뷰트이름(애트리뷰트매개변수)]
     *      public void MyMethod()
     *      {
     *      
     *      }
     *      ex:
     *          class MyClass
     *          {
     *              [Obsolete("OldMethod는 폐기되었습니다. NewMethod()를 이용하세요")]
     *              public void OldMethod()
     *              {
     *                  Console.WriteLine("Old");
     *              }
     *              public void NewMethod()
     *              {
     *                  Console.WriteLine("New");
     *              }
     *          }
     *  사용자 정의 애트리 뷰트
     *      System.Attribute를 상속하여 사용자 정의 애트리뷰트 선언
     *      ex:
     *          class History : System.Attribute
     *          {
     *              private string programmer;
     *              public double Version {get;set;}
     *              public string Changes {get;set;}
     *              public History(string programmer)
     *              {
     *                  this.programmer = programmer;
     *                  Version = 1.0;
     *                  Changes = "First release";
     *              }
     *              public string Programmer {get {return programmer;}}
     *          }
     *          
     *          [History("Sean", Version = 0.1, Changes = "2010-11-01 Created class stub")]
     *          [History("Bob", Version = 0.2, Changes = "2010-12-03 Added Func() Method")]
     *          class MyClass
     *          {
     *              public void Func()
     *              {
     *                  Console.WriteLine("Func()");
     *              }
     *          }
     */
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
