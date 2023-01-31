using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using static clicker_script;

public class active_itemclicker_script : MonoBehaviour
{
    public GameObject player;
    public GameObject active_item;
    public Text state;
    clicker_script click;

    //type 1: tutorial, type 2: page, type 3: active item

    // Start is called before the first frame update
    void Start()
    {
        click = new clicker_script();
    }

    // Update is called once per frame
    void Update()
    {
        click.itemclicker(2, 3, player, active_item, state);
    }
}
