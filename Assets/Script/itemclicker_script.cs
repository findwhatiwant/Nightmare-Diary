using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using static clicker_script;


public class itemclicker_script : MonoBehaviour
{

    public GameObject player1;
    public GameObject item1;
    public Text state1;
    clicker_script click;

    //type 1: tutorial, type 2: page, type 3: active item

    // Start is called before the first frame update
    
    // Update is called once per frame

    void Start(){
        click = new clicker_script();
    }
    void Update()
    {
        click.itemclicker(1,1,player1, item1, state1);
    }
}
