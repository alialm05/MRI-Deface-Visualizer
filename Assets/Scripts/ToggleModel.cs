using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

public class ToggleModel : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject currentModel;
    public GameObject spawn;
    public Vector3 modelPosition = new Vector3(330.1f, 40.4f, -66.7f);
    public Material modelMaterial;
    public Slider TransparencySlider;

    public void modelTranparency(float  t)
    {
        if (currentModel != null)
        {
            Debug.Log((float)Math.Floor(t * 255));

            modelMaterial.color = new Color(modelMaterial.color.r, modelMaterial.color.g, modelMaterial.color.b, t);
        }
    }

    public void changeModel(GameObject model)
    {
        GameObject prevModel = currentModel;
        currentModel = model;
        prevModel.transform.position = spawn.transform.position - new Vector3(0, 0, 600);
        prevModel.transform.rotation = spawn.transform.rotation;

        prevModel.GetComponent<ObjectSpin>().enabled = false;
        
        currentModel.transform.position = spawn.transform.position;
        Console.WriteLine(currentModel.transform.position);
        currentModel.GetComponent<ObjectSpin>().enabled = true;
    }

    private void Awake()
    {
        //modelPosition = this.;
        currentModel.transform.position = spawn.transform.position;
        currentModel.GetComponent<ObjectSpin>().enabled = true;

        modelTranparency(TransparencySlider.value);
        TransparencySlider.onValueChanged.AddListener(delegate { modelTranparency(TransparencySlider.value); } );

    }

}
