using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{
    
    void Update()
    {
        if (transform.position.y < -1f)
        {
            Destroy(gameObject);
        }
    }
}
