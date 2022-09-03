using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    //public float horizontalInput = 10.0f;
    //public float speed = 30.0f;
    
    public GameObject dogPrefab;

    private float counter = 0;
    private float dogDelay = 0.3f;

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;

        //horizontalInput = Input.GetAxis("Horizontal");
        //transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (counter > dogDelay))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            counter = 0;
        }
    }
}
