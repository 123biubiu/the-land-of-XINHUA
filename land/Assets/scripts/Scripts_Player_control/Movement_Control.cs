using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Movement_Control : MonoBehaviour
{



    [SerializeField] private float movementSpeed = 2f;
    private float currentSpeed = 0f;
    private float walkSpeed = 1f;
    private float speedSmoothVelocity = 0f;
    private float speedSmoothTime = 0.1f;
    private float rotationSpeed = 0.1f;
    private float gravity = 3f;
    private int Rollnumber;
    private pannelManager pannelManager;
    //相机跟随。可加可不加，先占坑
    //private Transform mainCameraTransform = null;

    private CharacterController controller = null;
    public Animator anim = null;
    Vector3 desiredMoveDirection;
    Vector3 gravityVector;
    Vector3 right;
    Vector3 forward;

    private CapsuleCollider coll;

    //是否触屏到拐弯点
    public bool IsTouchConnerPoint=true;
    //是否顺时针
    public bool isSunshizhen = true;
    //用于顺逆时针判断点参数
    public int Judge = 2;
    //累计走过的步数。用于骰子数检测
    public int accumulatedLayernumber;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        coll = GetComponent<CapsuleCollider>();
        pannelManager = GetComponent<pannelManager>();
    }
    private void Update()
    {
        gravityVector = Vector3.zero;
        SunshizhenJudge();


        if (!controller.isGrounded)
        {
            gravityVector.y -= gravity;
        }
        
        if (IsTouchConnerPoint == false)
        {
            Walk();

        }


        if (Input.GetKeyDown("space"))
        {
            //Roll();
            //Move();
            IsTouchConnerPoint = false;



        }
        if (Input.GetKey("s"))
        {
            Stop();
        }
        if (Input.GetKey("w"))
        {
            Walk();
        }
        if (Input.GetKey("e"))
        {
            Rotate();
        }
        if (Input.GetKey("t"))
        {
            turnbackDirection();
        }

    }
    private void turnbackDirection() {
        Stop();
        Rotate();
        Rotate();
        Judge += 1;
    }

    private void SunshizhenJudge()
    {
        if (Judge % 2 == 0)
        {
            isSunshizhen = true;
        }
        else
        {
            isSunshizhen = false;
        }
    }
    //摇骰子
    private void Roll()
    {
        Rollnumber = pannelManager.currentNumber;
        for (int i = 1; i < Rollnumber; i++)
            Move();
    }
    //移动总控制,
    private void Move() {

        //controller.Move(gravityVector * Time.deltaTime);

        //Walk();
        
    }
    //前进
    public void Walk() {
        anim.SetBool("Walk", true);
        //Vector2 movementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
         forward = transform.forward;
         right = transform.right;
        forward.Normalize();
        right.Normalize();
        //desiredMoveDirection = (forward*movementInput.y+right*movementInput.x).normalized;
        desiredMoveDirection = (forward  + right).normalized;

        controller.Move(transform.forward * walkSpeed * Time.deltaTime);


        //if (desiredMoveDirection != Vector3.zero)
        //{
        //    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(desiredMoveDirection), rotationSpeed);
        //}
        //float targetSpeed = movementSpeed * movementInput.magnitude;

        //currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed,ref speedSmoothVelocity,speedSmoothTime);
    }

    //停下来
    private void Stop()
    {
        //rb.velocity = new Vector3(0, 0, 0);
        anim.SetBool("Walk", false);
        IsTouchConnerPoint = true;
        //controller.Move(Vector3.zero);
        //controller.Move(-transform.forward * walkSpeed * Time.deltaTime);

    }
    //转身
    private void Rotate()
    {
        Stop();
        
        transform.Rotate(0, 90, 0);

    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (isSunshizhen == true)
        {
            if (other.gameObject.tag == "ConnerPoint1")
            {

                Stop();
                Rotate();
                Rotate();
                Rotate();


            }
            if (other.gameObject.tag == "ConnerPoint2")
            {
                Stop();
                Rotate();


            }
            if (other.gameObject.tag == "ConnerPoint3")
            {
                Stop();
                Rotate();
                Rotate();
                Rotate();


            }
            if (other.gameObject.tag == "ConnerPoint4")
            {
                Stop();
                Rotate();
                Rotate();
                Rotate();


            }
            if (other.gameObject.tag == "ConnerPoint5")
            {
                Stop();
                Rotate();
                Rotate();
                Rotate();


            }
            if (other.gameObject.tag == "ConnerPoint6")
            {
                Stop();
                Rotate();
                Rotate();
                Rotate();


            }
        }
        if (isSunshizhen == false)
        {
            if (other.gameObject.tag == "ConnerPoint1")
            {

                Stop();
                Rotate();
             

            }
            if (other.gameObject.tag == "ConnerPoint2")
            {
                Stop();
                Rotate();
                Rotate();
                Rotate();

            }
            if (other.gameObject.tag == "ConnerPoint3")
            {
                Stop();
                Rotate();
           


            }
            if (other.gameObject.tag == "ConnerPoint4")
            {
                Stop();
                Rotate();
             


            }
            if (other.gameObject.tag == "ConnerPoint5")
            {
                Stop();
                Rotate();
              


            }
            if (other.gameObject.tag == "ConnerPoint6")
            {
                Stop();
                Rotate();
             


            }
        }
        IsTouchConnerPoint = false;

    }


}
