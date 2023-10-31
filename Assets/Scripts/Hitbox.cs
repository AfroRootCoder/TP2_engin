using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour
{
    [SerializeField]
    protected bool m_isHitReceiver;
    [SerializeField]
    protected bool m_isHitGiver;
    [SerializeField]
    protected EAgentType m_agentType = EAgentType.Count;

    public bool CanHitOther(Hitbox other)
    {
        return m_isHitGiver && other.m_isHitReceiver;
    }


    private void OnTriggerEnter(Collider other)
    {
        /*
          chck if other is hitbox
         if other.agent = Ally
                kjjnkasf
        if other.agent = Enemy
                blablabla
        if other.agent = Neutral
                blablabla
         */
        Hitbox otherHitbox = other.GetComponent<Hitbox>();
       
        if (otherHitbox == null ) 
        { 
            return; 
        }
        if (otherHitbox.m_agentType == EAgentType.Neutral)
        {
            CanHitOther(otherHitbox);
        }
        if (otherHitbox.m_agentType == EAgentType.Ally)
        {
            CanHitOther(otherHitbox);
        }
        if (otherHitbox.m_agentType == EAgentType.Enemy)
        {
            CanHitOther(otherHitbox);   
        }

    }
}

public enum EAgentType
{
    Ally,
    Enemy,
    Neutral,
    Count//num isquecer, eh uma boua idéia!
}
