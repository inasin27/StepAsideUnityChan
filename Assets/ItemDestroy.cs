using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;

    // Start is called before the first frame update
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");
       
     }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(this.unitychan.transform.position.z - this.transform.position.z);
        if (this.unitychan.transform.position.z-this.transform.position.z > 6f)
        {
            Destroy(this.gameObject);
        }
    }
}
