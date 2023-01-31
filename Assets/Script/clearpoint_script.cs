using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class clearpoint_script : MonoBehaviour
{
    GameObject pp;
    public GameObject player;
    Vector3 playerposition;
    Vector3 nowposition;
    public Text state;
    //type 1: tutorial, type 2: page, type 3: active item, type 4: clearpoint
    public void itemclicker(int range, int type){
        playerposition = player.transform.position;
        nowposition = this.gameObject.transform.position;
        if(Mathf.Abs(playerposition.x - nowposition.x) < range && Mathf.Abs(playerposition.z - nowposition.z) < range)
        {
            state.text = "SPACE";
            if (Input.GetKeyDown("space"))
            {
                
                pp = GameObject.Find("state_object");
                if(pp.GetComponent<state_script>().page == 3){
                    Destroy(this.gameObject);
                    state.text = "";
                    SceneManager.LoadScene("clearScene");
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
        itemclicker(2,4);
    }
}
