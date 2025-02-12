using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Course : MonoBehaviour
{   

    void Update()
    {
        float vitesse = Random.Range(1f, 20f);
        transform.Translate(0, 0, vitesse * Time.deltaTime);
    }
}
