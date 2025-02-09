using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{ 
    void Update()
    {
        transform.position += MyVector3.Right * Time.deltaTime;
    }
}
