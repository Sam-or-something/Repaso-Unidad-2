using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPlatform : MonoBehaviour
{
    public float vel, limitPos, limitNeg;
    public bool RoL;

    void Update()
    {
        if (RoL && transform.position.x < limitPos)
        {
            transform.position += new Vector3(vel, 0, 0);
        }
        else
        {
            RoL = false;
        }

        if (!RoL && transform.position.x > limitNeg)
        {
            transform.position -= new Vector3(vel, 0, 0);
        }  
        else
        {
            RoL = true;
        }
    }
}
