using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    RaycastHit hit;
    public int FincPicture = 0;
    public float moveSpeed = 7f;
    public float rotateSpeed = 5.0f;
    public GameObject Quiz;
    public GameObject FindWrongPicture;

    public bool FindWrong1;
    public bool playerMove;

    private float range = 3f;

    private Rigidbody rigid;

    private void Start()
    {
        Player.instance = this;
    }

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }



    private void Movement()
    {
        if (playerMove == true)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            rigid.velocity = new Vector3(h, 0, v) * moveSpeed;

            if (Input.GetMouseButton(1))
            {
                float MouseX = Input.GetAxis("Mouse X");
                float MouseY = Input.GetAxis("Mouse Y");
                Vector3 dir = new Vector3(MouseY, MouseX, 0);
                Vector3 angle = transform.eulerAngles;
                angle += dir * rotateSpeed;
                transform.eulerAngles = angle;
            }
        }
    }

    private void Clicker()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(this.transform.position, Vector3.forward, out hit, range))
            {
                Debug.Log("!23");
                Quiz.gameObject.SetActive(true);

                if (hit.collider.tag == "Picture")
                {
                    FincPicture += 1;
                    hit.transform.gameObject.SetActive(false);
                }
                else
                {
                    Debug.Log("틀린 그림이 아니다");
                }
            }
        }
    }

    public void FindWrong()
    {
        playerMove = true;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out hit, 1000))
            {
                if (hit.collider.tag == "Picture")
                {
                    FincPicture += 1;
                    hit.transform.gameObject.SetActive(false);
                }
                else
                {
                    Debug.Log("틀린 그림이 아니다");
                }
            }
        }
        if (FincPicture == 3)
        {
            TextCtrl.instance.gameObject.SetActive(true);
            TextCtrl.instance.Background.SetActive(true);
            playerMove = false;
            TimeAttack.instace.TimeOut = false;
        }
    }

    void Update()
    {
        Clicker();
        Movement();
        if(FindWrong1 == true)
        {
            FindWrong();
        }
    }
}