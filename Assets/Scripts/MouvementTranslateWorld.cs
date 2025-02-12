using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementTranslateWorld : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] float vitesse;
    void Update()
    {
        //transform.Translate(1f * Time.deltaTime, 0, 0,Space.World);

        //Vector3 deplacement = new Vector3(1f, 0, 0);
        //transform.Translate(deplacement * Time.deltaTime, Space.World);
        transform.Translate(direction.normalized * vitesse * Time.deltaTime, Space.Self);
    }
}
