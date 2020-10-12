using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] //technique for making sure there isn't a null reference during runtime if you are going to use get component
public class Bullet : MonoBehaviour
{
  private Rigidbody2D myRigidbody2D;

  public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
      myRigidbody2D = GetComponent<Rigidbody2D>();
      Fire();
    }

    // Update is called once per frame
    private void Fire()
    {
      myRigidbody2D.velocity = Vector2.up * speed; 
      //Debug.Log("Wwweeeeee");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            if (collision.gameObject.name == "Enemy")
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);

                //Increment Enemy Speed
                for(int i = 0; i < GameObject.FindGameObjectsWithTag("Enemy").Length; i++)
                {
                    GameObject findEnemy = GameObject.FindGameObjectsWithTag("Enemy")[i];
                    Enemy enemyScript = findEnemy.GetComponent<Enemy>();
                    enemyScript.speed += 1;
                }

                //Increment Score Accordingly
                GameObject findScore = GameObject.Find("Canvas");
                ScoreManager scoreScript = findScore.GetComponent<ScoreManager>();
                scoreScript.score += 1;
            }
            if (collision.gameObject.name == "Enemy_Tier2")
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);

                //Increment Enemy Speed
                for (int i = 0; i < GameObject.FindGameObjectsWithTag("Enemy").Length; i++)
                {
                    GameObject findEnemy = GameObject.FindGameObjectsWithTag("Enemy")[i];
                    Enemy enemyScript = findEnemy.GetComponent<Enemy>();
                    enemyScript.speed += 1;
                }

                //Increment Score Accordingly
                GameObject findScore = GameObject.Find("Canvas");
                ScoreManager scoreScript = findScore.GetComponent<ScoreManager>();
                scoreScript.score += 2;
            }
            if (collision.gameObject.name == "Enemy_Tier3")
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);

                //Increment Enemy Speed
                for (int i = 0; i < GameObject.FindGameObjectsWithTag("Enemy").Length; i++)
                {
                    GameObject findEnemy = GameObject.FindGameObjectsWithTag("Enemy")[i];
                    Enemy enemyScript = findEnemy.GetComponent<Enemy>();
                    enemyScript.speed += 1;
                }

                //Increment Score Accordingly
                GameObject findScore = GameObject.Find("Canvas");
                ScoreManager scoreScript = findScore.GetComponent<ScoreManager>();
                scoreScript.score += 3;
            }
            if (collision.gameObject.name == "Enemy_Tier4")
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);

                //Increment Enemy Speed
                GameObject findEnemy = GameObject.FindGameObjectsWithTag("Enemy")[0];
                Enemy enemyScript = findEnemy.GetComponent<Enemy>();
                enemyScript.speed += 1;

                //Increment Score Accordingly
                GameObject findScore = GameObject.Find("Canvas");
                ScoreManager scoreScript = findScore.GetComponent<ScoreManager>();
                scoreScript.score += 4;
            }

            

        }
         
        
    }
}
