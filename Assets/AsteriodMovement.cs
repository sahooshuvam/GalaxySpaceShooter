using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteriodMovement : MonoBehaviour
{
    public float astroidSpeed;
    public ScoreManager score;
    public AudioSource explosionSound;
    public AudioClip audioClip;

    private void Start()
    {
        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();

    }
    // public AudioSource bombSound;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * astroidSpeed * Time.deltaTime);
        transform.Rotate(5.0f,0, 0 , Space.Self);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        explosionSound.Play();
        score.ScoreCalculator(10);
        

    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


}
