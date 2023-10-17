using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    #region [설명]
    /*
     * 데이터 형식의 종류
     * 변수의 개념
     * 값형식과 참조 형식
     * 기본 데이터 형식
     * 상수와 열거 형식
     * var 키워드
     * 
     * CPU 의 연산장치
     *   ALU (Arithmetic Logic Unit) : 정수만 처리
     *   FPU (Floating Point Unit) : 부동소수점 수만 처리 <=> Fixed Point Unit : 고정 소수점 
     *
     * CPU는 데이터 타입을 스스로 판단할 수 있는 능력이없다. 그래서 컴파일러가 이작업을 도와준다
     * 
     * 
     * 데이터 형식 (Data Type)
     *  데이터의 '유형'과 '크기'를 지정함
     *  기본 데이터 형식
     *      정수 형식 (char, uchar, sbyte, byte, short, ushort, int, uint, long, ulong)
     *      부동 소수 형식 (float, double)
     *      u : Unsigned 부호가 없다
     *      s : signed 부호가 있다 (byte 의 경우만 s 를 사용한다)
     *      byte 이외의 형식은 uXXX 와 짝을 이룬다
     *  복합 데이터 형식
     *      클래스
     *      구조체
     *      인터페이스
     *      
     *  변수 (Variable)
     *      데이터를 저장할 수 있는 메모리 공간   
     *      코드에서 이름 (Identifier) 을 붙여 사용한다.
     *      
     *      사용법 : 데이터형 식별자 = 값;
     *              데이터형 식별자;
     *              값을 먼저 안넣고 사용도 가능하다
     *          ex : int age = 18;
     *          
     *   메모리 형태
     *      스택 (Stack)
     *          데이터를 쌓아 올리는 구조의 메모리
     *          나중에 쌓인 데이터를 먼저 제거
     *          처음에 쌓인 데이터를 나중에 제거
     *          쌓인 순서의 역순으로 필요 없는 데이터를 자동으로 제거 (자동 메모리)
     *      힙 (Heap)
     *          자유롭게 데이터를 저장할 수 있는 메모리
     *          자유 저장소 (Free Store)
     *          
     *    값 형식 (Value Type)
     *       메모리에 값을 담는 데이터 형식
     *       스택에 할당 (즉, 자동으로 제거)
     *       기본 데이터 형식과 구조체가 여기에 해당
     *       
     *    참조 형식 (Reference Type)
     *       메모리에 다른 변수의 주소를 담는 형식
     *       힙에 할당 (GC에 의해 제거)
     *       복합 데이터 형식과 클래스 등이 여기에 해당
     *       
     *       
     *    기본 데이터 형식 (Primitive Types)
     *      C# 이 제공하는 기본 데이터 형식
     *      수 형식
     *          정수 형식
     *          부동 소수점 형식
     *          논리형식
     *          문자열 형식
     *          object 형식
     *          복합 데이터 형식은 기본 데이터 형식을 바탕으로 만들어짐
     *          
     *    박싱(Boxing) 과 언박싱(UnBoxing)
     *      박싱 : 값 형식을 Object 형식에 담아 Heap 에 올리기
     *      언박싱 : Heap 에 올라가 있는 데이터를 Object에서 꺼내 값 형식으로 옮기기
     *      
     *    상수 (Constant)
     *      변수 : 변경이 가능한 수
     *      상수 : 최초의 상태를 유지하는 수
     *      const 키워드를 이용하여 선언
     *      const 로 선언된 상수는 초기값이 꼭 있어야 한다.
     *      
     *     열거 형식 (Enumerated Type)
     *       하나의 이름 아래 묶인 상수들의 집합
     *       enum 키워드를 이용하여 선언
     *       ex:
     *       enum Data
     *       {
     *          int,
     *          short,
     *       }
     *       
     *     var 키워드 : 형식 추론
     *      var 키워드로 선언한 변수는 컴파일러가 리터럴(값)을 분석하여 자동으로 형식을 추론함
     *      지역 변수에 대해서만 사용가능 : 메소드 안에서만 사용가능
     */
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
