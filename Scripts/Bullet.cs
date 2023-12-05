using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 2f;
    public Vector2 direction;

    public float livingTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, livingTime);
    }

    // Update is called once per frame
    void Update()
    {
         Vector2 movement = direction.normalized * speed * Time.deltaTime;
         transform.Translate(movement);
        // if (Input.GetMouseButtonDown(0)) {
        //     Debug.Log("button pressed");
        // }
        // if (Input.GetMouseButtonDown(0)) {
        //     Debug.Log("button is pressed");
        // }
        // if (Input.GetMouseButtonDown(0)) {
        //     Debug.Log("button released");
        // }
        
        // float horizontal = Input.GetAxis("Horizontal");
        // float vertical = Input.GetAxis("Vertical");

        // if(horizontal < 0f || horizontal > 0f) {
        //     Debug.Log("horizontal axis is " + horizontal);
        // }

        // if(vertical < 0f || vertical > 0f) {
        //     Debug.Log("vertical axis is " + vertical);
        // }
    }
}