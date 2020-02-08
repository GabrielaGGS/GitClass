using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CityGenerator : MonoBehaviour
{
    public GameObject carPrefab;
    public GameObject [] calles;
    private int random;
    private GameObject callePos;
    private GameObject street;
    private GameObject ranCalles;
    private Vector3 positi;
    private GameObject[] str;

    void Start()
    {
        Instantiate(carPrefab, Vector3.zero, Quaternion.Euler(-90f, 0f, 0f));
        positi = Vector3.forward(200f);
        //positi = callePos.transform.position + 200;
    }
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
       {
        random = Random.Range(0, calles.Length);
        ranCalles = calles[random];
        street = Instantiate(ranCalles, transform.position + positi, Quaternion.identity);
        Destroy(street, 15f);
       }
    }
}
