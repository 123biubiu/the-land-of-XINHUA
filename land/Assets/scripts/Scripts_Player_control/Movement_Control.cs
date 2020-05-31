using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Control : MonoBehaviour
{

    public Animator anim;
    private BoxCollider coll;
    private Rigidbody rb;
    [Header("movement parameters")]
    public float speed = 8f;

    [Header("status")]
    public bool isOnGround;
    public bool isWalking;
    Vector3 Xmovement = new Vector3(1, 0, 0);
    Vector3 Ymovement = new Vector3(0, 1, 0);
    Vector3 Zmovement = new Vector3(0, 0, 1);
    float PreviousZ;
    float PreviousY;
    float PreviousX;

    int direction;
    float orginalZ;
    //public int Power = 10;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKey("space"))
        {
            
            Walk();
            
        }
        if (Input.GetKey("s"))
        {
            StopWalking();
        }
        if (Input.GetKey("e"))
        {
            Rotating();
        }
    }
    void Update()
    {
       
    }
    void Walk() {
        //rb.transform.position += -Zmovement * speed;
        //Vector3 direction = new Vector3(rb.velocity.x, rb.velocity.x, -speed * Time.deltaTime);
        isWalking = true;
        WalkX();
        //rb.AddForce(direction*Zmovement, ForceMode.Force);
        anim.SetBool("Walk", true);
        


    }
    void StopWalking() {
        isOnGround = true;
        rb.velocity = new Vector3(0, 0, 0);
        anim.SetBool("Walk", false);

    }
   
    void WalkX()
    {
        PreviousX = this.gameObject.transform.position.x;
        direction = 1;
        rb.velocity = new Vector3(direction * speed * Time.deltaTime, rb.velocity.y, rb.velocity.z);
    }

    void WalkY()
    {
        PreviousY = this.gameObject.transform.position.y;
        direction = 1;
        rb.velocity = new Vector3(rb.velocity.x, direction * speed * Time.deltaTime, rb.velocity.z);
    }
    void WalkZ()
    {
        PreviousZ = this.gameObject.transform.position.z;
        direction = 1;
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, direction * speed * Time.deltaTime);
    }
    void Rotating() {
        StopWalking();
        //Vector3 dir = new Vector3(this.transform.rotation.x, 90, this.transform.rotation.z);
        //Quaternion quaDir = Quaternion.LookRotation(dir, Vector3.up);
        //transform.rotation = Quaternion.Lerp(transform.rotation, quaDir, Time.fixedDeltaTime * speed);
        transform.Rotate(0, 90, 0);
    }

}
