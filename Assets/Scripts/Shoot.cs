using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float damage =10f;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "Player")
        {
            SingletonPlayer.Instance.PlayerHP-=damage;
        }
    }
}
