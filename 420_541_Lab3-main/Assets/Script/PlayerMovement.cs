using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    float rotationY = 0;
    public float force =  500.0f;
    float vInput;
    float hInput;
    public float rotationSpeed = 150.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Update() {
        vInput = Input.GetAxis("Vertical");
        hInput = Input.GetAxis("Horizontal");
        float mX = Input.GetAxis("Mouse X");
        rotationY += mX * rotationSpeed * Time.deltaTime;
        
        transform.rotation = Quaternion.Euler(0, rotationY, 0);
    }

    public void FixedUpdate() {


        Vector3 fMov = vInput * transform.forward;
        Vector3 rMov = hInput * transform.right;
        Vector3 dir = fMov + rMov;
        dir.Normalize();


        rb.AddForce(dir * force * Time.fixedDeltaTime);

        
    }

}
