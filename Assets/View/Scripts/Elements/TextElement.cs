using TMPro;
using UnityEngine;

public class TextElement : MonoBehaviour
{
    [SerializeField]
    TMP_Text textObject;
    [SerializeField]
    string inputText;

    public TMP_Text TextObject { get => textObject; set => textObject = value; }
    public string InputText { get => inputText; set => inputText = value; }

    private void Start()
    {
        if (TextObject == null)
            TextObject = this.GetComponentInChildren<TMP_Text>();
        if (InputText != "" && TextObject != null)
            TextObject.SetText(InputText);
    }
}
