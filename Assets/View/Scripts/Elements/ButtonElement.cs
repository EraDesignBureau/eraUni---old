using eraUni.View;
using Michsky.UI.ModernUIPack;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonElement : MonoBehaviour
{
    //[SerializeField]
    //View view;
    [SerializeField]
    string buttonText;

    //public View View { get => view; set => view = value; }
    public string ButtonText { get => buttonText; set => buttonText = value; }

    private void Start()
    {
        //if (View == null)
        //    View = Resources.Load<View>("View");

        transform.GetChild(0).GetComponent<TMP_Text>().SetText(ButtonText);
    }
}
