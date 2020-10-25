using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bullet;

    private Rigidbody2D rigid;

    public Transform shottingOffset;

    //AudioSource
    private AudioSource audioSource;
    public AudioClip Shootey;

    public float hp = 10;
    private float moveSpeed = 8;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rigid = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = new Vector2(10, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Shooting Sound
            audioSource.PlayOneShot(Shootey);

            //Change to shooting animation
            gameObject.GetComponent<Animator>().SetTrigger("Shoot");

            GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);

            Destroy(shot, 3f);
        }


        //Player Left and Right Movement
        transform.Translate(new Vector2(Input.GetAxis("Horizontal"), 0) * Time.deltaTime * moveSpeed); //Similar to how the paddles moved in pong

    }
}
