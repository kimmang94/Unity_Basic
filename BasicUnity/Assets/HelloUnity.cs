using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("Hello Awake");
    }
    void Start()
    {
        Debug.Log("Hello Start");
    }
    void OnEnable()
    {
        Debug.Log("Hello OnEnable");
    }

    void OnDisable()
    {
        Debug.Log("Hello Disable");
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello Update");
    }

    void FixedUpdate()
    {
        Debug.Log("Hello FiexdUpdate");
    }

    void LateUpdate()
    {
        Debug.Log("Hello LateUpdate");
    }
}
