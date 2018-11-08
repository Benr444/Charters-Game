using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardRotater : MonoBehaviour
{
    public float rotateFrequency;
    private Vector3 initialPos;

    // Use this for initialization
    void Awake()
    {
        initialPos = transform.position;
    }
	
	// Update is called once per frame
	void Update()
    {
        if (Application.isPlaying)
        {
            transform.RotateAround(transform.position, transform.up, 360 * rotateFrequency * Time.deltaTime);
            transform.position = initialPos + new Vector3(Mathf.Cos(Time.time), Mathf.Sin(Time.time), 0);
        }
    }
}
