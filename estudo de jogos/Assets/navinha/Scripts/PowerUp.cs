using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    Rigidbody2D powerbody;
    BoxCollider2D powerCollider;

    float velocidade;

    public int tipo;

    // Start is called before the first frame update
    void Start()
    {
        powerbody = GetComponent<Rigidbody2D>();
        powerCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        powerbody.velocity = new Vector2(-velocidade, 0);
    }

    public void Coletado()
    {
       
    }
}
