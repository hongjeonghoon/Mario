using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanjaCreate : MonoBehaviour
{
    //일정시간마다 판자가 만들어진다.
    //그러면 변수가 존재해야한다.
    //0.5초마다 만들어지게 하고싶다.
    [SerializeField]
    private float CreateTime = 0.5f;
    
    void Update()
    {
        //이전프레임에서 0.1초 지났다.
        CreateTime -= Time.deltaTime;
        //일정시간마다 생성
        if (CreateTime <= 0.0f)
        {
            GameObject NewPanja = new GameObject("Panja");
            Vector3 CreatePos=this.transform.position;
            CreatePos.z = 0.0f;

            NewPanja.transform.position = this.transform.position;
            NewPanja.AddComponent<SpriteRenderer>();
            
            CreateTime = 0.5f;
        }
    }
}
