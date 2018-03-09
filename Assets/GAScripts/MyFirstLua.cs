using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Config;

public class MyFirstLua : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        ConfigMgr.Instance.Parse();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void AddNumber(int a, int b)
    {
        int c = a + b;
        Debug.Log("--->> AddNumber a:" + a + "  b:" + b + " = " + c);
    }


    public int Add(int a, int b)
    {
        return a + b;
    }


    public void AddRef(int a, ref int b)
    {
        b += a;
    }


    public void AddOut(int a, out int b)
    {
        b = 0;
        b = a + 10;
    }


    public void PrintMethod()
    {
        Debug.Log("--->> This is MyFirstLua PrintMethod()");
    }


    public static void Talk()
    {
        Debug.Log("--->> This is MyFirstLua static method Talk()");
    }


}
