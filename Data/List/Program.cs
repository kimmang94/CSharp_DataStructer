using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        #region [간단 부가설명]
        // List
        // ArrayList : 내부적으로 배열을 사용
        // LinkedList : 링크 포인터를 사용
        // List<T> : 제네릭 타입

        // 배열의 특징
        // 생성시 사용할 공간을 미리 할당한다
        // 인덱스를 사용 데이터 접근에 빠르다
        // 데이터의 크기를 변경하지 못한다.

        // 배열의 사용방법
        // int[] array = new int[5];
        // array[0] = 1;
        // array[1] = 2;
        // array[2] = 3;
        // array[3] = 5;
        // array[4] = 6;

        // 리스트의 특징
        // 데이터의 추가 삭제가 자유롭다
        // 생성 시 크기를 지정하지 않는다.
        // 리스트를 다른 말로 Dynamic Array 라고 부른다
        // 데이터의 크기가 정해져 있지않고, 동적으로 삽입,삭제 가능
        // 데이터 타입에 관계없이 삽입이가능
        // 배열보다 속도가 느리다

        // 리스트의 사용방법 
        // 데이터 타입을 별도로 설정하지않음(object로 받음(Add))
        // index를 통해 접근 가능
        // ArrayList list = new ArrayList();
        // list.Add(1);
        // list.Add(2);
        // list.Add(3);
        // list.Add(5);
        // list[3] = 4; 1,2,3,4 가 출력된다
        // ArrayList.Insert(int index, object value)
        // list.Insert(3,4) : 1,2,3,4,5 가 출력된다
        
        // ArrayList.RemoveAt(int index);
        // list.RemoveAt(4);  해당 인덱스를 삭제
        // list.Remove(4); 해당 값을 삭제
        
        // ArrayList.Count;
        // 해당 ArrayList 의 갯수를 가져옴 (배열은 Length)

        // 박싱 (Boxing) : 값 형식을 참조 형식으로 변환하는것
        // 언박싱 (Unboxing) : 참조 형식을 값 형식으로 변환하는것

        // List<T> : T 는 아직 설정이안되었다 데이터타입을 정하고 사용가능
        // 저장할 데이터 타입을 T에 인자값으로 넘긴다
        // List<int>, List<double>, List<Music>, List<string[]>
        // List<string> MusicList = new List<string>();
        // MusicList.Add("좋은날");
        // MusicList.Add("귀로");
        // MusicList.Add("아무노래");
        // MusicList.Add("On");

        #endregion
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add("a");
            list.Add(1);
            list.Add(true);

            for (int i =0; i < list.Count; i++) 
            {
                Console.WriteLine(list[i]);
            }


            List<string> comicList = new List<string>();
            comicList.Add("슬램덩크");
            comicList.Add("드래곤볼");
            comicList.Add("나루토");

            

            for (int i = 0; i < comicList.Count; i++)
            {
                Console.WriteLine(comicList[i]);
            }

            comicList.Insert(2, "블리치");

            for (int i = 0; i < comicList.Count; i++)
            {
                Console.WriteLine(comicList[i]);
            }

            comicList.Sort();

            for (int i = 0; i < comicList.Count; i++)
            {
                Console.WriteLine(comicList[i]);
            }

            Console.ReadLine();
        }
    }
}
