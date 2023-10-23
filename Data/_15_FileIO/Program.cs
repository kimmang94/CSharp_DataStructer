using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_FileIO
{
    /*
     * 파일과 디렉토리 다루기
     * 스트림 I/O
     * 순차접근과 임의접근
     * System.IO.Stream
     * FileStream 클래스
     * 직렬화
     * 
     * 파일과 디렉토리
     *  파일(File) : 컴퓨터 저장매체에 기록되는 데이터의 묶음
     *  디렉토리 (Directory) : 파일 또는 또 다른 디렉토리의 묶음
     *  폴더 (Folder) : 디렉토리의 동의어
     *  System.IO 네임스페이스의 파일, 디렉토리를 다루는 클래스 위치
     *  
     *  File    파일의 생성, 복사, 삭제, 이동, 조회를 처리하는 정적 메소드 제공
     *  FileInfo    File 클래스와 동일한 기능을 하는 인스턴스 메소드 제공
     *  Directory    디렉토리의 생성, 삭제, 이동, 조회를 처리하는 정적 메소드 제공
     *  DirectoryInfo    Directory 클래스와 동일한 기능을 하는 인스턴스 메소드 제공
     *  
     *  File 기능
     *      생성
     *      File : FileStream fs = File.Create("a.dat");
     *      FileInfo : FileInfo file = new FileInfo("a.dat");
     *      FileStream fs = file.Create();
     *      
     *      복사
     *      File : File.Copy("a.dat", "b.dat");
     *      FileInfo : FileInfo file = new FileInfo("a.dat");
     *      FileInfo dst = src.CopyTo("b.dat");
     *      
     *      삭제
     *      File : File.Delete("a.dat");
     *      FileInfo : FileInfo file = new FileInfo("a.dat");
     *      file.Delete();
     *      
     *      이동
     *      File : File.Move("a.dat", "b.dat");
     *      FileInfo : FileInfo file = new FileInfo("a.dat");
     *      file.MoveTo("b.dat");
     *      
     *      존재 여부 확인
     *      File : if (File.Exists("a.dat")){}
     *      FileInfo : FileInfo file = new FileInfo("a.dat");
     *      if (file.Exists){}
     *      
     *      속성 조회
     *      File : Console.WriteLine(File.GetAttributes("a.dat");
     *      FileInfo : FileInfo file = new FileInfo("a.dat");
     *      Console.WriteLine(file.Attributes);
     *      
     *      
     *  Directory 기능
     *      생성
     *      Directory : DirectoryInfo dir = Directory.CreateDirectory("a");
     *      DirectoryInfo : DirectoryInfo dir = new DirectoryInfo("a");
     *      dir.Create();
     *      
     *      삭제
     *      Directory : Directory.Delete("a");
     *      DirectoryInfo : DirectoryInfo dir = new DirectoryInfo("a");
     *      dir.Delete();
     *      
     *      이동
     *      Directory : Directory.Move("a", "b");
     *      DirectoryInfo : DirectoryInfo dir = new DirectoryInfo("a");
     *      dir.MoveTo("b");
     *      
     *      존재여부 확인
     *      Directory : if (Directory.Exists("a.dat")){}
     *      DirectoryInfo : DirectoryInfo dir = new DirectoryInfo("a");
     *      if (dir.Exists) {}
     *      
     *      속성 조회
     *      Console.WriteLine(Directory.GetAttributes("a");
     *      DirectoryInfo : DirectoryInfo dir = new DirectoryInfo("a");
     *      Console.WriteLine(dir.Attributes);
     *      
     *      하위 디렉토리 조회
     *      Directory : string[] dirs = Directory.GetDirectories("a");
     *      DirectoryInfo : DirectoryInfo dir = new DirectoryInfo("a");
     *      DirectoryInfo[] dirs = dir.GetDirectories();
     *      
     *      하위 파일 조회
     *      Directory : string[] files = Directory.GetFiles("a");
     *      DirectoryInfo : DirectoryInfo dir = new DirectoryInfo("a");
     *      FileInfo[] files = dir.GetFiles();
     *      
     *  스트림(Stream)I/O
     *      stream : 데이터가 흐르는 통로
     *      IO에 있어 스트림은 데이터가 흐르는 통로 를 뜻함
     *      ex : 메모리에서 하드디스크로 데이터 전송시 스트림으로 둘 사이를 연결 후 데이터를 바이트 단위로 전송
     *      
     *  파일에 대합 순차접근 (Sequential Access)
     *      처음부터 끝까지 순서대로 읽고 쓰는 접근방식
     *  
     *  파일에 대한 임의접근 (Random Access)
     *      파일 내의 임의의 위치에 있는 데이터에 즉시 접근하는 방식
     *      
     *  System.IO.Stream 클래스
     *      입력 스트림, 출력 스트림의 역할을 모두 수행
     *      순차접근방식과 임의접근 방식 모두 지원
     *      단, 추상 클래스이기 떄문에 파생 클래스를 이용해야함
     *      
     *  System.IO.FileStream
     *      ex : a.dat 파일에 long형식의 0x123456789ABCDEF0 작성
     *      long someValue = 0x123456789ABCDEF0;
     *      //1 파일 스트림 생성
     *      Stream outStream = new FIleStream("a.dat", FildeMode.Create);
     *      // 2. long형식을 byte배열로 변환
     *      byte[] wBytes = BitCOnverter.GetBytes(someValue);
     *      // 3. 변환한 byte배열을 파일 스트림을 통해 파일에 기록
     *      outStream.Write(wBytes, 0, wBytes.Length);
     *      // 4. 파일 스트림 닫기
     *      outStream.Close();
     *      
     *      ex: a.dat 파일로부터 long 형식에 0x123456789ABCDEF0 읽기
     *      byte[] rBytes = new byte[8];
     *      // 1 파일 스트림 생성
     *      Stream inStream = new FIleSTream("a.dat", FileMode.Open);
     *      // 2 rByte의 길이만큼 데이터를 읽어 rBytes에 저장
     *      inStream.Read(rBytes, 0, rBytes.Length);
     *      // 3 BitConverter를 이용하여 rBytes에 담겨있는 값을 long 형식으로 변환
     *      long readValue = BitConverter.ToInt64(rbytes, 0);
     *      // 4 파일 스트림 닫기
     *      inStream.Close();
     *      
     *  이진 파일 쓰기 BinaryWriter
     *      byte/byte배열 형식으로 변환 없이 이진 데이터 기록 지원
     *      Stream의 파생 클래스(e.g FileStream)와 함께 사용
     *      var fsw = new FileStream ("a.dat, FIleMode.Create);
     *      BinaryWriter bw = new BinaryWriter(fsw);
     *      
     *      bw.Write(int MaxValue);
     *      bw.Write("Good Morning!");
     *      bw.Write(uint.MaxValue);
     *      bw.Write("안녕하세요");
     *      bw.Write(double.MaxValue);
     *      bw.Close();
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
