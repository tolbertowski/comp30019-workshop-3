using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XOrbit : MonoBehaviour
{

    [SerializeField] private float rotateDiameter;
    [SerializeField] private float moveSpeed;

    private float currentAngle;
    
    // Update is called once per frame
    void Update()
    {
        currentAngle += Time.deltaTime * this.moveSpeed;
        
        float y = rotateDiameter * Mathf.Cos(currentAngle);
        float z = rotateDiameter * Mathf.Sin(currentAngle);
        
        transform.position = new Vector3(transform.position.x, y, z);

    }
}
