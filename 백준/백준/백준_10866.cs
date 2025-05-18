using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준
{
    internal class 백준_10866
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            LinkedList<int> list = new LinkedList<int>();
            int size = 0;
            for (int i = 0; i < N; i++) 
            { 
                string s = Console.ReadLine();
                string[] token = s.Split(' ');
                string a = token[0];
                StringBuilder sb = new StringBuilder();
                switch (a) 
                {
                    case "push_back":
                        int n = int.Parse(token[1]);
                        list.AddLast(n);
                        size++;
                        break;
                    case "push_front":
                        int m = int.Parse(token[1]);
                        list.AddFirst(m);
                        size++;
                        break;
                    case "pop_front":
                        if (list.First != null)
                        {
                            sb.Append(list.First.Value);
                            list.RemoveFirst();
                            size--;
                        }
                        else 
                        {
                            sb.Append(-1);
                        }
                        break;
                    case "pop_back":
                        if (list.Last != null)
                        {
                            sb.Append(list.Last.Value);
                            list.RemoveLast();
                            size--;
                        }
                        else 
                        {
                            sb.Append(-1);
                        }
                        break;
                    case "size":
                        sb.Append(size);
                        break;
                    case "empty":
                        int empty = (list.Count > 0) ? 0 : 1;
                        sb.Append(empty);
                        break;
                    case "front":
                        int front = (list.First != null) ? list.First.Value : -1;
                        sb.Append(front);
                        break;
                    case "back":
                        int last = (list.Last != null) ? list.Last.Value : -1;
                        sb.Append(last); 
                        break;
                }
                if (!a.Contains("push"))
                    Console.WriteLine(sb.ToString());
            }
        }
    }
}