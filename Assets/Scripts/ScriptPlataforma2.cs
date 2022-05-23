using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPlataforma2 : MonoBehaviour
{
    public float vel, limitRight, limitLeft;
    public bool RoL;
    public GameObject prefab1, prefab2;

    void Update()
    {
        if (RoL)
        {
            transform.position += new Vector3(vel, 0, 0);
        }
        else
        {
            transform.position += new Vector3(vel, 0, 0);
        }

        if(transform.position.x > limitRight)
        {
            RoL = false;
            Instantiate(prefab1);
        }
        else if (transform.position.x < limitLeft)
        {
            RoL = true;
            Instantiate(prefab2);
        }
    }
}
