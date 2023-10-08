using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDelete : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;

    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = unitychan.transform.position.z - this.transform.position.z;

     //   Debug.Log("相対距離: " + distance);

        //自分を破棄

        if (distance > 10f)
        { 
         Destroy(this.gameObject);

         //   Debug.Log("消去");
            
        }
    
      //ゴールより奥で生成されたものを消す

        if(this.transform.position.z >360) 
        {
            Destroy(this.gameObject);

         // Debug.Log("奥の消去");
        }
    
    
    
    }
}