using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))] //technique for making sure there isn't a null reference during runtime if you are going to use get component
public class BulletEnemy : MonoBehaviour
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
        if (collision.gameObject.name == "Player")
        {

            Destroy(collision.gameObject);
            //StartCoroutine(LoadCredits()); //Using it cause LoadCredits is an IEnumerator
            SceneManager.LoadScene("CreditsScene");


        }


    }

    IEnumerator LoadCredits()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("CreditsScene");
    }
}
