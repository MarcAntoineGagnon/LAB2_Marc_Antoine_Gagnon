using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement_Translation_horizontale : MonoBehaviour
{
    [SerializeField] private float _vitesse = 1f;
    [SerializeField] private float _temps = 1f;
    private float _timer;

    private void Start()
    {

    }
    private void Update()
    {
        _timer += Time.deltaTime;
        if(_timer < _temps)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * _vitesse);
        }
        else
        {
            _timer = 0f;
            transform.Rotate(0f, 180f, 0f);
        }
       
    }
}
