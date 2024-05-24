using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoMovimento : MonoBehaviour
{

    public float moveSpeed = 6;
    public float deadZone = -40;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if(transform.position.x < deadZone){
            Debug.Log("Cano deletado");
            Destroy(gameObject);
        }
    }
}
