using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTank : MonoBehaviour
{
    [SerializeField] GameObject tankprefab;
    // Start is called before the first frame update
    void Start()
    {
        //spawning
        Instantiate(tankprefab, transform.position, Quaternion.identity); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
