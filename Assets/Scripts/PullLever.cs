using UnityEngine;

public class PullLever : MonoBehaviour
{
    [SerializeField] private PowerBox powerBox; // Reference to the PowerBox script

    [SerializeField] private NPCInteract Interact;

    [SerializeField] private GameObject hook;

    [SerializeField] private GameObject blocker;

    [SerializeField] private GameObject metalSheet1;

    [SerializeField] private GameObject metalSheet2;

    private PickupCollect PickupCollect;

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
            hook.SetActive(false);
            blocker.SetActive(false);
            metalSheet1.GetComponent<Collider>().enabled = false;
            metalSheet2.GetComponent<Collider>().enabled = false;
            
            pull.SetTrigger("Pull");

            Interact.dialogueLines[0] = "That let go of the wrecking ball!";
            Interact.dialogueLines[1] = "There should be one of the missing clock mechanisms underneath.";
        }
        else if (PickupCollect.pickupAmount == 4)
        {
            Interact.dialogueLines[0] = "I have all the batteries, but I haven't put them in the electrical box.";
            Interact.dialogueLines[1] = "The electrical box should be at the bottom of the crane.";
        }
        else
        {
            //For quick testing
            /*hook.SetActive(false);
            blocker.SetActive(false);
            metalSheet1.GetComponent<Collider>().enabled = false;
            metalSheet2.GetComponent<Collider>().enabled = false;*/
            
            Interact.dialogueLines[0] = "I need more power to pull this lever.";
            Interact.dialogueLines[1] = "I should look around a little bit more.";
        }
    }
}
