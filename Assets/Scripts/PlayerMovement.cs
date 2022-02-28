using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
     
    // Update is called once per frame
    void Update()
    {

        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        transform.Translate(Vector3.up * speed * inputY * Time.deltaTime);
        transform.Translate(Vector3.right * speed * inputX * Time.deltaTime);

        if (transform.position.y > 4.5f)
        {
            transform.position = new Vector3(transform.position.x, 4.5f, 0);
        }

        else if (transform.position.y < -4.5f)
        {
            transform.position = new Vector3(transform.position.x, -4.5f, 0);
        }

        if (transform.position.x > 7f)
        {
            transform.position = new Vector3(7f, transform.position.y, 0);

        }
        else if (transform.position.x < -7f)
        {
            transform.position = new Vector3(-7f, transform.position.y, 0);
        }

    }

 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        Destroy(gameObject);
        Debug.Log("Game Over");
        SceneManager.LoadScene(0);
          
    }
}