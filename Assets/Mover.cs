using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] private float speed = 2f;
    void Start()
    {
        MovePlayer();
    }

    // Update is called once per frame
    void Update()
    {

        float xVal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float zVal = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(xVal, 0f, zVal);
    }

    void MovePlayer()
    {
        float xVal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float zVal = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(xVal, 0f, zVal);
    }

}
        


