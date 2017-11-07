using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakOnCollision : MonoBehaviour
{

    void OnCollisionEnter()
    {
        Debug.Log("Collision!");
        Invoke("PlatformDrop", 0.5f);
    }

    void PlatformDrop()
    {
        GetComponent<Rigidbody>().isKinematic = false;
    }

}
