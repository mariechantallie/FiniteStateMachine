using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IMonoState : IState {
    public event Action OnEnter;
    public event Action OnExit;
    public event Action OnUpdate;
    public event Action OnLateUpdate;
    public event Action OnFixedUpdate;

    void Update();

    void LateUpdate();

    void FixedUpdate();
}
