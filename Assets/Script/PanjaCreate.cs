using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanjaCreate : MonoBehaviour
{
    //�����ð����� ���ڰ� ���������.
    //�׷��� ������ �����ؾ��Ѵ�.
    //0.5�ʸ��� ��������� �ϰ�ʹ�.
    [SerializeField]
    private float CreateTime = 0.5f;
    
    void Update()
    {
        //���������ӿ��� 0.1�� ������.
        CreateTime -= Time.deltaTime;
        //�����ð����� ����
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
