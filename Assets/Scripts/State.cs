using System;

public abstract class State : IState {
    public event Action OnEnter;
    public event Action OnExit;

    public virtual void Enter() {
        OnEnter?.Invoke();
    }

    public virtual void Exit() {
        OnExit?.Invoke();
    }
}
