using UnityEngine.InputSystem;

public class BlockInteraction : IInputInteraction
{
    public float duration = 3f;
    public bool IsHeld { get; set; }

    public void Process(ref InputInteractionContext context)
    {
        if (context.timerHasExpired)
        {
            context.Canceled();
            IsHeld = false;
            return;
        }

        switch (context.phase)
        {
            case InputActionPhase.Waiting:
                if (context.ReadValue<float>() < 0.1f)
                {
                    context.Started();
                    context.SetTimeout(duration);
                }
                break;
            case InputActionPhase.Started:
                if (context.ReadValue<float>() > 0.1f)
                {
                    context.Performed();
                    IsHeld = true;
                }
                break;
        }
    }

    public void Reset()
    {
        IsHeld = false;
    }
}
