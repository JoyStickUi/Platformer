using UnityEngine;

public class MoveController : MonoBehaviour
{

    private Rigidbody rb;
    [Header("Скорость вращения")]
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }    

    void Movement(){
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void FixedUpdate()
    {
        Movement();
    }
}
