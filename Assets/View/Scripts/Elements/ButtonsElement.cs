using eraUni.View;
using Michsky.UI.ModernUIPack;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonsElement : MonoBehaviour
{
    [SerializeField]
    View view;
    [SerializeField]
    string[] buttonTexts;

    public View View { get => view; set => view = value; }
    public string[] ButtonTexts { get => buttonTexts; set => buttonTexts = value; }

    private void Start()
    {
        if (View == null)
            View = Resources.Load<View>("View");

        foreach (string text in ButtonTexts)
        {
            GameObject button = GameObject.Instantiate(View.Button);
            // 提供一个能够更改颜色的接口，可能需要更改 alpha 值。
            //view.GetComponent<Gradient>().Equals(colors.gradients[4]);
            button.transform.GetChild(0).GetComponent<TMP_Text>().SetText(text);
            button.transform.SetParent(transform, false);
        }
    }
}
