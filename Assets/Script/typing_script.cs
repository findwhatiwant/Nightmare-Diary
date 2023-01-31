using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class typing_script : MonoBehaviour
{
    int cnt = 0;
    public Text tx;
    [TextArea]
    public string m_text = "202X년 X월 XX일 내가 재학중인 학교에서 한명이 자살하는 사건이 발생했다.\n수업 중간에 일어난 일이였고, 경찰이 학교에 들이닥쳤다.\n모든 학생들은 귀가 조치를 받았고, 교직원분들은 조사를 받았다.\n아마 학생은 내일 쯤 조사를 받지 않을까싶다.\n교문을 지나치기 한 10미터쯤 전에 바닥에서 이상한 다이어리를 주웠다.\n일주일 뒤 쯤이면 다시 학교가 정상적으로 돌아갈 것을 알았기에, 난 그것을 들고 나중에 돌려주기로 마음먹고 있었다.\n그리고 집으로 돌아왔다.";

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
        if(cnt > 130){
            if(Input.GetKeyDown("space")){
                SceneManager.LoadScene("startstoryScene");
            }
        }
    }
}
