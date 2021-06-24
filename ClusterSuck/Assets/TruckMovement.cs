using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class TruckMovement : MonoBehaviour
{
    bool playerIsOnMe=false;
    bool artificialGravity=false;
    public float gravity=-9.81f;
    Vector3 velocity;

    GameObject stupid;
    Rigidbody rb;
    public GameObject player;
    public GameObject go;

    public float speed=8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {

        transform.position+=(transform.forward*speed*Time.deltaTime);
      //  Debug.Log(transform.forward*speed*Time.deltaTime);
        if (playerIsOnMe)
        {
            player.transform.position+= transform.forward*Time.deltaTime * speed;
                //    Debug.Log(transform.forward*speed*Time.deltaTime*0.5f+"amogus");
        }
        rb=GetComponent<Rigidbody>();
        if (artificialGravity)
        {
            Debug.Log("hollaaaa");
         //   rb.velocity=new Vector3(rb.velocity.x,rb.velocity.y+gravity*Time.deltaTime,rb.velocity.z);
        }
        else
        {
        //    rb.velocity=new Vector3(rb.velocity.x,0,rb.velocity.z);
        }
    }
    void OnCollisonEnter()
    {
    }
    private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject == player)
        {
            playerIsOnMe=true;
      //      stupid = other.gameObject;
     //       Transform cubeTransform = stupid.GetComponent<Transform>(); 
		//	rb = stupid.GetComponent<Rigidbody>();
         //   rb.velocity =new Vector3((float)Math.Sin(cubeTransform.eulerAngles.y)*speed*Time.deltaTime+rb.velocity.x,rb.velocity.y, (float)Math.Cos(cubeTransform.eulerAngles.y)*speed*Time.deltaTime+rb.velocity.z);
        }
    if (other.gameObject.name == "Plane")
    {
        artificialGravity=false;
    }
        if (other.gameObject.tag == "Obstacle")
    {
        speed=0;
    }
	}
    private void OnTriggerExit(Collider other)
    {
    if (other.gameObject == player)
        {
            playerIsOnMe=false;
        }
    if (other.gameObject.name == "Plane")
    {
        artificialGravity=true;
    }

    }
	//private void OnTriggerStay(Collider other)
   // {
//		if (other.gameObject == player)
   //     {
   //         Transform cubeTransform = stupid.GetComponent<Transform>(); 
//			rb = stupid.GetComponent<Rigidbody>();
    //        rb.velocity =new Vector3((float)Math.Sin(cubeTransform.eulerAngles.y)*speed*Time.deltaTime+rb.velocity.x,rb.velocity.y, (float)Math.Cos(cubeTransform.eulerAngles.y)*speed*Time.deltaTime+rb.velocity.z);
    //        Debug.Log(rb.velocity+"");
    //    }
//	}
}
