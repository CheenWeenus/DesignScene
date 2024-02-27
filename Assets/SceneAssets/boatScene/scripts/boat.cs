using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boat : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float waveAmp = 2;
    [SerializeField] private float waveSpd = 2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mathf.Sin(Time.time * waveSpd) * waveAmp
        transform.position += Time.deltaTime * new Vector3(0,0,Mathf.Cos(Time.time * waveSpd) * waveAmp);
    }
}
