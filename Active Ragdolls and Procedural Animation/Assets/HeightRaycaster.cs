using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightRaycaster : MonoBehaviour
{
    [SerializeField] private LayerMask groundMask;

    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, Vector3.down, out hit, 10f, groundMask)) {
             
            //Debug.Log("Hit the Ground");
            Vector3 targetLocation = hit.point;
             
            targetLocation += new Vector3(0, transform.localScale.y/2, 0);
            transform.position = targetLocation;
         }
    }
}
