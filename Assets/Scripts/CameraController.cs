using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject ball;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - ball.transform.position;
    }

    void Pursue(){
        transform.position = ball.transform.position + offset;
    }

    void Update()
    {
        Pursue();
    }
}
