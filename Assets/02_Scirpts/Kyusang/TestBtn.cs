using UnityEngine;

public class TestBtn : MonoBehaviour
{
    public void Idle()
    {
        DoscentAnimation.OnIdle?.Invoke();
    }
    public void Jump()
    {
        DoscentAnimation.OnJump?.Invoke();
    }
    public void Dizzy()
    {
        DoscentAnimation.OnDizzy?.Invoke();
    }
    public void IdleActive()
    {
        DoscentAnimation.OnIdleActive?.Invoke();
    }
    public void Sway()
    {
        DoscentAnimation.OnSway?.Invoke();
    }
    public void Victory()
    {
        DoscentAnimation.OnVictory?.Invoke();
    }
}
