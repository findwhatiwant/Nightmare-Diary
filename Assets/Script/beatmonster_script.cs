using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.Random;

public class beatmonster_script : MonoBehaviour
{
    public GameObject target;
    Vector3 nowpos;
    Vector3 startpos;
    Vector3 startpos2;
    public int state = 0;
    NavMeshAgent nav;

    void playerdetection2(){
        startpos2 = target.transform.position;
        if(startpos != startpos2){
            Debug.Log("Died");
            nav.SetDestination(target.transform.position);
        }else{
            Debug.Log("safe");
        }
    }

    void playerdetection(){
        startpos = target.transform.position;
        Invoke("playerdetection2", 0.1f);
    }

    void Start() {
        nav = GetComponent<NavMeshAgent>();
        nav.speed = 100;
    }

    // Update is called once per frame
    void Update()
    {
        nowpos = this.gameObject.transform.position;
        if(Math.Abs(nowpos.x - target.transform.position.x) < 5 && Math.Abs(nowpos.z - target.transform.position.z) < 5 && state == 0){
            int rand = UnityEngine.Random.Range(0,1);
            state = 1;
            if(rand == 0){
                Debug.Log("Attention!");
                Invoke("playerdetection", 0.5f);
                state = 1;
            }else if(rand == 1){
                Debug.Log("Pass");
            }
        }else if(Math.Abs(nowpos.x - target.transform.position.x) > 5 || Math.Abs(nowpos.z - target.transform.position.z) > 5 && state == 1){
            state = 0;
        }
    }
}
