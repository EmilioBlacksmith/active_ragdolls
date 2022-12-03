using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralWalking : MonoBehaviour
{
    [SerializeField] private Transform targetLeg;
    [SerializeField] private Transform feetTarget;
    [SerializeField] private float distanceBetween;
    [SerializeField] private bool moving;
    [SerializeField] private float movingTime = 0;
    
    
    void Update()
    {
        distanceBetween = Vector3.Distance(targetLeg.position, feetTarget.position);
        Debug.DrawLine(feetTarget.position, targetLeg.position, Color.red);

        if(distanceBetween > 1 && !moving){
            moving = true;
        }

        if(moving){
            if (movingTime < .5f)
            {
                feetTarget.position = Vector3.MoveTowards(feetTarget.position, targetLeg.position, 10f * Time.deltaTime);
                movingTime += Time.deltaTime * 1.5f;
            }else{
                moving = false;
                movingTime = 0;
            }
        }
    }
}
