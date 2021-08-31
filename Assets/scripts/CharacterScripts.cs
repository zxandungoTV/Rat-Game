using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScripts : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed, rb.velocity.y, rb.velocity.z);
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, Input.GetAxisRaw("Vertical") * moveSpeed);
    }
}
