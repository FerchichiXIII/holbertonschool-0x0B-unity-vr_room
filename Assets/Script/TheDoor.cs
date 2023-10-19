using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using UnityEngine.XR;

public class TheDoor : MonoBehaviour
{
    public Animator Anim;
    public bool DoorOpen = false;
    private bool isInteractable = true;


    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
    }
    public void OpenDoor()
    {
        DoorOpen = !DoorOpen;
        Anim.SetBool("character_nearby", true);
    }
    public void CloseDoor()
    {
        DoorOpen = false;
        Anim.SetBool("character_nearby", false);
    }
}
 