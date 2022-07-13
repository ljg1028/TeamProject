using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 7f;
    private Rigidbody rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rigid.velocity = new Vector3(h, 0, v) * moveSpeed;
    }
}
