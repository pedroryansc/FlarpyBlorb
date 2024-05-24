using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoSpawner : MonoBehaviour
{

    public GameObject cano;
    public float spawnRate = 2;
    private float tempo = 0;
    public float altura = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnarCano();
    }

    // Update is called once per frame
    void Update()
    {
        if(tempo < spawnRate){
            tempo += Time.deltaTime;
        } else{
            spawnarCano();
            tempo = 0;
        }
    }

    void spawnarCano(){
        float maisBaixo = transform.position.y - altura;
        float maisAlto = transform.position.y + altura;

        Instantiate(cano, new Vector3(transform.position.x, Random.Range(maisBaixo, maisAlto), 0), transform.rotation);
    }
}
