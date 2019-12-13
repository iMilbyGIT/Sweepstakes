using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    abstract class SweepstakesStackManager : ISweepstakesManager
    {
        Stack SweepStack = new Stack();
        //private int top;
        //private int MAXSIZE;

        public abstract Sweepstakes GetSweepstakes();

        //how to remove from a stack
        public abstract void InsertSweepstakes(Sweepstakes sweepstakes);
        void Push(Sweepstakes sweepstakes);
        //how to add to to stack


        //void Push(T data)
        //{
        //    if (!isFull())
        //    {
        //        top = top + 1;
        //        SweepStack[top] = data;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Could not insert data, Stack is full.\n");
        //    }
        //}
        //bool isFull()
        //{
        //    if (top == MAXSIZE)
        //        return true;
        //    else
        //        return false;
        //}
        //void Pop(T data)
        //{

        //    if (!isEmpty())
        //    {
        //        data = SweepStack[top];
        //        top = top - 1;
        //        return data;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Could not retrieve data, Stack is empty.\n");
        //    }
        //}
        //bool isEmpty()
        //{
        //    if (top == -1)
        //        return true;
        //    else
        //        return false;
        //}
    }
}

