using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pageclicker_script : MonoBehaviour
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
        if(Mathf.Abs(playerposition.x-nowposition.x) < range && Mathf.Abs(playerposition.z - nowposition.z) < range)
        {
            state.text = "SPACE";
            if (Input.GetKeyDown("space"))
            {
                if(type == 1){
                    SceneManager.LoadScene("SampleScene");
                    state.text = "";
                    Destroy(this.gameObject);
                }
                else if(type == 2){
                    pp = GameObject.Find("state_object");
                    pp.GetComponent<state_script>().page = pp.GetComponent<state_script>().page+1;
                    state.text = "";
                    Destroy(this.gameObject);
                }
                else if(type == 3){
                    state.text = "";
                    Destroy(this.gameObject);
                }

            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        itemclicker(2,2);
    }
}
