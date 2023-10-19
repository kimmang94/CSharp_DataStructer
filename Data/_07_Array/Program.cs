using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Array
{
    /*
     * 
     * 배열
     * 배열 초기화 방법
     * System.Array 클래스
     * 다차원 배열
     * 컬렉션
     * 인덱서
     * 
     * 배열 (Array)
     *  같은 형식의 복수 인스턴스를 저장 할 수 있는 형식
     *  참조형식 으로써 연속된 메모리 공간을 가리킴
     *  반복문, 특히 for, foreach 문과 함께 사용하면 효율 향상
     *  
     *  배열 선언
     *  데이터형식[] 배열이름 = new 데이터형식[];
     *  ex:
     *  int[] array = new int[5];
     *  
     *  배열을 초기화하는 방법 3가지
     *  1. 기본형
     *      배열의 원소 개수를 명시
     *      배열의 각 원소에 입력될 데이터를 입력 { } 로 감싼 블록을 붙힘
     *      string[] arr1 = new string[3] {"1", "2", "3"};
     *  2. 요소개수 생략
     *      배열의 요소 개수 생략
     *      배열의 각 원소에 입력될 데이터를 입력 { } 로 감싼 블록을 붙임
     *      string[] arr2 = new string[] {"4", "5", "6"};
     *  3. new 연산자 형식, 요소 개수 생략
     *      new 연산자, 형식과 괄호 [ ] , 배열의 용량을 모두 생략
     *      배열의 각 원소에 입력될 데이터를 입력 { } 로 감싼 블록을 붙임
     *      string[] arr3 = {"7", "8", "9"};
     *  
     *  System.Array 클래스
     *      모든 배열의 기반 클래스 이며 배열 그 자체를 나타냄
     *      배열을 보다 편리하게 다룰 수 있게 도와주는 유틸리티 메소드 제공
     *      정렬, 탐색, 크기 조정 등의 기능 제공
     *      
     *  다차원 배열
     *      2개의 차원으로 요소 배치
     *          차원의 길이를 뒤에서부터 읽어 해석
     *              ex : int[2,3] : 길이가 3인 1차원 배열을 요소로 갖는 길이가 2인 2차원 배열
     *              
     *  가변 배열
     *      배열의 배열, 즉 배열을 요소로 갖는 배열
     *      요소로 입력되는 배열의 차우너과 길이는 같아야 할 필요없음
     *      선언 형식
     *      데이터형식[] [] 배열의 이름 = enw 데이터형식 [][];
     *      ex:
     *      int [][] jagged = new int[3][];
     *      jagged[0] = new int [5] {1, 2, 3, 4, 5};
     *      jagged[1] = new int [] {10, 20, 30};
     *      jagged[2] = new int [] {100, 200};
     *      
     *      int[][] jagged2 = new int[2][] { new int[] { 1000, 2000}, new int[4] {6, 7, 8, 9} };
     *      
     *  컬렉션(Collection)
     *      같은 성격을 띄는 데이터의 모음을 다루는 자료 구조
     *      배열(System.Array)도 .NET이 제공하는 컬렉션 자료구조 중 하나
     *      ArrayList
     *      Queue
     *      Stack
     *      HashTable
     *      
     *  ArrayList
     *      배열과 같이 인덱스를 이용하여 요소에 접근가능
     *      필요에 따라 동적으로 크기가 증가
     *      요소를 추가하는 Add(), 삭제하는 RemoveAt(), 삽입하는 Insert()메소드 등을 제공
     *      ArrayList list = new ArrayList();
     *      list.Add(10);
     *      list.Add(20);
     *      list.Add(30);
     *      
     *      list.RemoveAt(1);
     *      list.Insert(25, 1);
     *      list[0] = 11;
     *      Console.WriteLine(list[0]);
     *      
     *  Queue
     *      선입선출(FIFO : First In First Out) 구조의 자료구조
     *      데이터를 입력하는 Enqueue(), 출력하는 Dequeue() 메소드 제공
     *      
     *      
     *  Stack
     *      선입후출(FILO : First In Last Out) 구조의 자료구조
     *      데이터를 입력하는 Push(), 출력하는 Pop() 메소드 제공
     *      
     *  HashTable
     *      키(key)와 값(Value)으로 이루어진 데이터를 다룰 때 사용
     *      키를 해싱(hasing)해서 테이블 내의 주소를 계산
     *      배열처럼 다루기 간편하고 탐색속도도 빠름
     *      
     *      ex:
     *      Hashtable ht = new Hashtable();
     *      ht["book"] = "책";
     *      ht["cook"] = "요리사";
     *      ht["tweet"] = "지저귀다";
     *      
     *      Console.WriteLint(ht["book"]);
     *      Console.WriteLint(ht["cook"]);
     *      Console.WriteLint(ht["tweet"]);
     *      
     *  인덱서
     *      인덱스(index)를 이용해서 객체 내의 데이터에 접근하게 해주는 프로퍼티
     *      class 클래스이름
     *      {   
     *          한정자 인덱서형식 this[형식 index]
     *          {
     *              get
     *              {   
     *                  // index를 이용하여 내부 데이터 반환
     *              }
     *              set
     *              {
     *                  // index를 이용하여 내부 데이터 저장
     *              }
     *           }
     *      }
     *   ex:
     *      class MyList
     *      {
     *          private int[] array;
     *          
     *          public MyList()
     *          {
     *              array = new int[3]; 
     *          }
     *          public int this[int index]
     *          {
     *              get 
     *              {
     *                  return array[index];
     *              }
     *              set
     *              {
     *                  if (index >= array.Length)
     *                  {
     *                      Array.Resize<int>(ref array, index + 1);
     *                      Console.WriteLine("Array Resized : {0}", array.Length);
     *                  }
     *                  
     *                  array[index] = value;
     *              }
     *              
     *          }
     *          
     *      
     */
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
