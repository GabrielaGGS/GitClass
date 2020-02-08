using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed;
    public float speedRot;
    void Update()
    {
        transform.Translate(Vector3.right *
                                    speed *
                                    Input.GetAxis("Vertical") *
                                    Time.deltaTime);
        transform.Rotate(Vector3.forward *
                                speedRot *
                                Input.GetAxis("Horizontal") *
                                Time.deltaTime);
    }
}
