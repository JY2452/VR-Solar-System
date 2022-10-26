using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
    public GlobalSettings Settings;
    public double mass;
    public double vx;
    public double vz;
    public double x;
    public double z;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updatePosition(double timestep) 
    {
        this.x += this.vx * timestep;
        this.z += this.vz * timestep;
    }

    public void updateVelocity(double ax, double az, double timestep)
    {
        this.vx += ax * timestep;
        this.vz += az * timestep;
    }
}
