using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    void Start()
    {
        score = 0;
    }

    public void IncrementScore() {
        ++score;

        if (score >= 4) {
            Debug.Log("You Win!!");
        }
    }
    
}
