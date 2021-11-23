using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour{

    public Rigidbody2D rb;
    public float MoveSpeed =10f;

    public SpriteRenderer sr;

    private Animator anim;
    private string WALK_ANIMATION = "Walk";
    public static int coincollect = 0 ;
    // we want this code to be used in other code also hence we used a keyword satic

     void Start() {
        
    } 

    void Update() {

       // Debug.Log(coincollect);

        Vector3 moveposition = new Vector3(Input.GetAxisRaw("Horizontal"),0f,0f);
        transform.position += moveposition * MoveSpeed * Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.D)){
            anim.SetBool(WALK_ANIMATION,true);
            sr.flipX = false ;

        }
        else if(Input.GetKeyDown(KeyCode.A)){
            anim.SetBool(WALK_ANIMATION,true);
            sr.flipX = true ;
        }
        else if(Input.GetKeyDown(KeyCode.W)){
            rb.AddForce(new Vector2(0.5f,5.5f), ForceMode2D.Impulse);
        }

        // Vector3 movepositiony = new Vector3(0f,Input.GetAxisRaw("Vertical"),0f);
        // transform.position += movepositiony * MoveSpeed * Time.deltaTime;


    }

    

}// class

// My Choise
/* 
public float xSpeed = 0.1f;
    public float ySpeed = 0.01f;
    



    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)){
        transform.position+=new Vector3(xSpeed, 0, 0);
        // Move the object in X direction by 0.05 unit
        } 

       if(Input.GetKey(KeyCode.A)){
        transform.position+=new Vector3(-xSpeed, 0, 0);
        } 

        if(Input.GetKey(KeyCode.W)){
        transform.position+=new Vector3(0, ySpeed, 0);
        } 

        if(Input.GetKey(KeyCode.S)){
        transform.position+=new Vector3(0, -ySpeed, 0);
        } 

        
    }
} // class

*/
    
    

    // NEW CODE 
/*
    [SerializeField]
    private float moveForce = 10f;
    [SerializeField]
    private float jumpForce = 11f;

    private float movementX;
    public Rigidbody2D myBody;
    private SpriteRenderer sr;
    private Animator anim;
    private string WALK_ANIMATION = "Walk";

     private void Awake() {

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
        PlayerMoveKeyboard();
        AnimatePlayer();
        
    }

    private void FixedUpdate() {
        PlayerJump();   
    }

    void PlayerMoveKeyboard(){

        movementX = Input.GetAxisRaw("Horizontal");

        transform.position+=new Vector3(movementX,0f,0f)*moveForce*Time.deltaTime;  

    }

    void AnimatePlayer(){

        
         // we are going to right side 
        if(movementX > 0){
            anim.SetBool(WALK_ANIMATION,true);
            sr.flipX = false;

        }
        else if(movementX < 0){
            // we are going to left side
            anim.SetBool(WALK_ANIMATION,true);
            sr.flipX = true;
        }
        else{
            anim.SetBool(WALK_ANIMATION,false);

        }

    }

    void PlayerJump()
    {
        if(Input.GetButtonDown("Jump")){

            myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);

        }
    }

    */



