using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{ 
    // Start is called before the first frame update
    public GameObject Player;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject == Player)
        {
            Debug.Log("inDoor");
            //SceneManager.LoadScene("inDoor");
            Application.LoadLevel(1);
        }
    }
}
