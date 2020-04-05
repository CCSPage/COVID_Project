using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    private float speed = 1.6f;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(Random.Range(0f, 300), Random.Range(0f, 300), Random.Range(0f, 300));
    }

    // Update is called once per frame
    void Update()
    {
        //transform.rotation = Random.rotation;
        transform.Rotate(new Vector3(0, 0, Random.Range(0f, 300f)) * Time.deltaTime * speed);
    }
}
