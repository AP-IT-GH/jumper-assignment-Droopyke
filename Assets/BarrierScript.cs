using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierScript : MonoBehaviour
{
    public CubeAgentRay cube;
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Barrier touched: " + collision.collider.tag);
        Debug.Log("Barrier touched: " + collision.collider.name);
        if (collision.collider.tag.Contains("Mushroom"))
        {
            cube.MushroomTouched();
        }
    }
}
