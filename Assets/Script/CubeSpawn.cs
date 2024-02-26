using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{
    public GameObject cubePrefab;
    private Vector3 myPosition;
    private Quaternion myRotation;
    // Start is called before the first frame update
    void Start()
    {
        myPosition = transform.position;
        myRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(cubePrefab, myPosition, myRotation);
        }
    }
}
