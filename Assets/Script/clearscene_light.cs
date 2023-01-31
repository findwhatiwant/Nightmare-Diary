using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clearscene_light : MonoBehaviour
{
    public Light handlight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        handlight.intensity = 3 - ((this.gameObject.transform.position.y/10)*3);
        if(this.gameObject.transform.position.y > 15){
            SceneManager.LoadScene("cleartextScene");
        }
    }
}
