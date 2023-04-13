using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputField : MonoBehaviour
{
    [SerializeField]
    TMP_InputField inputField;
    [SerializeField]
    Animator animator;
    string onSelectState = "Activated";
    string onEndEditState = "Inactive";

    private void Start()
    {
        if (inputField == null)
            inputField = gameObject.GetComponent<TMP_InputField>();
        if (animator == null)
            animator = gameObject.GetComponent<Animator>();
        if (inputField.onSelect.GetPersistentEventCount() == 0)
            inputField.onSelect.AddListener(delegate { AnimatorOnSelect(); });
        if (inputField.onEndEdit.GetPersistentEventCount() == 0)
            inputField.onEndEdit.AddListener(delegate { AnimatorOnEndEdit(); });
    }

    public void AnimatorOnSelect()
    {
        animator.Play(onSelectState);
    }

    public void AnimatorOnEndEdit()
    {
        if (inputField.text.Length == 0)
            animator.Play(onEndEditState);
    }

    private void UpdateAnimator()
    {
        if (inputField.text.Length == 0)
            AnimatorOnEndEdit();
        else
            AnimatorOnSelect();
    }
}
