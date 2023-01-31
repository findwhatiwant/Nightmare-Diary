using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



class clicker_script : MonoBehaviour
{
    public void itemclicker(int range, int type, GameObject player, GameObject item, Text state){
        Vector3 playerposition = player.transform.position;
        Vector3 nowposition = item.transform.position;
        GameObject pp;
        if(Mathf.Sqrt(Mathf.Abs(playerposition.x-nowposition.x) * Mathf.Abs(playerposition.z - nowposition.z)) < range)
        {
            state.text = "SPACE";
            if (Input.GetKeyDown("space"))
            {
                Destroy(item);
                state.text = "";
                if(type == 1){
                    SceneManager.LoadScene("gameruleScene");
                }else if(type == 2){
                    int nowpage = GetComponent<state_script> ().page;
                    nowpage += 1;
                }else if(type == 3){
                    pp = GameObject.Find("state_object");
                    pp.GetComponent<state_script>().active_item += 1;
                    state.text = "";
                    Destroy(item);
                }

            }
        }else{
            state.text = "";
        }
    }
}
