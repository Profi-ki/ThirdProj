using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_move : MonoBehaviour
{
    private int speed = 5;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}
