using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barricade : MonoBehaviour
{

    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("AYAYAYAY!");
        if (collision.gameObject.name == "Bullet(Clone)")
        {
            //Debug.Log("Hit Barricade");
            Destroy(collision.gameObject);

            //Shrinks when hit bullet
            Vector3 shrinker = new Vector3(-0.1f, -0.1f, -0.1f);
            gameObject.transform.localScale += shrinker;
        }
    }
}
