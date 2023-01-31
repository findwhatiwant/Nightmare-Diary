using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameover_typing_script : MonoBehaviour
{
    int cnt = 0;
    public Text tx;
    [TextArea]
    public string m_text = "안좋은 꿈...\n\n\nspace를 눌러 진행....";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing());
    }

    IEnumerator _typing(){
        tx.text = "";
        yield return new WaitForSeconds(0.2f);
        for(int i=0; i<= m_text.Length; i++){
            tx.text = m_text.Substring(0,i);
            yield return new WaitForSeconds(0.02f);
            cnt = i;
        }
    }

    void Update(){
        if(cnt > 20){
            if(Input.GetKeyDown("space")){
                SceneManager.LoadScene("StartScene");
            }
        }
    }
}
