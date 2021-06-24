using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject mrUI;
    int k=0;
    public bool onAir=false;
    Transform newtonsFirstLaw;
    public Transform groundCheck;
    public float groundDistance = 2f;
    public LayerMask groundMask;
    public LayerMask vehicleMask;
    public float speed=12f;
    public float jumpHeight=1.5f;
    public CharacterController controller;
    Vector3 velocity;
    public float gravity=-9.81f;
    bool isGrounded;
    bool isVehicled;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded=Physics.CheckSphere(groundCheck.position,groundDistance,groundMask);
        isVehicled=Physics.CheckSphere(groundCheck.position,groundDistance,vehicleMask);
        float x= Input.GetAxis("Horizontal");
        float z= Input.GetAxis("Vertical");
        if (isVehicled && velocity.y < 0)
        {
            velocity.y=-2f;
          //  Debug.Log("nooooo");
    }

        Vector3 move= transform.right * x + transform.forward * z;

        if (isVehicled && Input.GetButtonDown("Jump"))
        {
            velocity.y = Mathf.Sqrt(jumpHeight*-2f*gravity);
        }
        if (onAir)
        {
            transform.position+=newtonsFirstLaw.forward*Time.deltaTime*8f;
            Debug.Log(newtonsFirstLaw.forward*Time.deltaTime*8f);
        }

        controller.Move(move*speed*Time.deltaTime);
        velocity.y += gravity* Time.deltaTime;
        controller.Move(velocity*Time.deltaTime*speed);

        if (isGrounded && !mrUI.activeSelf)
        {
            FindObjectOfType<GameManager>().EndGame();
            Debug.Log("heloo");
        }


}
void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.tag=="Car")
    {
        onAir=false;
    }
 //   Debug.Log("fuck");
  //  Debug.Log(collision.gameObject.name);
}
void OnCollisionExit(Collision collision)
{
    if (collision.gameObject.tag=="Car")
    {
        onAir=true;
        newtonsFirstLaw=collision.gameObject.transform;
     //   Debug.Log("lalalala");
    }
    
 //   Debug.Log("fake"+k);
    k++;
}


}

