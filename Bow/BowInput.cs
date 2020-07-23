using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowInput : MonoBehaviour
{
    public float LaunchForce;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void CalcForceAtDrag()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                
            }
        }
    }
    
}
