using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Course : MonoBehaviour
{
    [SerializeReference] GameObject poissonCible;
    

    void Update()
    {
        float vitesse = Random.Range(2f, 10f);
        transform.Translate(0, 0, vitesse * Time.deltaTime);
    }
    void Test()
    {
            Debug.Log("Fish" + "wins");
    }
}
