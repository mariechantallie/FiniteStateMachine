using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine {
    public List<IMonoState> States { get; private set; } = new List<IMonoState>();
    public IMonoState Current { get; private set; }

    public void Add(IMonoState toAdd) {
        States.Add(toAdd);
    }

    public void Remove(IMonoState toRemove) {
        States.Remove(toRemove);
    }

    public void ChangeState(IMonoState toState) {
        Current?.Exit();
        Current = toState;
        Current.Enter();
    }
}
