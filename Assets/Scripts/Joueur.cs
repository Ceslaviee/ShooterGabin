using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Joueur : MonoBehaviour
{
    public GameObject prefabBullet;
    public int Score;
    public int Valeur;
    public Joueur monJoueur;
    public TextMeshProUGUI monUI;
    public TextMeshProUGUI nombreUI1;
    public TextMeshProUGUI nombreUI2;
    public TextMeshProUGUI nombreUI3;
    public TextMeshProUGUI nombreUI4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject jeViensDeNaitre = Instantiate(prefabBullet, transform.position, transform.rotation);
            jeViensDeNaitre.GetComponent<Bullet1>().monCreateur = this;
        }
    }

    public void AugmenteScore(int monchiffreamoi)
    {
        Score+=monchiffreamoi;
        monUI.text = Score.ToString();
    }
    public void Additionne(int monchiffreamoi)
    {
        Valeur += 1;
        if (monchiffreamoi == 1)
        {
            nombreUI1.text = Score.ToString();
        }
        if (monchiffreamoi == 50)
        {
            //nombreUI2.text =+ 1
        }
        if (monchiffreamoi == 350)
        {
            //nombreUI3.text =+ 1
        }
        if (monchiffreamoi == 10000)
        {
            //nombreUI4.text =+ 1
        }
    }
}
