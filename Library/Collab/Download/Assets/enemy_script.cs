using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_script : MonoBehaviour
{
    Vector3 nowpos;
    Vector3 class3_hallway = new Vector3(-36, 21, -38);
    Vector3 class3_hallway_right = new Vector3(-30, 21, -52);
    Vector3 class3_left = new Vector3(-66, 21, -52);
    Vector3 class3_right = new Vector3(-43, 21, -52);
    Vector3 class2_hallway = new Vector3(-36, 21, -13);
    Vector3 class2_hallway_right = new Vector3(-30, 21, -25);
    Vector3 class2_left = new Vector3(-66, 21, -25);
    Vector3 class2_right = new Vector3(-43, 21, -25);
    Vector3 class1_hallway = new Vector3(-36, 21, 8);
    Vector3 class1_left = new Vector3(-66, 21, 2);
    Vector3 class1_right = new Vector3(-43, 21, 2);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nowpos = this.gameObject.transform.position;
        if(class3_right.x <= nowpos.x && nowpos.x <= class3_hallway_right.x && class3_right.z <= nowpos.z && nowpos.z <= class2_right.z){
            transform.position = Vector3.MoveTowards(transform.position,class2_hallway, 0.2f);
        }
        if (class3_right.x <= nowpos.x && nowpos.x <= class3_hallway_right.x && class2_right.z <= nowpos.z && nowpos.z <= class1_right.z)
        {
            transform.position = Vector3.MoveTowards(transform.position, class1_hallway, 0.2f);
        }
    }
}
