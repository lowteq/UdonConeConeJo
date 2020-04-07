using System;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;

using VRC.SDKBase;
using VRC.Udon;

public class ShowDatetime : UdonSharpBehaviour
{
    public float RotateSpeed;
    public Text text;

    void Update(){

        this.gameObject.transform.Rotate(this.gameObject.transform.up * RotateSpeed * Time.deltaTime);
        text.text = DateTime.Now.ToString();


    }
}
