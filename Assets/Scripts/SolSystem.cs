using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolSystem : MonoBehaviour
{
    public Body[] bodies;
    public int scale;
    private double G = 6.67384e-11;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private (double distX, double distZ) calcDistance(Body body1, Body body2)
    {
        return (body2.x - body1.x, body2.z - body1.z);
    }

    private (double ax, double az) calcAcceleration(Body body, double dx, double dz) 
    {
        double totalDistance = Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dz, 2));
        double ax, az;

        if (dx != 0) {
            ax = ((G * body.mass * dx) / (Math.Pow(totalDistance, 3)));
        } else { ax = 0; }
        if (dz != 0) {
            az = ((G * body.mass * dz) / (Math.Pow(totalDistance, 3)));
        } else { az = 0;}

        return (ax, az);
    }
}
