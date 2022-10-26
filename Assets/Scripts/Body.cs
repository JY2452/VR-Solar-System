using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
    public double mass;
    public SolSystem sol;
    private double vx;
    private double vz;
    public float startingXPos;
    public float startingZVel;


    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.position = new Vector3(startingXPos, 0, 0);
        vz = -startingZVel * sol.scale;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void updatePosition(double timescale, double scale) 
    {
        this.gameObject.transform.position = this.gameObject.transform.position + new Vector3((float)(vx * timescale * Time.deltaTime * scale), 0, (float)(vz * timescale * Time.deltaTime * scale));
    }

    public void updateVelocity(double ax, double az, double timescale)
    {
        this.vx += ax;
        this.vz += az;
    }
}
