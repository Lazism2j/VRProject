using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroyer : MonoBehaviour
{
    [SerializeField] int _radius;
    [SerializeField] LayerMask Block;

    /*
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Block")
        {
            Destroy(other.gameObject);
        }
    }
    */

    private void Awake()
    {
        transform.localScale = Vector3.one * _radius;
    }

    public void BlockDestroy()
    {
        Collider[] inBlocks = Physics.OverlapSphere(transform.position, _radius, Block);
        for (int i = 0; i < inBlocks.Length; i++)
        {
            Destroy(inBlocks[i].gameObject);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        Gizmos.DrawWireSphere(transform.position, _radius);
    }
}
