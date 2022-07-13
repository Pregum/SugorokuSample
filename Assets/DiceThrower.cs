using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceThrower : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //var tf = this.GetComponent<Transform>();
        var rb = this.GetComponent<Rigidbody>();
        var v3 = new Vector3(3.0f, 0.0f, 3.0f);
        rb.AddForce(v3);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            var rotateX = Random.Range(240, 241);
            var rotateY = Random.Range(0, 120);
            var rotateZ = Random.Range(0, 120);
            GameObject dice = this.gameObject;
            dice.transform.position = new Vector3(0, 8, -4);
            dice.GetComponent<Rigidbody>().AddForce(-transform.right * 300);
            dice.transform.Rotate(rotateX, rotateY, rotateZ);
        }
    }
}
