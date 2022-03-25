using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinDrawer : MonoBehaviour
{
    [SerializeField] 
    [Tooltip("The prefab that will be instantiated a lot")]
    private GameObject prefab;

    [SerializeField]
    [Tooltip("The total instances")]
    private int nSamples = 5;

    [SerializeField]
    [Range(0, 1)]
    private float lenght = 1;

    [SerializeField]
    [Range(0, 10)]
    private float amplitude = 1;

    [SerializeField]
    [Range(-10, 10)]
    private float t = 1;

    [SerializeField]
    [Range(-10, 10)]
    private float transformPosY = 0;

    [SerializeField]
    [Range(-10, 10)]
    private float transformPosX = 0;


    private void Start()
    {
        for (int i = 0; i < nSamples; i++)
        {
            var child = Instantiate(prefab, transform);
        }
    }

    private void Update()
    {
        int i = 0;

        foreach (Transform child in transform)
        {
            float x = i * lenght;
            child.localPosition = new Vector3(x,(amplitude * Mathf.Sin(transformPosX + x * t) + transformPosY) , 0);
            ++i;
        }
    }
}
