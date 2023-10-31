using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VfxManager : MonoBehaviour
{
    public static VfxManager s_Instance
    {
        get;
        protected set;
    }

    private void Awake()
    {
        if(s_Instance == null)
        {
            s_Instance = this;
            DontDestroyOnLoad(this);
        }
        else if(s_Instance != this)
        {
            Destroy(gameObject);
        }
     
    }

    [SerializeField] private GameObject m_hitPS;
	[SerializeField] private GameObject m_floorTrigger;
    public void InstantiateVFX(EVFX_Type vfxType, Vector3 pos)
    {
        switch (vfxType)
        {
            case EVFX_Type.Hit:
                Instantiate(m_hitPS, pos,Quaternion.identity, transform);
                    break;
			case EVFX_Type.Walk:
				Instantiate(m_floorTrigger, pos, Quaternion.identity, transform);
				break;
			case EVFX_Type.Jump:
				Instantiate(m_floorTrigger, pos, Quaternion.identity, transform);
				break;
			case EVFX_Type.Land:
				Instantiate(m_floorTrigger, pos, Quaternion.identity, transform);
				break;
            default:
                break;
        }
    }

   
    public enum EVFX_Type
    {
        Hit,
		Walk,
		Jump,
		Land,
        Count
    }
}
