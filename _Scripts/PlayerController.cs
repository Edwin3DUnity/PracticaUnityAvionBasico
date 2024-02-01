using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.SocialPlatforms;

public class PlayerController : MonoBehaviour
{
     [SerializeField, Range(-200, 200), Tooltip("velocidad de movimiento ")]
    private float speed = 5;

    [SerializeField, Range(-200,200)]private  float turnSpeed;
    
    private float horizontal, vertical;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed );
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontal);
    }
}
