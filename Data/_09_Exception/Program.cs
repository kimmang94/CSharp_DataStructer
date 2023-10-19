using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Exception
{
    /*
     * 예외의 개념
     * try ~ catch
     * System.Exception 클래스와 파생 클래스
     * throw 문
     * 예외 필터하기
     * 
     * 예외 (Exception)
     *  예전된 프로그램 흐름에서 벗어나는 사건
     * 
     * 예외 처리 (Exception Handling)
     *  예외가 프로그램의 오류나 다운으로 이어지지 않도록 적절하게 처리
     * 
     * 예외를 받아내는 try ~ catch 문
     * try ~ catch 는 구조적으로 예외 처리를 할 수 있게 해주는 문법
     * try 블록에는 실행하고자 하는 코드, catch 블록에는 예외 발생시 처리 코드
     * 
     * try ~ catch 선언
     *  try
     *  {
     *  
     *  }
     *  
     *  catch()
     *  {
     *  
     *  }
     *  catch()
     *  {
     *  }
     *  catch 는 여러개 사용 가능
     *  
     *  ex :
     *  int[] arr = {1, 2 ,3};
     *  
     *   try
     *   {
     *    for (int i = 0; i < 5; i++)
     *    {
     *        Console.WriteLine(arr[i]);
     *    }
     *   }
     *   catch (IndexOutOfRangeException e)
     *   {
     *       Console.WriteLine("예외발생 : {0}", e.Message);
     *   }
     *   
     *   Console.WriteLine("종료");
     * 
     * System.Exception 클래스
     *  System.Exception 클래스는 모든 예외의 조상
     *  IndexOutOfRange Exception 예외도 System.Exception 으로부터 파생
     *  
     *  예외 일으키기
     *      throw 문으로 예외 객체를 던짐
     *      System.Exception 클래스와 그 파생클래스의 인스턴스를 인수로 사용
     *      
     *      try 
     *      {
     *          throw new Exception("예외를 던집니다.");
     *      }
     *      catch (Exception e)
     *      {
     *          Console.WriteLine(e.Message);
     *      }
     *      
     *      static void DoSomething(int arg)
     *      {
     *          if (arg < 10)
     *          {
     *              Console.WriteLine(e.Message);
     *          }
     *          else
     *          {
     *              throw new Exception("arg 가 10보다 큽니다");
                }
     *      }
     *      static void Main()
     *      {
     *          try 
     *          {
     *              DoSomethind(13);
     *          }
     *          catch(Exception e)
     *          {
     *              Console.WriteLine(e.Message);
     *          }
     *      }
     *  
     *  finally 문
     *      try ~ catch 블록 마지막에 붙여 사용
     *      예외 처리 이후의 뒷정리를 할 때 사용함
     *          ex) 파일, 네트워크 커넥션 등과 같은 자원 해제
     *      예외가 일어나던 일어나지 않던 반드시 실행
     *      
     *      ex:
     *      try
     *      {
     *          dbconn.Open();
     *      }
     *      catch (Exception e)
     *      {
     *      
     *      }
     *      finally
     *      {
     *          dbconn.Close();
     *      }
     *      
     *  사용자 정의 예외 클래스
     *      System.Exception 클래스 상속
     *      예외 처리 루틴에 추가 정보를 제공할 때
     *      예외 상황을 보다 구체적으로 설명 해야 할때
     *          class MyException : Exception
     *          }
     *          
     *          {
     *  
     *  예외 필터 (Exception Filter)
     *      catch 블록이 조건을 만족하는 예외 객체만 받아들이게 하는 장치
     *      when 절을 이용해 제약조건(필터) 기술
     *      ex:
     *          class FilterableException : Exception
     *          {
     *              public int ErrorNo {get; set;}
     *          }
     *          
     *          try
     *          {
     *              int num = GetNumber();
     *              if (num < 0 || num > 10)
     *              {
     *                  throw new FIlterableException()
     *                  {
     *                      ErrorNo = num;
     *                  }
     *                  else
     *                  {
     *                      Console.WriteLine($"Output : {num}");
     *                  }
     *              }
     *          }
     *          catch (FilterableException e ) when (e.ErrorNo < 0)
     *          {
     *              Console.Writeline("Negative input is not allowed");
     *          }
     */
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
