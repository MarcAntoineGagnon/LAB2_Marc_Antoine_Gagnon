using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Rotatifs : MonoBehaviour
{
    [SerializeField] private float _vitesseR = 1f;
 
    void FixedUpdate()
    {
        transform.Rotate(0f, _vitesseR, 0f);
    }
}
