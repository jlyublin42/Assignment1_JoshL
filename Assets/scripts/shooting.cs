using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject characterProj;

    // Update is called once per frame
    void Update()
    {
       if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot() //shooting logic
    {
        Instantiate(characterProj, firePoint.position, firePoint.rotation);
    }
}
