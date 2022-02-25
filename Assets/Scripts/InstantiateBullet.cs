using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Vector3 offset;
    [SerializeField]
    private float time;
   

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time>0.2f)
        {
            Instantiate(bulletPrefab, transform.position + offset, Quaternion.identity);
            time = 0f;
        }
        
    }
}
