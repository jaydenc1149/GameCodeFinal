using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardSpawn : MonoBehaviour // spawns hazards like spikes
{
    // code referenced: https://www.youtube.com/watch?v=ydjpNNA5804
    // variables
    public GameObject Hazard;
    public int xPosition;
    public int zposition;
    public int HazardCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }
IEnumerator HazardSpawner() // spawns hazards on random coordinates
{
while (HazardCount < 16){
    xPosition = Random.Range(0,1000); // random number generator for x coordinate
    zPosition = Random.Range(0,1000); // random number generator for z coordinate
    Instantiate(Hazard, new Vector3(xPosition, 0, zPosition), Quarternion.identity); // places hazard (y is constant)
    HazardCount++;
}
}
    
}
