using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteriodMovement : MonoBehaviour
{
    public float astroidSpeed;
    public ScoreManager score;

    private void Start()
    {
        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();

    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * astroidSpeed * Time.deltaTime);
        transform.Rotate(5.0f,0, 0 , Space.Self);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        score.ScoreCalculator(10);       
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


}
