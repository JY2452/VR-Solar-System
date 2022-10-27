using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolSystem : MonoBehaviour
{
    public Body[] bodies;
    public double scale;
    private double G;
    public double timescale;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Initializing Sol System");
        G = 6.67384e-11;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < bodies.Length; i++) {
            (double a_x, double a_z) = (0,0);
            for (int j = 0; j < bodies.Length; j++) {
                (double ax, double az) = calcAcceleration(bodies[i], bodies[j]);
                a_x += ax;
                a_z += az;
            }

            Debug.Log("Acceleration of " + bodies[i].gameObject + " is (" + a_x + "," + a_z + ")");
            bodies[i].updateVelocity(a_x, a_z, timescale);
            bodies[i].updatePosition(timescale, scale);
        }
    }

    private (double ax, double az) calcAcceleration(Body body0, Body body) 
    {
        double dx = (body.gameObject.transform.position.x - body0.gameObject.transform.position.x);
        double dz = (body.gameObject.transform.position.z - body0.gameObject.transform.position.z);
        double totalDistance = Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dz, 2));
        double ax, az;

        if (dx != 0) {
            ax = ((G * body.mass * dx) / (Math.Pow(totalDistance, 3)));
        } else { ax = 0; }
        if (dz != 0) {
            az = ((G * body.mass * dz) / (Math.Pow(totalDistance, 3)));
        } else { az = 0; }

        return (ax, az);
    }


}
