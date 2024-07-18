using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol_makarova_controller : MonoBehaviour
{
    private float horizont;
    private float vert;
    private float sensiv = 1f;
    
    void Update()
    {
        horizont = Input.GetAxis("Mouse X") * sensiv;
        vert = Input.GetAxis("Mouse Y") * sensiv;

        transform.Rotate(0, horizont, 0);

        transform.Rotate(vert, 0, 0);
    }
}
