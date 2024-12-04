using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using TMPro.Examples;
using UnityEditor.Experimental.GraphView;

public class SpinButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool buttonPressed;
    public GameObject objToRotate;
    public int direction = -1;
    public string rotateAxis;

    public void OnPointerDown(PointerEventData eventData)
    {
        GameObject stage = GameObject.Find("ModelStage");
        objToRotate = stage.GetComponent<ToggleModel>().currentModel;
        Debug.Log("pressed");
        buttonPressed = true;
        ObjectSpin objSpin = objToRotate.GetComponent<ObjectSpin>();
        objSpin.rotateAxis = rotateAxis;
        objSpin.rotateDir = direction;


    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ObjectSpin objSpin = objToRotate.GetComponent<ObjectSpin>();
        objSpin.rotateDir = 0;
        objSpin.rotateAxis = null;
        buttonPressed = false;
    }


}
