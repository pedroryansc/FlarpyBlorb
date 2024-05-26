using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoMeio : MonoBehaviour
{

    public LogicaScript logica;

    // Start is called before the first frame update
    void Start()
    {
        logica = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicaScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.layer == 3 && collision.gameObject.GetComponent<PassaroScript>().passaroVoando){
            logica.aumentaPontuacao(1);
        }
    }
}
