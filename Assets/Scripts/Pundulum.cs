using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pundulum : MonoBehaviour
{
    public float speed = 5f;
    public float amp = 90f;
    public float power = 20f;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, Mathf.Sin(Time.time * speed) * amp));
    }

    void OnCollisionEnter(Collision other){              
        other.collider.GetComponent<Rigidbody>().velocity = new Vector3(other.contacts[0].normal.x * -power, 0, 0);
    }
}
