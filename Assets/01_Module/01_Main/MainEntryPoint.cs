using UnityEngine;

public class MainEntryPoint : MonoBehaviour
{
    // 첫 번째 Update 가 일어나기 바로 직전에 1회호출
    void Start()
    {
        int num;
        bool isTrue = true;
        int num1 = 0;
        string str = "안녕하세요";
        Parent parent = new Parent();
        parent.print(str);

        num = parent.Calc1(12, 45);
        Debug.Log(num);
    }

    // 프레임마다 한번씩 호출되는 함수
    void Update()
    {
        
    }
}
