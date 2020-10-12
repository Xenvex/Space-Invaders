using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public GameObject bullet;

  private Rigidbody2D rigid;

  public Transform shottingOffset;

    public float hp = 10;
    private float moveSpeed = 8;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = new Vector2(10, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
            //Debug.Log("Bang!");

            Destroy(shot, 3f);

            //GameObject findScore = GameObject.Find("Canvas");
            //ScoreManager scoreScript = findScore.GetComponent<ScoreManager>();
            //scoreScript.score += 1;

        }


        //Player Left and Right Movement
        transform.Translate(new Vector2(Input.GetAxis("Horizontal"), 0) * Time.deltaTime * moveSpeed); //Similar to how the paddles moved in pong

    }
}
