using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShipCode : MonoBehaviour
{
    public TMP_Text tMP_Text;
    public float speed;
    float movementdirect;
    float movementup;
    Rigidbody2D rb2D;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        
    }
    void Update()
    {
        movementdirect = Input.GetAxis("Horizontal");
        movementup = Input.GetAxis("Vertical");
        

    }
    private void FixedUpdate()
    {
        rb2D.velocity = new Vector2(speed * movementdirect, speed * movementup);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("sorn");
    }
}
