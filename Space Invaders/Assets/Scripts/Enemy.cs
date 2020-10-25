using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject bullet;
    public Transform shottingOffset;
    public float speed = 1;
    private int timer = 0;

    private Rigidbody2D rigidEnemy;

    void Start()
    {
        rigidEnemy = GetComponent<Rigidbody2D>();
        //rigidEnemy.AddForce(new Vector3(0.0f, -0.5f, 0.0f));
        rigidEnemy.velocity = new Vector3(0f, -0.1f * speed, 0f);
    
        
    }

    void Update()
    {
        //Debug.Log(speed); //Checking for Speed Increases

        //rigidEnemy.velocity.normalized * speed;

        if (timer < 960)
        {
            timer++;
        }
        else
        {
            timer = 0;
        }

        if(timer == 320)
        {
            //Slight Left
            rigidEnemy.velocity = new Vector3(-0.15f * speed, -0.1f * speed, 0f);

            //Change to shooting animation
            gameObject.GetComponent<Animator>().SetTrigger("Shoot");

            //Fire Bullet
            GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
            Destroy(shot, 3f);
        }
        
        if(timer == 640)
        {
            //Slight Right
            rigidEnemy.velocity = new Vector3(0.15f * speed, -0.1f * speed, 0f);

            //Change to shooting animation
            gameObject.GetComponent<Animator>().SetTrigger("Shoot");

            //FireBullet
            GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
            Destroy(shot, 3f);
        }

        
           

        

    }

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Ouch!");
        
    }
}
