using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Dynamic
{
    /*
     * dynamic 형식의 개념
     * 덕 타이핑
     * COM 상호운용성
     * C#에서 파이썬 코드 사용하기
     * 
     * dynamic 형식
     *  런타임에 형식검가 사 이루어지는 데이터형식
     *      dynamic을 제외한 C#의 모든 데이터 형식은 컴파일 단계에서 형식검사 수행
     *      
     *      ex: 
     *      1. 컴파일 오류 코드
     *      class MyClass
     *      {
     *          public void FuncAAA()
     *          {
     *              Todo
     *          }
     *      }
     *      class MainApp
     *      {
     *          static void Main(string[] args)
     *          {
     *              MyClass obj = new MyClass();
     *              obj.FuncAAA();
     *              obj.FuncBBB();
     *          }
     *      }
     *      
     *      2. dynamic 을 활용한 컴파일 성공 코드
     *      class MyClass
     *      {
     *          public void FuncAAA()
     *          {
     *              Todo
     *          }
     *      }
     *      class MainApp
     *      {
     *          static void Main(string[] args)
     *          {
     *              dynamic obj = new MyClass();
     *              obj.FuncAAA();
     *              obj.FuncBBB();
     *          }
     *      }
     *      
     *  덕타이핑
     *      OOP에서는 오리로 인정받으려면 오리에서 파생되어야 함
     *      dynamic 형식에서는 오리로 인정받으려면 오리처럼 행동 하면됨
     *      
     *      ex : 
     *          class Duck
     *          {
     *              public void Walk()
     *              {
     *              }
     *              
     *              public void Swim()
     *              {
     *              }
     *              
     *              public void Quack()
     *              {
     *              }
     *          }
     *          
     *          class Mallard : Duck
     *          {
     *          }
     *          
     *          class Robot
     *          {
     *              public void Walk()
     *              {
     *              }
     *              public void Swim()
     *              {
     *              }
     *              public void Quack()
     *              {
     *              }
     *          }
     *          
     *         dynamic[] arr = new dynamic[] { new Duck(), new Mallard(), new Robot()};
     *         foreach (dynamic duck in arr)
     *         {
     *              Console.WriteLine(duck.GetType);
     *              duck.Walk();
     *              duck.Swim();
     *              duck.Quack();
     *              
     *              Console.WriteLine();
     *         }
     *         
     *  COM ( COmponent Object Model) 상호 운용성
     *      C# 초기 에는 dynamic 형식 없이 COM 객체 사용
     *          COM은 메소드가 결과를 반환할 때 실제형식이 아닌 object 형식으로 반환하며, C# 코드에서는 이 결과를 다시 실제 형식으로 변환해서 사용
     *          C#의 선택적 인수는 4.0에 도입되엇기 때문에 그전 까지는 COM 메소드의 선택적 인수 중 사용하지 않는 인수에 대해 Type.Missing을 입력
     *      C# 4.0이후
     *          dynamic형식 도입을 통해 번거로운 형식 변환 문제 해결
     *          선택적 인수 도입을 통해 사용하지 않는 인수 생략 가능해짐
     *      ex : COM 상호운용성(엑셀)
     *          1. 4.0 이전
     *          public static void OldWay(stirng[,] data, string savePath)
     *          {
     *              Excel.Application excelApp = new Excel.Application();
     *              excelApp. Workbooks.Add(Type.Missing);
     *              
     *              Excel.Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
     *              for (int i = 0; i < dta.GetLength(0); i++)
     *              {
     *                  ((Excel.Range)workSheet.Cells[i + 1, 1]).Value2 = data[i,0];
     *                  ((Excel.Range)workSheet.Cells[i + 1, 2]).Value2 = data[i,1];
     *              }
     *              
     *              workSheet.SaveAs(savePath + "\\test.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, );
     *              excelApp.Quit();
     *          }
     *          
     *          2. 4.0 이후
     *          public static void NewWay(string[,] data, string savePath)
     *          {
     *              Excel.Application excelApp = new Excel.Application();
     *              excelApp.Workbooks.Add();
     *              Excel._Worksheet workSheet = excelApp.ActiveSheet;
     *              for (int i = 0; i < data.GetLength(0); i++)
     *              {
     *                  workSheet.Cells[i + 1, 1] = data[i,0];
     *                  workSheet.Cells[i + 1, 2] = data[i,1];
     *              }
     *              
     *              workSheet.SaveAs(savePath + "\\test.xlax");
     *              excelApp.Quit();
     *          }
     *  
     *  C#에서 파이썬 코드 사용
     *      DLR은 CLR위에서 동작하며 파이썬이나 루비와 같은 동적 언어를 실행
     *      DLR은 C#과 같은 정적 언어 코드에서 파이썬과 같은 동적언어코드와의 상호동작 지원
     *      DLR과 CLR사이의 상호동작은 dynamic형식을 통해 이루어짐
     *      
     *      ex :
     *          namecard.py
     *          class NameCard:
     *              def__init__(self, name, phone) :
     *                  self.name = name
     *                  self.phone = phone
     *              def printNameCard(self):
     *                  print self.name + ',' + self.phone
     *              NameCard(n, p)
     *          
     *          C#
     *          ScriptRuntime runtime = Python.CreateRuntime();
     *          dynamic result = runtime.ExecuteFile("namecard.py");
     *          
     *          result.name = "고윤정";
     *          result.phont = "010-0000-0000";
     *          resunt.printNameCard();
     *          
     *          Console.WriteLine("{0},{1}", result.name, result.phone);
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
