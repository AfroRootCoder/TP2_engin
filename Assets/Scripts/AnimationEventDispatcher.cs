using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventDispatcher : MonoBehaviour
{
    private CharacterControllerStateMachine ccsm;
    public Collider fistCollider; //é melhor colocar no CharacCtrlSM aparentemente

    void Awake()
    {
        ccsm = GetComponent<CharacterControllerStateMachine>();
        //tem q fazer no ccsm pq tem que desativar também no
        //onExit Hit State - para fazer um double check
    }

    public void ActivateAttackHitbox()
    {
        Debug.Log("activate");
        //fistCollider.enabled = true;
        ccsm.TogglePunchHitBox(true);
        ccsm.PlayPunchSound(true);
        
    }

    public void DesActivateAttackHitbox()
    {
        Debug.Log("desactivate");
        //fistCollider.enabled = false;
        ccsm.TogglePunchHitBox(false);
        ccsm.PlayPunchSound(false);

    }
}
