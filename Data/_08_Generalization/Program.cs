using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Generalization
{
    /*
     * 일반화 프로그래밍의 개념
     * 일반화 메소드, 클래스
     * 형식 매개변수의 제약
     * 일반화 컬렉션
     * 
     * 일반화란?
     *  특수한 개념으로부터 공통된 개념을 찾아 묶는것 
     * 
     * 일반화 프로그래밍 (Generic Programming)
     *  데이터 형식(Data Type)일반화를 이용하는 프로그래밍 패러다임
     *  한가지 코드를 다양한 데이터 형식에 활용
     * 
     * 일반화 메소드
     *  데이터 형식을 인반화한 메소드
     *  메소드 이름 뒤에 형식 매개 변수를 입력하여 작성
     *      형식 매개 변수 : <> 사이에 일반화 데이터 형식을 입력
     *      컴파일 단계에서 형식 매개 변수는 실제 형식처럼 치환됨
     *      
     *  ex:
     *  void CopyArray(int[] source, int[] target)
     *  {
     *      for (int i = 0; i < source.Length; i++)
     *      {
     *          target[i] = source[i];
     *      }
     *  }
     *  
     *  void CopyArray(string[] source, string[] target)
     *  {
     *      for (int i = 0; i < source.Length; i++)
     *      {
     *          target[i] = source[i];
     *      }
     *  }
     *  
     *  아래처럼 변경 가능
     *  
     *  void CopyArray<T> (T[] source, T[] targer)
     *  {
     *      for (int i = 0; i < source.Length; i++)
     *      {
     *          target[i] = source[i];
     *      }
     *  }
     *  
     *  일반화 메소드 호출
     *      메소드 이름 뒤에<> 안에 구체적인 데이터 형식을 명기하여 호출
     *      
     *  int[] source = {1, 2, 3, 4, 5};
     *  int[] target = new int[source.Length];
     *  
     *  CopyArray<int>(source, target);
     *  
     *  foreach (int element in target)
     *  {
     *      Console.WriteLine(element);
     *  }
     *  
     *  일반화 클래스
     *      데이터 형식을 일반화한 클래스
     *      클래스 이름 뒤에 형식 매개 변수를 입력하여 작성
     *      
     *  class Array_Int
     *  {
     *      private int[] array;
     *      public int GetElement (int index)
     *      {
     *          return array[index];
     *      }
     *  }
     *  
     *  class Array_Double
     *  {
     *      private double[] array;
     *      public double GetElement(int index);
     *      {
     *          return array[index];
     *      }
     *  }
     *  
     *  class Array_Generic<T>
     *  {
     *      private T[] array;
     *      public T GetElement(T index)
     *      {
     *          return array[index];
     *      }
     *  }
     *   
     *  일반화 클래스의 객체 생성하기
     *      클래스 이름 및 생성자 뒤에 <> 안에 구체적인 데이터 형식을 명기하여 객체 생성
     *      
     *  Array_Generic<int> intArr = new Array_Generic<int>();
     *  Array_Generic<double> intDouble = new Array_Generic<double>();
     *  
     *  형식 매개 변수 제약
     *      형식 매개 변수가 특정 조건을 갖추도록 강제하는 기능
     *      문법 : where 형식매개변수 : 제약조건
     *      
     *      ex:
     *      1. 형식 매개변수T를 MyClass 파생 클래스로 제약
     *      class MyList<T> where T : MyClass
     *      {
     *      
     *      }
     *      
     *      
     *      
     *      2. 형식 매개 변수 T를 값 형식으로 제약
     *      void CopyArray<T> (T [] source, T[] target) where T : struct
     *      {
     *          for (int i = 0; i < source.Length; i++)
     *          {
     *              target[i] = source[i];
     *          }
     *      }
     *      
     *  where 절과 함께 사용할 수 있는 제약 조건
     *    where T : struct         T는 값 형식 이어야 한다
     *    where T : class          T는 참조 형식이어야 한다
     *    where T : new()          T는 반드시 매개변수가 없는 생성자가 있어야 한다
     *    where T : 기반클래스이름  T는 명시한 기반 클래스의 파생 클래스 여야한다
     *    where T : 인터페이스이름  T는 명시한 인터페이스를 반드시 구현해야한다. 인터페이스이름에는 여러 인터페이스를 명시할 수 있다.
     *    where T : U              T는 또 다른 형식 매개 변수 U로 부터 상속 받은 클래스 여야한다
     *      
     *      
     *  일반화 컬렉션
     *      컬렌션은 Object 형식 기반
     *      컬렉션의 요소에 접근할 때마다 발생하는 박싱, 언박싱은 성능의 저하고 이어짐
     *      일반화 컬렉션은 형식매개변수를 이용하여 버그와 성능저하를 줄임
     *          컴파일 단계에서 형식매개변수가 특정 형식으로 치환되기 때문
     *      일반화 컬렉션은 System.Collections.Generic 네임스페이스에 위치
     *      
     *      List<T> : ArrayList 의 일반화 버전
     *      Queue<T>
     *      Stack<T>
     *      Dictionary<Tkey, TValue> : Hashtable 의 일반화 버전
     *  
     *  List<T>
     *      ex:
     *      List<int> list = new List<int>();
     *      for (int i = 0; i < 5; i++)
     *      {
     *          list.Add(i);
     *      }
     *      foreach (int element in list)
     *      {
     *          Console.Write("{0} ", element);
     *      }
     *      Console.WriteLine();
     *      list.RemoveAt(2);
     *      
     *  Queue<T>
     *      ex:
     *      Queue<int> queue = new Queue<int>();
     *      queue.Enqueue(1);
     *      queue.Enqueue(2);
     *      queue.Enqueue(3);
     *      queue.Enqueue(4);
     *      queue.Enqueue(5);
     *      
     *      while (queue.Count > 0 )
     *      {
     *          Console.WriteLine(queue.Dequeue());
     *      }
     *  
     *  Stack<T>
     *      ex:
     *      Stack<int> stack = new Stack<int>();
     *      
     *      stack.Push(1);
     *      stack.Push(2);
     *      stack.Push(3);
     *      stack.Push(4);
     *      stack.Push(5);
     *      
     *      while(stack.Count > 0)
     *      {
     *          Console.WriteLine(stack.Pop());
     *      }
     *      
     *  Dictionary<T>
     *      ex:
     *      Dictionary<string, string> dic = new Dictionary<string, string>();
     *      
     *      dic["하나"] = "one";
     *      dic["둘"] = "two";
     *      dic["셋"] = "three";
     *      dic["넷"] = "four";
     *      dic["다섯"] = "five";
     *      
     *      Console.WriteLine(dic["하나"]);
     *      Console.WriteLine(dic["둘"]);
     *      Console.WriteLine(dic["셋"]);
     *      Console.WriteLine(dic["넷"]);
     *      Console.WriteLine(dic["다섯"]);
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
