using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallShredder : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Wall wall = collision.GetComponent<Wall>();
        if (wall != null)
        {
            wall.DestroySelf();
        }
    }
}
