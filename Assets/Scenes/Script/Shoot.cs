using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform placeforbullet;
    public Quaternion bulletRotate;
    void Update()
    {
        bulletRotate = Quaternion.Euler(transform.rotation.eulerAngles.x - 90, transform.rotation.eulerAngles.y, -2f);
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, placeforbullet.position, bulletRotate);
        } 
    }
}
