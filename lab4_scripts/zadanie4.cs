using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie4 : MonoBehaviour
{
    public Transform player;

    public float sensitivity = 200f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseYMove = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        float YClamp = Mathf.Clamp(mouseYMove, mouseYMove - 90f, mouseYMove + 90f);
        player.Rotate(Vector3.up * mouseXMove);

        transform.Rotate(new Vector3(-YClamp, 0f, 0f), Space.Self);

    }
}
