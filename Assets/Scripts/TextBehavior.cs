using System.Collections;
using UnityEngine;
using TMPro;

public class TextBehavior : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public float textSpeed = 0.05f;

    private string[] lines;
    private int index;
    public bool isDialogueActive { get; private set; }

    void Start()
    {
        gameObject.SetActive(false); // Keep hidden at start
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    // Now accepts lines directly from whichever NPC you talk to
    public void StartDialogue(string[] npcLines)
    {
        lines = npcLines;
        index = 0;
        textComponent.text = string.Empty;
        isDialogueActive = true;
        gameObject.SetActive(true);
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            isDialogueActive = false;
            gameObject.SetActive(false);
            textComponent.text = string.Empty;
        }
    }
}
