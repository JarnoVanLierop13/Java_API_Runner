using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public AudioSource thousand;
    public GameObject Background;
    public GameObject Spawner;
    public AudioSource six;
    public AudioSource Bass;
    public int score;
    public Text scoreDisplay;

    private void Update()
    {
        if (score > 0) { 
        if (score % 100 == 0) {
            Bass.Play(); 
          
        }
        if (score % 1000 == 0)
            {
                thousand.Play();
            }
    }
        scoreDisplay.text = score.ToString();

        if (score == 666) {
            six.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        Destroy(other.gameObject);
    }
}
