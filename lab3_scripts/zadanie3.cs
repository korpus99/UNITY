using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie3 : MonoBehaviour
{
    public float speed = 30.0f;
    private Vector3 target;
    private Vector3 x;
    // Start is called before the first frame update
    void Start()
    {
        target = new Vector3(10.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, step);

        if (transform.position == new Vector3(10.0f, 0.0f, 0.0f))
        {
            transform.Rotate(Vector3.up, 90.0f);
            target = new Vector3(10.0f, 0.0f, 10.0f);
        }
        if (transform.position == new Vector3(10.0f, 0.0f, 10.0f))
        {
            transform.Rotate(Vector3.up, 90.0f);
            target = new Vector3(0.0f, 0.0f, 10.0f);
        }
        if (transform.position == new Vector3(0.0f, 0.0f, 10.0f))
        {
            transform.Rotate(Vector3.up, 90.0f);
            target = new Vector3(0.0f, 0.0f, 0.0f);
        }
        if (transform.position == new Vector3(0.0f, 0.0f, 0.0f))
        {
            transform.Rotate(Vector3.up, 90.0f);
            target = new Vector3(10.0f, 0.0f, 0.0f);
        }
    }
}
