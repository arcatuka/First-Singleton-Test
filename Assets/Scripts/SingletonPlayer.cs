using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SingletonPlayer : MonoBehaviour
{
    public static SingletonPlayer Instance{
        get; private set;
    }

    public float PlayerHP= 100;
    public float PlayerAttack = 10;
    private void Awake() {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }
}
