using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float waveAmp = 1;
    [SerializeField] private float waveSpd = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * new Vector3(0,0,Mathf.Cos(Time.time * waveSpd) * waveAmp);
    }
}
