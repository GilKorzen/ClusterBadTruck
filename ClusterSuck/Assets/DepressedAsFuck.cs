using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepressedAsFuck : MonoBehaviour
{
    int nerd=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collider)
    {
        nerd++;
        Debug.Log(collider.gameObject.name+nerd);

    }
}
