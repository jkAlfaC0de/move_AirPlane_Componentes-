using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_tiro : MonoBehaviour

{
    public float velocidade = 0.10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(velocidade * Time.deltaTime, 0));
    }
    private void OnTriggerEnter2D(Collider2D body)
    {
        if (body.gameObject.CompareTag("moeda"))
        {
            Destroy(body.gameObject);

        }
    }
}
