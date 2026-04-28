using UnityEngine;

public class Parent
{
    internal void print(object obj)
    {
        Debug.Log(obj);
        Debug.Log(obj);
        return;
        Debug.Log(obj);
    }

    internal int Calc1(int num1, int num2)
    {
        int num3 = num1 + num2;
        return num3;
    }

    void Start()
    {
        print("안녕하세요");
    }
}
