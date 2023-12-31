using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    private int cherries = 0;
    public Text cherriesText;
    public AudioSource collectSoundEffect;


    private void OnTriggerEnter2D(Collider2D collision) {

        if(collision.gameObject.CompareTag("Cherry")) {
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text = "cherries: " + cherries;
            collectSoundEffect.Play();
        }
    }

}
