using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public Joueur monCreateur;
    public GameObject monCrystal;
    public GameObject monCrystal10;
    public GameObject monCrystal100;
    public GameObject monCrystal1000;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
        //monCreateur = FindObjectOfType<Joueur>();
        myRigidbody = gameObject.GetComponent<Rigidbody2D>();
        myRigidbody.velocity = Vector3.up*speed;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        int monrandom = Random.Range(0, 1001);
        if (monrandom < 890)
        {
            Instantiate(monCrystal, transform.position, transform.rotation);
        }
        if (monrandom >= 890 & monrandom <= 990)
        {
            Instantiate(monCrystal10, transform.position, transform.rotation);
        }
        if (monrandom >= 990 & monrandom <= 999)
        {
            Instantiate(monCrystal100, transform.position, transform.rotation);
        }
        if (monrandom == 1000)
        {
            Instantiate(monCrystal1000, transform.position, transform.rotation);
        }
        Destroy(collision.gameObject);
        Destroy(gameObject);   
    }
    
}
