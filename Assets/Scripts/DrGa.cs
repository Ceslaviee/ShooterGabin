using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrGa : MonoBehaviour
{

    public Transform begining;
    public Transform end;

    public float speed;
    public int direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * direction;

        if(begining.position.x<=-8.5)
        {
            direction = 1;
        }
        if (end.position.x >= 8.5)
        {
            direction = -1;
        }
    }
}

//-5.77
