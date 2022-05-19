using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EjBoton4 : MonoBehaviour
{
    public GameObject inputObject;

    public void activarDesactivar()
    {
        if (!inputObject.activeInHierarchy)
        {
            inputObject.SetActive(true);
        }
        else
        {
            inputObject.SetActive(false);
        }
    }
}