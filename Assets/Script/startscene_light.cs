using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startscene_light : MonoBehaviour
{
    public Light pointlight2;
    public Light spotlight2;
    public Light pointlight0;
    public Light spotlight0;
    float time = 3;
    float nowtime = 0;
    int state = 0;
    int finalstate = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void lightcontrol(Light pointlight, Light spotlight){
        nowtime += Time.deltaTime;
        if(nowtime > time){
            pointlight.intensity = 0;
            spotlight.intensity = 0;
            state = 1;
            nowtime = 0;
        }
        if(state > 0 & nowtime > 0.1){
            if(state % 2 == 0){
                pointlight.intensity = 0;
                spotlight.intensity = 0;
            }else{
                pointlight.intensity = 1;
                spotlight.intensity = 1;
            }
            state += 1;
            nowtime = 0;
            if(state == 6){
                state = 0;
                finalstate += 1;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(finalstate < 3){
            lightcontrol(pointlight2, spotlight2);
        }else{
            lightcontrol(pointlight0, spotlight0);
        }
    }
}
