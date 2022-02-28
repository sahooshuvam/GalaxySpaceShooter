using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Vector3 offset1;
    public Vector3 offset2;
    public Vector3 offset3;
    public AudioClip audioClip;
    public AudioSource bulletSound;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bulletPrefab, transform.position + offset1, Quaternion.identity);
            //bulletSound.clip = audioClip;
            bulletSound.Play();
        }
        //Here is the method for tripple shot.
        //means 3 bullets at a time;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //bullet come from left wing
            Instantiate(bulletPrefab, transform.position + offset2, Quaternion.identity);
            //bullet come from the front
            Instantiate(bulletPrefab, transform.position + offset1, Quaternion.identity);
            //bullet come from the right
            Instantiate(bulletPrefab, transform.position + offset3, Quaternion.identity);
            bulletSound.Play();

        }

        
        
    }
}
