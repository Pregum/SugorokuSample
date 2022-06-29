using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject child = transform.GetChild(1).gameObject;
        child.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
