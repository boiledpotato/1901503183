using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisappearCollide : MonoBehaviour {

    public AudioSource audio;
    public AudioClip clip;
    public Text countText;

    private int count;
    

    void Start()
    {
        count = 0;
        SetCountText();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            
            other.gameObject.SetActive(false);
            count = count + 100;
            SetCountText(); 
            audio.PlayOneShot(clip);
            
        }
    }
    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
    }
}
