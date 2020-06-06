using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Oscillator : MonoBehaviour
{
    [SerializeField] Vector3 movementVector = new Vector3(20f, 10f, 0f);
    [SerializeField] float period = 2f;

    float movementFactor; // 0 for not moved, 1 for fully moved.
    Vector3 startingPos;

    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (period <= Mathf.Epsilon) { return; }
            float cycles = Time.time / period;
            const float tau = Mathf.PI * 2;
            float rawSinWave = Mathf.Sin(cycles * tau); // -1 to 1
            movementFactor = (rawSinWave / 2f) + 0.5f; // 0 to 1
            Vector3 offset = movementVector * movementFactor;
            transform.position = startingPos + offset;
    }
}
