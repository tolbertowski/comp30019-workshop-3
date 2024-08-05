using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figure8 : MonoBehaviour
{
    [SerializeField] private float eightDiameter;
    [SerializeField] private float moveSpeed;

    private float currentAngle;
    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
        Debug.Log(initialPosition);
    }

    // Update is called once per frame
    void Update()
    {
        currentAngle += Time.deltaTime * this.moveSpeed;

        float x = eightDiameter * Mathf.Cos(currentAngle);
        float z = eightDiameter * Mathf.Sin(currentAngle * 2) / 2;

        transform.position = new Vector3(initialPosition.x + x, transform.position.y, initialPosition.z + z);
    }
}
