using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float moveForce = 10f;
    [SerializeField]
    private float jumpForce = 11f;
    private float movementX;
    private Rigidbody2D myBody;
    private SpriteRenderer  sr;

    private Animator anim;
    private string WALK_ANIMATION = "Walk";
    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayermMoveKeyboard();
        AnimatePlayer();
    }

    void PlayermMoveKeyboard(){
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX,0f,0f) * Time.deltaTime * moveForce;


        //Debug.Log("move X value is: " + movementX);
    }

    void AnimatePlayer(){
        if(movementX > 0){
            //We are going to the riht side
            anim.SetBool(WALK_ANIMATION,true);
        }else if (movementX < 0){
            //We are going to the left side
            anim.SetBool(WALK_ANIMATION,true);
        }else {
            anim.SetBool(WALK_ANIMATION,false);
        }
    }
} // Class
