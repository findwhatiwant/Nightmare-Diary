using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class enemy_script : MonoBehaviour
{

    public Transform target;
    Vector3 nowpos;
    public List<Transform> PatrolPath  = new List<Transform> ();
    public Text gameover;

    Rigidbody rigid;
    BoxCollider boxCollider;
    NavMeshAgent nav;
    int state = 0;
    //int followstate = 0;
    int nowpath = 0;

    public int stop = 0;

    MeshRenderer mesh;
    GameObject pp;

    void awake(){
        rigid = GetComponent<Rigidbody>();
        boxCollider = GetComponent<BoxCollider>();
        mesh = GetComponent<MeshRenderer>();
        nav = GetComponent<NavMeshAgent>();

    }

    void follow(Vector3 temp){
        if(stop == 0){
            nav.SetDestination(temp);
        }
    }

    void rere(){
        stop = 0;
        nav.speed = 10;
    }


    private void OnTriggerEnter(Collider collision) {
        if (collision.gameObject.tag == "Tack")
        {
            stop = 1;
            nav.speed = 0;
            Invoke("rere", 3f);
        }
    }
   

    void patrol(){
            if (state == 0)
            {
                follow(PatrolPath[nowpath].position);
                state = 1;
            }
            if (Math.Abs(PatrolPath[nowpath].position.x - nowpos.x) < 2 && Math.Abs(PatrolPath[nowpath].position.z - nowpos.z) < 2)
            {
                Debug.Log(nowpath);
                nowpath += 1;
                if (nowpath == 4)
                {
                    nowpath = 0;
                }
                follow(PatrolPath[nowpath].position);
            }else{
                follow(PatrolPath[nowpath].position);
            }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        awake();
        nav.speed = 10;
    }

    // Update is called once per frame
    void Update()
    {   
        pp = GameObject.Find("state_object");
        nowpos = this.gameObject.transform.position;
        if(pp.GetComponent<state_script>().page == 3){
            nav.speed = 17;
            follow(target.position);
        }
        else if(Math.Abs(nowpos.x - target.position.x) < 10 && Math.Abs(nowpos.z - target.position.z) < 10){
            //followstate = 1;
            follow(target.position);
        }else{
            patrol();
            // if(followstate == 1){
            //     follow(PatrolPath[nowpath].position);
            //     followstate = 0;
            // }
        }
    }
}
