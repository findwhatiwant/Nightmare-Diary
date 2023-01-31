using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class state_script : MonoBehaviour
{
    public int page = 0;
    public int active_item = 0;
    public Text scc;
    int onetimestate = 0;

    void removetext(){
        scc.text = "";
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(active_item > 0 && onetimestate == 0){
            scc.text = "B를 눌러 압정 사용 가능";
            Invoke("removetext", 2f);
            onetimestate = 1;

        }
        if(Input.GetKeyDown("v")){
            Debug.Log(page);
        }
    }
}
