using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierScript : MonoBehaviour
{
    public CubeAgentRay cube;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag.Contains("Mushroom"))
        {
            cube.Barrier_MushroomTouched();
        }
        if (collision.collider.tag.Contains("Coin"))
        {
            cube.Barrier_CoinTouched();
        }
    }
}
