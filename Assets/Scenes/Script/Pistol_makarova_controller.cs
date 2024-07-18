using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol_makarova_controller : MonoBehaviour
{
    private float horizont;
    private float vert;
    private float sensiv = 0.5f;
    
    void Update()
    {
        horizont = Input.GetAxis("Mouse X") * sensiv;

        transform.Rotate(0, horizont, 0);
    }
}
