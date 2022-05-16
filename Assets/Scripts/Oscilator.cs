using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilator : MonoBehaviour
{
    [SerializeField] [Range(0, 10)] private float period = 1;
    [SerializeField] private bool horizontal = false, diagonal = false, noise = false;

    private float xRandom, yRandom;

    private void Start()
    {
        xRandom = Random.Range(-5, 5);
        yRandom = Random.Range(-5, 5);
    }

    void Update()
    {
        if (horizontal)
        {
            HorizontalOscilation();
        }
        else if (diagonal)
        {
            DiagonalOscilation();
        }
        else if (noise)
        {
            Noise();
        }
    }
    private void HorizontalOscilation()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * period, 0);
    }

    private void DiagonalOscilation()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * period, Mathf.Sin(Time.time) * period);
    }

    private void Noise()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time + xRandom) * period, Mathf.Sin(Time.time + yRandom) * period);
    }
}
