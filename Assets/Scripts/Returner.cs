using UnityEngine;

public class Returner : MonoBehaviour
{
    public Transform spawn;

    void ReturnToSpawn(){
        if(transform.position.y < 0){
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            transform.position = spawn.transform.position;
        }
    }

    void FixedUpdate()
    {
        ReturnToSpawn();
    }
}
