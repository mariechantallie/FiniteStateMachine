using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState {
    public event Action OnEnter;
    public event Action OnExit;
    void Enter();

    void Exit();
}
