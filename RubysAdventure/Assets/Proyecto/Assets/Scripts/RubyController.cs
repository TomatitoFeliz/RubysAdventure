using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    [SerializeField]
    float velocidad;
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = position.x + velocidad * horizontal * Time.deltaTime;
        position.y = position.y + velocidad * vertical * Time.deltaTime;
        transform.position = position;
    }
}
