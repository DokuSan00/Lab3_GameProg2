using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBahaviour : MonoBehaviour
{
    // Start is called before the first frame update
    ScoreManager scoreMan;
    void Start()
    {
        scoreMan = FindFirstObjectByType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other) {
        if (scoreMan != null) {
            if (other.gameObject.tag == "Projectile") {
                scoreMan.IncrementScore();
                Invoke("UnhideTargets", 3.0f);
                gameObject.transform.parent.GetComponent<Renderer>().material.color = Color.red;
                gameObject.SetActive(false);
                Destroy(other.gameObject);
            }
        }
    }

    public void UnhideTargets() {
        gameObject.SetActive(true);
        gameObject.transform.parent.GetComponent<Renderer>().material.color = Color.green;
    }
}
