using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tack_script : MonoBehaviour
{
    GameObject bb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bb = GameObject.Find("monster");
        if(bb.GetComponent<enemy_script>().stop == 1){
            Destroy(this.gameObject);
        }
    }
}
