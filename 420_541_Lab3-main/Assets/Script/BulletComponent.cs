using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public float strength;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * strength, ForceMode.Impulse);
        Invoke("DestroyBullet", 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DestroyBullet() {
        Destroy(gameObject);
    }
}
