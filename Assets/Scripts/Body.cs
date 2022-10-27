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
        this.gameObject.transform.position = new Vector3((float)(startingXPos * (1/sol.scale)), 0, 0);
        this.vz = startingZVel;
        Debug.Log("Initializing Body of " + this.gameObject + " at " + this.gameObject.transform.position + " with a velocity of " + vz * (1/sol.scale));
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void updatePosition(double timescale, double scale, float timestep) 
    {
        Debug.Log("Raw velocity of " + this.gameObject + " is (" + vx + "," + vz + ")");
        Vector3 velocity = new Vector3((float)(vx * timescale * timestep * (1/scale)), 0, (float)(vz * timescale * timestep * (1/scale)));
        Debug.Log("Velocity to be added to position of " + this.gameObject + " is (" + (vx * timescale * timestep * (1/scale)) + "," + (vz * timescale * timestep * (1/scale)) + ")");
        this.gameObject.transform.position = this.gameObject.transform.position + velocity;
        Debug.Log("New position for " + this.gameObject + " is " + this.gameObject.transform.position);
    }

    public void updateVelocity(double ax, double az, double timescale, float timestep)
    {
        this.vx += ax * timestep * timescale;
        this.vz += az * timestep * timescale;
    }
}
