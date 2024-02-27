using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveFront : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float waveAmp = 2;
    [SerializeField] private float waveSpd = 3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * new Vector3(Mathf.Sin(Time.time * waveSpd) * waveAmp,0,Mathf.Cos(Time.time * waveSpd) * waveAmp);
    }
}
