using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cl : MonoBehaviour
{
    public gm gm;
    public pm mv;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obs")
        {
            mv.enabled = false;
            FindObjectOfType<gm>().EndGame();
        }
        if (collisionInfo.collider.tag == "Finish")
        {
            mv.enabled = false;
            FindObjectOfType<gm>().Done();
        }
    }
}
