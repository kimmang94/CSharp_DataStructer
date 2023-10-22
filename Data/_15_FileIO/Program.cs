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
     */
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
