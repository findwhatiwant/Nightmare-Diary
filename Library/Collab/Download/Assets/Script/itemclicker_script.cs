using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class itemclicker_script : MonoBehaviour
{

    GameObject pp;
    public GameObject player;
    Vector3 playerposition;
    Vector3 nowposition;
    public Text state;

    //type 1: tutorial, type 2: page, type 3: active item

    public void itemclicker(int range, int type){
        playerposition = player.transform.position;
        nowposition = this.gameObject.transform.position;
        //Debug.Log(Mathf.Sqrt(Mathf.Abs(playerposition.x - nowposition.x) * Mathf.Abs(playerposition.z - nowposition.z)));
        if(Mathf.Sqrt(Mathf.Abs(playerposition.x-nowposition.x) * Mathf.Abs(playerposition.z - nowposition.z)) < range)
        {
            state.text = "SPACE";
            if (Input.GetKeyDown("space"))
            {
                Destroy(this.gameObject);
                state.text = "";
                if(type == 1){
                    SceneManager.LoadScene("gameruleScene");
                }else if(type == 2){
                    //pp = GameObject.Find("")
                    int nowpage = GetComponent<state_script> ().page;
                    nowpage += 1;
                }else if(type == 3){

                }

            }
        }else{
            state.text = "";
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        itemclicker(1,1);
    }
}
