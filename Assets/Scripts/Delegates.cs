using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegates : MonoBehaviour
{
     delegate void hamza(int a, int b);
    hamza ham;
    // Start is called before the first frame update
    void Start()
    {
        ham = Add;
        ham(5, 7);
        ham = Multiplication;
        ham(5, 7);
    }

    // Update is called once per frame
    void Update()
    {
       

    }
    void Add(int a, int b)
    {
        int result = a + b;
        Debug.Log("Result is.." + result*2);

    }
    void Multiplication(int a, int b)
    {
        int result = a * b;
        Debug.Log("Result is.." + result * 2);

    }

}
