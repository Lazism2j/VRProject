using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuterMap : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Block")
        { 
            Destroy(collision.gameObject);
        }
    }
}
