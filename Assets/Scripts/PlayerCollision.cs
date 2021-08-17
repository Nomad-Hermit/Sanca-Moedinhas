using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameManager manager;
    public AudioSource audio;

    private void OnTriggerEnter(Collider other) {
        if (other.name == "Coin") {
            manager.CollectCoin();
            audio.Play();
            Destroy(other.gameObject);
        }
    }
}
