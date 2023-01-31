using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamerule_script : MonoBehaviour
{
    int cnt = 0;
    public Text tx;
    [TextArea]
    public string m_text = "나는 일기의 첫 장을 읽어보았다. “나를 왕따시키는 무리 중 나를 집요하게 쫓아다니면서 괴롭히는 녀석이 있다. 점심시간이면 그 개자식을 피하기 위해 다른반, 화장실로 피해다니고는 했다. 언젠가 송곳이든 뭐든 날붙이로 죽여버릴거다.” 소름이 끼쳐 읽고 덮으려는 순간 난 꿈에 들었고, 꿈속의 나는 교실 안에 있었다. 하지만 교실 밖을 보니 이상한 괴물이 돌아다니고 있었다. 이곳을 탈출하려면 찢어진 일기장을 3장을 모아 지금 교실로부터 건너편 계단으로 뛰어야한다. space를 눌러 진행.....";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing());
    }

    IEnumerator _typing(){
        yield return new WaitForSeconds(0.2f);
        for(int i=0; i<= m_text.Length; i++){
            tx.text = m_text.Substring(0,i);

            yield return new WaitForSeconds(0.02f);
            cnt = i;
            Debug.Log(i);
        }
    }

    void Update(){
        if(cnt > 130){
            if(Input.GetKeyDown("space")){
                SceneManager.LoadScene("Stage1");
            }
        }
    }
}
