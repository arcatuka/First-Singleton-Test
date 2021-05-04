using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    // Start is called before the first frame update
    private Inventory inven;
    public GameObject itemButton;
    private void Start() {
        inven = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player"))
        {
            for(int i= 0; i < inven.Slots.Length;i++)
            {
                if(inven.isFull[i] == false)
                {
                    inven.isFull[i] = true;
                                //inven.Slots[i].transform.position
                    Instantiate(itemButton,inven.Slots[i].transform,false);
                    Destroy(gameObject);
                    break;
                }
            }


        }
    }
}
