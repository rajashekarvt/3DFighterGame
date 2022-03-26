using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterAnimation player_Anim;
    private Rigidbody myBody;
    public float walkSpeed = 3f;
    public float zSpeed = 1.5f;
    private float rotationY = -90f;
    public float rotationSpeed = 15f;


    void Awake()
    {
        myBody = GetComponent<Rigidbody>();
        player_Anim = GetComponentInChildren<CharacterAnimation>();

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        AnimatePlayerWalk();
    }
    void FixedUpdate()
    {
        DetectMovement();
    }

    void DetectMovement()
    {
        myBody.velocity = new Vector3(Input.GetAxisRaw(Axis.HORIZONTAL_AXIS)*(-walkSpeed),myBody.velocity.y,Input.GetAxisRaw(Axis.VERTICAL_AXIS)*(-zSpeed));
    }

    void RotatePlayer()
    {
        if (Input.GetAxisRaw(Axis.HORIZONTAL_AXIS) > 0)
        {
            transform.rotation = Quaternion.Euler(0f, -Mathf.Abs(rotationY), 0f);

        }
        if (Input.GetAxisRaw(Axis.HORIZONTAL_AXIS) < 0)
        {
            transform.rotation = Quaternion.Euler(0f, Mathf.Abs(rotationY), 0f);
        }
    }

    void AnimatePlayerWalk()
    {
        if(Input.GetAxisRaw(Axis.HORIZONTAL_AXIS)!=0 ||  (Input.GetAxisRaw(Axis.VERTICAL_AXIS) != 0))
            {
            player_Anim.Walk(true);
        }
        else
        {
            player_Anim.Walk(false);
        }
    }
}
