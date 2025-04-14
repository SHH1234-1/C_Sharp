using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace 백준
{
    internal class 백준_10845
    {
        static void Main(string[] args) {
            int num = int.Parse(Console.ReadLine()); //첫째 줄에 주어지는 명령의 수
            Queue<int> queue = new Queue<int>(); //Q생성
            for (int i = 0; i < num; i++) // 명령의 수 만큼 반복
            { 
                StringBuilder sb = new StringBuilder();
                string a = Console.ReadLine(); //
                string[] token = a.Split(' ');

                if (a.Contains("push"))//push X: 정수 X를 큐에 넣는 연산이다.
                {
                    int b = int.Parse(token[1]);
                    queue.Enqueue(b);
                }
                else if (a.Contains("pop")) //pop: 큐에서 가장 앞에 있는 정수를 빼고, 그 수를 출력한다. 만약 큐에 들어있는 정수가 없는 경우에는 -1을 출력한다.
                {
                    if (queue.Count == 0)
                        sb.Append(-1);
                    else
                        sb.Append(queue.Dequeue());
                }
                else if (a.Contains("empty"))//empty: 큐가 비어있으면 1, 아니면 0을 출력한다.
                {
                    int empty = (queue.Count > 0) ? 0 : 1;
                    sb.Append(empty);
                }
                else if (a.Contains("front"))//front: 큐의 가장 앞에 있는 정수를 출력한다. 만약 큐에 들어있는 정수가 없는 경우에는 -1을 출력한다.
                {
                    if (queue.Count == 0)
                        sb.Append(-1);
                    else
                        sb.Append(queue.Peek);
                }
                else if (a.Contains("back"))//back: 큐의 가장 뒤에 있는 정수를 출력한다. 만약 큐에 들어있는 정수가 없는 경우에는 -1을 출력한다.
                {
                    if (queue.Count == 0)
                        sb.Append(-1);
                    else
                    {
                        int[] Array = queue.ToArray();
                        sb.Append(Array[Array.Length - 1]);
                    }
                }
                else if (a.Contains("size"))//size: 큐에 들어있는 정수의 개수를 출력한다.
                { 
                    sb.Append(queue.Count);
                }
                if(!a.Contains("push"))
                    Console.WriteLine(sb.ToString());
            }
        }
    }
}
