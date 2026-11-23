using UnityEngine;

public class PullLever : MonoBehaviour
{
    [SerializeField] private PowerBox powerBox; // Reference to the PowerBox script

    [SerializeField] private NPCInteract Interact;

    private Animator pull;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pull = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PullLeverAction()
    {
        if (powerBox.isPoweredOn == true)
        {
            pull.SetTrigger("Pull");
        }
        else
        {
            Interact.dialogueLines[0] = "I need more power to pull this lever.";
            Interact.dialogueLines[1] = "Maybe I should look around a little bit more.";
        }
    }
}
