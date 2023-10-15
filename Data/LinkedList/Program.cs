using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    #region [간단 부가 설명]
    // ArrayList 에서 인자들은 Element 라고 하지만 LinkedList 에서는 node 라고한다

    // 단순 연결 리스트 (Singly Linked List)
    // HEAD -> 1 -> 2 -> 3 -> 4

    // 추가 데이터에 대한 연산 불필요
    // 구현의 어려움
    // 탐색 연산의 비용이 높음

    // AddLast(T data) 마지막에 노드 추가
    // AddFirst(T data) 첫번째에 노드 추가
    // AddAfter(Node<T> node, T value) 노드 뒤에 값 추가
    // Find(T value) 값 찾기
    // Remove(Node<T> removeNode) 노드 제거
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>(); 


        }
    }
}
