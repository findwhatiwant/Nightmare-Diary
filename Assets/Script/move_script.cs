using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move_script : MonoBehaviour
{
    [SerializeField]
    private camera_script1 camera_script1;

    public Camera fpscam;
    public GameObject tacks;
    public Light handlight;

    Rigidbody rigid;

    GameObject pp;

    public float moveSpeed;
    private float rotspeed = 7.0f;
    public float enemyspeed;
    float hAxis;
    float vAxis;
    
    Vector3 moveVec;
    Vector3 nowVec;
    Vector3 enemyVec;
    Vector3 newVec;

    Vector3 instantposition;

    Quaternion rot = Quaternion.Euler(0, 0, 0);

    // Start is called before the first frame update

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void lightdown(){
        handlight.intensity -= 0.1f;
    }

    void gameover_func(){
        SceneManager.LoadScene("gameover_stage");
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "monster"){
            GameObject.Find("deadsound").GetComponent<AudioSource>().Play();
            for (int i=30; i>0; i--){
                Invoke("lightdown", 0.05f);
            }
            Invoke("gameover_func", 3.0f);
            
        }
       
    }

    void active_item_use()
    {
        if (Input.GetKeyDown("b"))
        {
            pp = GameObject.Find("state_object");
            if (pp.GetComponent<state_script>().active_item > 0)
            {
                pp.GetComponent<state_script>().active_item -= 1;
                Debug.Log("!!");
                Instantiate(tacks, this.gameObject.transform.position, Quaternion.identity);

            }
        }
    }

    void player_move()
    {
        if(Input.GetKey (KeyCode.W)){
            this.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey (KeyCode.S)){
            this.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey (KeyCode.A)){
            this.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey (KeyCode.D)){
            this.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
    }
    void Rotctr(){
        float rotx = Input.GetAxis("Mouse Y") * -rotspeed;
        float roty = Input.GetAxis("Mouse X") * rotspeed;

        this.transform.localRotation *= Quaternion.Euler (0, roty, 0);
        fpscam.transform.localRotation *= Quaternion.Euler (rotx,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        player_move();
        Rotctr();
        active_item_use();

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("StartScene");
        }

        // float mouseX = Input.GetAxis("Mouse Y");
        // float mouseY = Input.GetAxis("Mouse X");

        // camera_script1.RotateTo(mouseX, mouseY);
    }
}
