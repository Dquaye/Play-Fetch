using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spawndogInterval = 2;
    public bool takingaway = false;

    // Update is called once per frame

    private void Start()
    {
        
    }
    void Update()
    {
        //Condition written to ensure timer begins after first dog sent
        if (takingaway == false && spawndogInterval > 0)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                StartCoroutine(Timetake());
                spawndogInterval = 2;
            }
            
        }
    }

    // Timer to prevent continuous spawning of Dog
    IEnumerator Timetake()
    {
        takingaway = true;
        yield return new WaitForSeconds(1);
        spawndogInterval -= 1;
        takingaway = false;
        
    }


}
