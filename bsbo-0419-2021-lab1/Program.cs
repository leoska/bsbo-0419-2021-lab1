// library of classes, stack, bubble sort
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        Random random = new Random();
        int N = 15;

        for(int i = 0; i < N; i++)
        {
            stack.Push(random.Next(1, 100));
        }
        Print(stack);

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N - 1 - i; j++)
            {
                if (Get(stack, j) > Get(stack, j + 1))
                {
                    int a;
                    a = Get(stack, j);
                    Set(stack, j, Get(stack, j + 1));
                    Set(stack, j + 1, a);
                }
            }
        }

        Print(stack);
    }
    static void Print(Stack<int> stack)
    {
        int n = stack.Count;
        int[] array;
        array = new int[n];
        
        
        stack.CopyTo(array, 0);
        
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine("\n");
    }
    
    static int Get(Stack<int> stc, int id)
    {
        Stack<int> stc_2 = new Stack<int>();

        for (int i = stc.Count - 1; i > id; i--)
        {
            stc_2.Push(stc.Pop());
        }

        int tmp = stc.Last<int>();
        int size = stc_2.Count;
        for (int i = 0; i < size; i++)
        {
            stc.Push(stc_2.Pop());
        }

        return tmp;
    }

    static void Set(Stack<int> stc, int id, int newValue)
    {
        Stack<int> stc_2 = new Stack<int>();
        for (int i = stc.Count - 1; i > id; i--)
        {
            stc_2.Push(stc.Pop());
        }

        stc.Pop();
        stc.Push(newValue);
        int size = stc_2.Count;

        for (int i = 0; i < size; i++)
        {
            stc.Push(stc_2.Pop());
        }
    }
}
