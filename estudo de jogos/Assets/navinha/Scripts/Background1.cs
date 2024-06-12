using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background1 : MonoBehaviour
{
    [Header("velocidade")]
    public float velocidade;

    [Header("ultimo background")]
    public GameObject bgObjeto;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, velocidade * Time.deltaTime, 0);
        if (transform.position.y <= -12)
        {
            transform.position = new Vector3(0, bgObjeto.transform.position.y + 12, 0);
        }
    }
}
