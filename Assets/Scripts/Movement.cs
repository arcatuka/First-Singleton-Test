using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public static Movement instance;
    public float MoveSpeed;
    private bool isMoving;
    private Vector2 Myinput;
    //private Animator anim;
    // Start is called before the first frame update
    /*
    private void Awake() {
        //anim = GetComponent<Animator>();
    }
    */
    
    private void Awake() {
        if(instance == null)
        {
            instance= this;
        }
        else if (instance!= this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    void Update()
    {
        if(!isMoving)
        {
            Myinput.x = Input.GetAxisRaw("Horizontal");
            Myinput.y = Input.GetAxisRaw("Vertical");


            if(Myinput.x != 0) Myinput.y=0;

            if(Myinput!= Vector2.zero)
            {
                //anim.SetFloat("MoveX",Myinput.x);
                //anim.SetFloat("MoveY",Myinput.y);

                var targetPos = transform.position;

                targetPos.x += Myinput.x;
                targetPos.y += Myinput.y;

                StartCoroutine(move(targetPos));
            }
        }   
        //anim.SetBool("IsMoving",isMoving);
    }

    IEnumerator move(Vector3 tarPos)
    {
        isMoving= true;
        while((tarPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position= Vector3.MoveTowards(transform.position, tarPos, MoveSpeed * Time.deltaTime);

            yield return null;
        }
        transform.position= tarPos;
        isMoving = false;
    }
}
