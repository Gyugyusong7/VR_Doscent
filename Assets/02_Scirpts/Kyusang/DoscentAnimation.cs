using System;
using UnityEngine;

public class DoscentAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public static Action OnIdle;
    public static Action OnJump;
    public static Action OnDizzy;
    public static Action OnIdleActive;
    public static Action OnSway;
    public static Action OnVictory;
    public static Action OnSense;
    public static Action OnNod;
    public static Action OnFall;

    private readonly int hashIdle = Animator.StringToHash("Idle");
    private readonly int hashJump = Animator.StringToHash("Jump");
    private readonly int hashDizzy = Animator.StringToHash("Dizzy");
    private readonly int hashIdleActive = Animator.StringToHash("IdleActive");
    private readonly int hashSway = Animator.StringToHash("Sway");
    private readonly int hashVictory = Animator.StringToHash("Victory");
    private readonly int hashSense = Animator.StringToHash("Sense");
    private readonly int hashNod = Animator.StringToHash("Nod");
    private readonly int hashFall = Animator.StringToHash("Fall");
    private void OnEnable()
    {
        OnIdle += Idle;
        OnJump += Jump;
        OnDizzy += Dizzy;
        OnIdleActive += IdleActive;
        OnSway += Sway;
        OnVictory += Victory;
        OnSense += Sense;
        OnNod += Nod;
        OnFall += Fall;
    }



    private void OnDisable()
    {
        OnIdle -= Idle;
        OnJump -= Jump;
        OnDizzy -= Dizzy;
        OnIdleActive -= IdleActive;
        OnSway -= Sway;
        OnVictory -= Victory;
        OnSense -= Sense;
        OnNod -= Nod;
        OnFall -= Fall;
    }
    private void Idle()
    {
        animator.SetTrigger(hashIdle);
    }

    private void Jump()
    {
        animator.SetTrigger(hashJump);
    }
    private void Dizzy()
    {
        animator.SetTrigger(hashDizzy);
    }
    private void IdleActive()
    {
        animator.SetTrigger(hashIdleActive);
    }
    private void Sway()
    {
        animator.SetTrigger(hashSway);
    }
    private void Victory()
    {
        animator.SetTrigger(hashVictory);
    }
    private void Sense()
    {
        animator.SetTrigger(hashSense);
    }
    private void Nod()
    {
        animator.SetTrigger(hashNod);
    }
    private void Fall()
    {
        animator.SetTrigger(hashFall);
    }
}
