using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelTextureControllerSample : MonoBehaviour
{

    ModelTextureController modelTex = null;

    [SerializeField]
    int drawNo = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (modelTex != null) return;
        modelTex = GetComponent<ModelTextureController>();
    }

    // Update is called once per frame
    void Update()
    {
        Start();
        if (modelTex == null) return;

        modelTex.SetTexture(drawNo);
    }
}
