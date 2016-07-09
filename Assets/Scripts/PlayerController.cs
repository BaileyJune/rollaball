using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //physics code
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        rb.AddForce(Vector3);
    }
}
