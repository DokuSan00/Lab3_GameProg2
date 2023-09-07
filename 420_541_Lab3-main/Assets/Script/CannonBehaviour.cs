using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public float FireButtonPressedTime = 0.0f;
    public float maxTime = 3.0f;

    public GameObject bulletToSpawn;
    public GameObject spawnPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) {
            FireButtonPressedTime += Time.deltaTime;
        }

        if (Input.GetButtonUp("Fire1")) {
            float ratio = FireButtonPressedTime / maxTime;
            ratio = Mathf.Clamp(ratio, 0.0f, 1.0f);
            GameObject bullet = Instantiate(bulletToSpawn, spawnPoint.transform.position, spawnPoint.transform.rotation);

            Destroy(bullet, 5.0f);
            BulletComponent bulletComponent = bullet.GetComponent<BulletComponent>();
            if (bulletComponent != null) {
                bulletComponent.strength *= ratio;
            }

            FireButtonPressedTime = 0.0f;
        }
    }
}
