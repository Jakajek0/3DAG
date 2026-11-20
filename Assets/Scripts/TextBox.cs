using UnityEngine;

public class TextBox : MonoBehaviour
{
    [SerializeField] private GameObject textBox;
    [SerializeField] private GameObject text;

    private Animator textBoxAnimator;
    private Animator textAnimator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textBox.SetActive(false);
        text.SetActive(false);

        textBoxAnimator = textBox.GetComponent<Animator>();
        textAnimator = text.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Text Box Animation
    public void TextBoxOpen()
    {
        textBox.SetActive(true);
        text.SetActive(true);
        textBoxAnimator.SetBool("BoxOpen", true);
        textAnimator.SetBool("TextOpen", true);
    }

    public void TextBoxClose()
    {
        textBoxAnimator.SetBool("BoxOpen", false);
        textAnimator.SetBool("TextOpen", false);
        textBox.SetActive(false);
        text.SetActive(false);
    }
}
