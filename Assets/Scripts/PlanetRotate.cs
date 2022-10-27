using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotate : MonoBehaviour
{
    public SolSystem sol;
    public float secondsPerDay;
    private float rotationSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = (7.2f * (float)sol.timescale / secondsPerDay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, rotationSpeed, 0) * Time.deltaTime);
    }
}
