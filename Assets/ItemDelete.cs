using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDelete : MonoBehaviour
{
    //Unity�����̃I�u�W�F�N�g
    private GameObject unitychan;

    // Start is called before the first frame update
    void Start()
    {
        //Unity�����̃I�u�W�F�N�g���擾
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = unitychan.transform.position.z - this.transform.position.z;

     //   Debug.Log("���΋���: " + distance);

        //������j��

        if (distance > 10f)
        { 
         Destroy(this.gameObject);

         //   Debug.Log("����");
            
        }
    
      //�S�[����艜�Ő������ꂽ���̂�����

        if(this.transform.position.z >360) 
        {
            Destroy(this.gameObject);

         // Debug.Log("���̏���");
        }
    
    
    
    }
}