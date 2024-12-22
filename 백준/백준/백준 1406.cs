using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준
{
    internal class 백준_1406
    {
        class Program
        {
            static void Main(string[] args)
            {
                string s = Console.ReadLine(); //첫번째 줄을 입력받아 s에 저장 
                int n = int.Parse(Console.ReadLine()); //두번째 테스트 케이스의 개수를 입력받아 n에 저장
                LinkedList<char> sb = new LinkedList<char>(s); //s를 리스트안에 넣어줌
                sb.AddLast(' '); //리스트 마지막에 ' ' 추가
                LinkedListNode<char> cursor = sb.Last; //sb의 마지막 노드를 가리키는 cursor변수 추가

                for (int i = 0; i < n; i++) 
                { 
                    string m = Console.ReadLine(); //테스트 케이스 개수 담기
                    string[] token = m.Split(' '); //공백을 기준으로 split 해서 배열에 넣기
                    string a = token[0]; //명령어를 a에 저장

                    switch (a) //명령어를 switch문으로 받아서
                    {
                        case "L":
                            {
                             if (cursor.Previous != null) //커서가 문장의 맨앞이 아닐때
                                cursor = cursor.Previous; //커서를 왼쪽으로 한칸 옮김

                                break;
                            }
                        case "D":
                            {
                                if (cursor.Next != null) //커서가 문장의 맨 뒤일때
                                    cursor = cursor.Next; //커서를 오른쪽으로 한 칸 옮김

                                break;
                            }
                        case "B":
                            {
                                if (cursor.Previous != null) //커서가 문장의 맨 앞일때
                                { 
                                    sb.Remove(cursor.Previous); //커서 왼쪽의 문자를 삭제
                                }    

                                break;
                            }
                        case "p":
                            {
                                if (cursor.Previous != null)
                                {
                                    char charToAdd = char.Parse(token[1]); //문자를 charToAdd에 넣음
                                    sb.AddBefore(cursor, charToAdd); //거서의 왼쪽에 문자추가

                                    break;
                                }

                                break;
                            }

                    }
                }
                sb.RemoveLast();
                StringBuilder result = new StringBuilder();  //result 넣고
                foreach (var x in sb) 
                { 
                    result.Append(x);  
                }
                Console.WriteLine(result.ToString()); //출력
            }
        }
    }
}
