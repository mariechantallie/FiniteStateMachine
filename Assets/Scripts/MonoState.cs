using System;

public abstract class MonoState : IMonoState {
    public event Action OnEnter;
    public event Action OnExit;
    public event Action OnUpdate;
    public event Action OnLateUpdate;
    public event Action OnFixedUpdate;

    public virtual void Enter() {
        OnEnter?.Invoke();
    }

    public virtual void Exit() {
        OnExit?.Invoke();
    }

    public virtual void FixedUpdate() {
        OnFixedUpdate?.Invoke();
    }

    public virtual void LateUpdate() {
        OnLateUpdate?.Invoke();
    }

    public virtual void Update() {
        OnUpdate?.Invoke();
    }
}
