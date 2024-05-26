using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassaroScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicaScript logica;
    public bool passaroVoando = true;

    // Start is called before the first frame update
    void Start()
    {
        // gameObject.name = "Red";
        logica = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicaScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && passaroVoando){
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

        if(transform.position.y > 18 || transform.position.y < -18){
            logica.gameOver();
            passaroVoando = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        logica.gameOver();
        passaroVoando = false;
    }
}