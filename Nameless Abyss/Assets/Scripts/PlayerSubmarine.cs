using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSubmarine : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private int lives = 10;

    private SpriteRenderer _sprite;
    private Rigidbody2D _rb;
    
    
    public static PlayerSubmarine Instance { get; set; }

    private void Awake()
    {
        Instance = this;
        _rb = GetComponent<Rigidbody2D>();
        _sprite = GetComponentInChildren<SpriteRenderer>();
    }


    private void Update()
    {
        if (Input.GetButton("Horizontal"))
            MoveHorizontal();
        if (Input.GetButton("Vertical"))
            MoveVertical();
    }
    
    
    private void MoveHorizontal()
    {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
        _sprite.flipX = dir.x > 0.0f;
        
    }
    
    private void MoveVertical()
    {
        Vector3 dir = transform.up * Input.GetAxis("Vertical");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);

    }

}
