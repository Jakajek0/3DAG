using UnityEngine;

public class NPCInteract : MonoBehaviour
{
    public TextBehavior dialogueBox;
    public GameObject interactPrompt; // "Press E" UI icon

    [SerializeField] private PowerBox powerBox; // Reference to the PowerBox script

    [SerializeField] private PullLever PullLever; // Reference to the PullLever script
    
    [TextArea(3, 5)]
    public string[] dialogueLines;

    private bool playerInRange = false;

    void Start()
    {
        if (interactPrompt != null)
            interactPrompt.SetActive(false);
    }

    void Update()
    {
        // Start dialogue if player is close, presses E, and isn't already talking
        if (playerInRange && Input.GetKeyDown(KeyCode.E) && !dialogueBox.isDialogueActive)
        {
            if (interactPrompt != null)
            {
                interactPrompt.SetActive(false);
            }
            if (powerBox != null)
            {
                powerBox.PowerOn(); // Call the PowerOn method from the PowerBox script
            }
            if (PullLever != null)
            {
                PullLever.PullLeverAction(); // Call the PullLeverAction method from the PullLever script
            }
                
            dialogueBox.StartDialogue(dialogueLines);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            if (interactPrompt != null)
                interactPrompt.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            if (interactPrompt != null)
                interactPrompt.SetActive(false);
        }
    }
}
