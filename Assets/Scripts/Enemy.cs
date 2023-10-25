using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Joueur monJoueur;
    public int monchiffreamoi;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        monJoueur = collision.gameObject.GetComponent<Joueur>();
        if(monJoueur == true)
        {
            monJoueur.AugmenteScore(monchiffreamoi);
            monJoueur.Additionne(monchiffreamoi);
            Destroy(gameObject);
              
        }
    }

}
