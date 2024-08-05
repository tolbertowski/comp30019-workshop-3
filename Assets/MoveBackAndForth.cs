using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    [SerializeField] private float thresholdDistance;

    private int _dir = 1;
    
    // Update is called once per frame
    void Update()
    {
        transform.localPosition +=
            Vector3.forward * (Time.deltaTime * this.moveSpeed * this._dir);

        if (transform.localPosition.z > thresholdDistance)
            this._dir = -1;
        else if (transform.localPosition.z < 0.0f)
            this._dir = 1;
    }
}
