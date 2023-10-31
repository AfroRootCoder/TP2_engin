using UnityEngine;

public class AnimationEventController: MonoBehaviour
{
    [SerializeField]
    private CharacterControllerStateMachine characterControllerStateMachine;
	private void Awake()
	{
		characterControllerStateMachine = GetComponent<CharacterControllerStateMachine>();
	}
    public void EnableAttackHitBox()
    {
        //characterControllerStateMachine.OnEnableAttackHitBox(true);
    }
	public void DisableAttackHitBox()
	{
		//characterControllerStateMachine.OnEnableAttackHitBox(false);
	}
}
