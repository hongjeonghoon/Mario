using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct MyVector3
{
    static Vector3 m_right = new Vector3(1.0f, 0.0f, 0.0f);
    public static Vector3 Right
    {
        get
        {
            return m_right;
        }
    }
}

public class Player : MonoBehaviour
{ 
    void Update()
    {
        transform.position += MyVector3.Right * Time.deltaTime;
    }
}
