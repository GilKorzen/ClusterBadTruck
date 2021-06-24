using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Do_not_touch : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name);
    }
}
