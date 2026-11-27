using Unity.VisualScripting; 
using UnityEngine;

public class MachineOn : MonoBehaviour
{
    [SerializeField] private NPCInteract Interact;

    [SerializeField] private GameObject lever;
    [SerializeField] private GameObject knob;

    [SerializeField] private GameObject cheese;
    
    private Animator leverAnim;
    private Animator knobAnim;

    private Animator cheeseAnim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        leverAnim = lever.GetComponent<Animator>();
        knobAnim = knob.GetComponent<Animator>();

        cheeseAnim = cheese.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateMachine()
    {
        leverAnim.SetTrigger("isPulled");
        knobAnim.SetTrigger("Rotating");

        Interact.dialogueLines[0] = "My job is gonna get replaced by robots...";

        cheeseAnim.SetTrigger("Activate");
    }
}
