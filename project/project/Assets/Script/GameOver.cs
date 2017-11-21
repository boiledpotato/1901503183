using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public float threshold;
    // Use this for initialization
    public Text gameoverText;
    void Start()
    {
        gameoverText.text = "";
    }
    void FixedUpdate()
    {
        if (transform.position.y < threshold)
            gameoverText.text = "Game Over";

        
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("FinishLine"))
            gameoverText.text = "Stage Cleared!";
        
    }

}