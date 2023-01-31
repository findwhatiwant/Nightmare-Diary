using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_script : MonoBehaviour
{
    Vector3 nowpos;
    Vector3 oo = new Vector3(0, 1, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nowpos = this.gameObject.transform.position;
        if(-42 < nowpos.x && -53 < nowpos.z && nowpos.x < -30 && nowpos.z < -40){
            Debug.Log("!!!");
            transform.position = Vector3.MoveTowards(transform.position, oo, 0.2f);
        }
    }
}
