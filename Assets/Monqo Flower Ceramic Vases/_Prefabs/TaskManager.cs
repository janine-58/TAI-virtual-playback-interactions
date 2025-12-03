using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class TaskManager : MonoBehaviour
{
    public XRGrabInteractable objectToPickUp;

    public bool taskCompleted = false;

    private void Start()
    {
        objectToPickUp.selectEntered.AddListener(OnPickedUp);
    }

    private void OnPickedUp(SelectEnterEventArgs args)
    {
        taskCompleted = true;
        Debug.Log("Task Completed: Object was picked up!");
    }
}
