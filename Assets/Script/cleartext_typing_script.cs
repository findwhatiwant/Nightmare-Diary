using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cleartext_typing_script : MonoBehaviour
{
    int cnt = 0;
    public Text tx;
    [TextArea]
    public string m_text = "나는 1층에 주운 일기장의 일부를 읽어보았다. “왕따를 당하기 시작하고부터 복도를 지나다니는 것만으로 주위를 신경쓰고, 심장이 떨려왔다. 그녀석들이 나를 뚫어져라 쳐다볼 때 나는 한발자국도 움직일 수 없었다… 숨이 잘 안쉬어질 정도로 심장이 빨리 뛰곤한다.”굉장히 오타쿠가 쓴 것 같은 글이다.계단을 올라 2층에 도착했을 때, 나는 또다른 괴물들을 마주했다.";

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
        }
    }

    void Update(){
        if(cnt > 10){
            if(Input.GetKeyDown("space")){
                SceneManager.LoadScene("Stage2");
            }
        }
    }
}
