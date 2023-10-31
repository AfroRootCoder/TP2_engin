using UnityEngine;
using System.Collections.Generic;

public class GameManagerSM : BaseStateMachine<IState>
{
    [SerializeField]
    protected Camera m_gameplayCamera;
    //[SerializeField]
    //protected Camera m_cinematicCamera;

    protected override void CreatePossibleStates()
    {
        m_possibleStates = new List<IState>();
        m_possibleStates.Add(new GameplayState(m_gameplayCamera));
        //m_possibleStates.Add(new CinematicState(m_cinematicCamera));
    }

    protected override void Start()
    {
        foreach(IState state in m_possibleStates)
        {
            state.OnStart();
        }
        m_currentState = m_possibleStates[0];
        m_currentState.OnEnter();
    }

    protected override void Update()
    {
        base.Update();
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }
}