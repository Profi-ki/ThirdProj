using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol_makarova_controller : MonoBehaviour
{
    private float horizont;
    private float vert;
    private float sensiv = 2f;
    private float sensiv2 = 0.5f;
    
    void Update()
    {
        horizont = Input.GetAxis("Mouse X") * sensiv;

        transform.Rotate(0, horizont, 0);
        vert = Input.GetAxis("Mouse Y") * sensiv2;

        transform.Rotate(vert, 0, 0);
    }
}
