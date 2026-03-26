using UnityEngine;

public class Calculate : MonoBehaviour
{



    float BasicMath(float a, float b, short sel) // 1=(a+b), 2=(a-b), 3=(a*b), 4=(a/b)
    {
        switch (sel)
        {
            case 1:  return a + b;
            case 2:  return a - b;
            case 3:  return a * b;
            case 4:  return a / b;
            default: return 0;
        }
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BasicMath(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
