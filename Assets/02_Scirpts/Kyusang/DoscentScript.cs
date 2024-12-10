using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class DoscentScript : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip[] introClips;
    [SerializeField] private float[] introIntermissions;
    [SerializeField] private AudioClip[] springClips;
    [SerializeField] private float[] springIntermissions;
    [SerializeField] private AudioClip[] summerClips;
    [SerializeField] private float[] summerIntermissions;
    [SerializeField] private AudioClip[] autumnClips;
    [SerializeField] private float[] autumnIntermissions;
    [SerializeField] private AudioClip[] winterClips;
    [SerializeField] private float[] winterIntermissions;
    [SerializeField] private DoscentAnimation doscentAnimation;
    public static Action<seasons> OnSeasonChange;

    private CancellationTokenSource cancellationTokenSource;

    private void OnEnable()
    {
        OnSeasonChange += SeasonalDub;
    }

    private void OnDisable()
    {
        OnSeasonChange -= SeasonalDub;
    }

    private async void Start()
    {
        for (int i = 0; i < introClips.Length; i++)
        {
            if (audioSource != null && introClips[i] != null)
            {
                audioSource.clip = introClips[i];
                audioSource.Play();
                await Task.Delay((int)(introClips[i].length * 1000));
                await Task.Delay((int)(introIntermissions[i] * 1000));
            }
        }
    }

    private async void SeasonalDub(seasons season)
    {
        // Cancel the previous playback if a new season is triggered
        if (cancellationTokenSource != null)
        {
            cancellationTokenSource.Cancel();
            cancellationTokenSource.Dispose();
        }

        cancellationTokenSource = new CancellationTokenSource();
        CancellationToken token = cancellationTokenSource.Token;

        AudioClip[] selectedClips;
        float[] selectedIntermissions;

        switch (season)
        {
            case seasons.spring:
                selectedClips = springClips;
                selectedIntermissions = springIntermissions;
                break;
            case seasons.summer:
                selectedClips = summerClips;
                selectedIntermissions = summerIntermissions;
                break;
            case seasons.autumn:
                selectedClips = autumnClips;
                selectedIntermissions = autumnIntermissions;
                break;
            case seasons.winter:
                selectedClips = winterClips;
                selectedIntermissions = winterIntermissions;
                break;
            default:
                Debug.LogError("Unknown season selected!");
                return;
        }

        try
        {
            for (int i = 0; i < selectedClips.Length; i++)
            {
                if (audioSource != null && selectedClips[i] != null)
                {
                    audioSource.clip = selectedClips[i];
                    audioSource.Play();

                    await Task.Delay((int)(selectedClips[i].length * 1000), token);
                    await Task.Delay((int)(selectedIntermissions[i] * 1000), token);
                }
            }
        }
        catch (TaskCanceledException)
        {
            Debug.Log("SeasonalDub playback canceled.");
        }
    }
    private void Update()
    {
        SyncClipWithAnimation();
    }
    private void LateUpdate()
    {
        Vector3 targetPosition = Camera.main.transform.position;
        targetPosition.y = this.transform.position.y;
        this.transform.LookAt(targetPosition);
    }
    private void SyncClipWithAnimation()
    {
        if (audioSource.clip == introClips[0])
        {

        }
        else if (audioSource.clip == introClips[1])
        {
            DoscentAnimation.OnJump?.Invoke();
        }
        else if (audioSource.clip == introClips[2])
        {
            DoscentAnimation.OnIdleActive?.Invoke();
        }
        else if (audioSource.clip == introClips[3])
        {
            DoscentAnimation.OnSense?.Invoke();
        }
        else if (audioSource.clip == introClips[4])
        {
            DoscentAnimation.OnIdle?.Invoke();
        }
        else if (audioSource.clip == springClips[0])
        {
            DoscentAnimation.OnVictory?.Invoke();
        }
        else if (audioSource.clip == springClips[1])
        {
            DoscentAnimation.OnSway?.Invoke();
        }
        else if (audioSource.clip == springClips[2])
        {
            DoscentAnimation.OnJump?.Invoke();
        }
        else if (audioSource.clip == springClips[3])
        {
            DoscentAnimation.OnSway?.Invoke();
        }
        else if (audioSource.clip == springClips[4])
        {
            DoscentAnimation.OnFall?.Invoke();
        }
        else if (audioSource.clip == springClips[5])
        {
            DoscentAnimation.OnDizzy?.Invoke();
        }
        else if (audioSource.clip == springClips[6])
        {
            DoscentAnimation.OnSway?.Invoke();
        }
        else if (audioSource.clip == springClips[7])
        {
            DoscentAnimation.OnIdleActive?.Invoke();
        }
        else if (audioSource.clip == summerClips[0])
        {
            DoscentAnimation.OnJump?.Invoke();
        }
        else if (audioSource.clip == summerClips[1])
        {
            DoscentAnimation.OnSense?.Invoke();
        }
        else if (audioSource.clip == summerClips[2])
        {

        }
        else if (audioSource.clip == summerClips[3])
        {
            DoscentAnimation.OnIdle?.Invoke();
        }
        else if (audioSource.clip == summerClips[4])
        {
            DoscentAnimation.OnSway?.Invoke();
        }
        else if (audioSource.clip == summerClips[5])
        {
            DoscentAnimation.OnIdleActive?.Invoke();
        }
        else if (audioSource.clip == autumnClips[0])
        {
            DoscentAnimation.OnJump?.Invoke();
        }
        else if (audioSource.clip == autumnClips[1])
        {
            DoscentAnimation.OnNod?.Invoke();
        }
        else if (audioSource.clip == autumnClips[2])
        {

        }
        else if (audioSource.clip == autumnClips[3])
        {
            DoscentAnimation.OnSense?.Invoke();
        }
        else if (audioSource.clip == autumnClips[4])
        {
            DoscentAnimation.OnVictory?.Invoke();
        }
        else if (audioSource.clip == autumnClips[5])
        {
            DoscentAnimation.OnIdle?.Invoke();
        }
        else if (audioSource.clip == autumnClips[6])
        {
            DoscentAnimation.OnSway?.Invoke();
        }
        else if (audioSource.clip == winterClips[0])
        {
            DoscentAnimation.OnNod?.Invoke();
        }
        else if (audioSource.clip == winterClips[1])
        {
            DoscentAnimation.OnSway?.Invoke();
        }
        else if (audioSource.clip == winterClips[2])
        {
            DoscentAnimation.OnSense?.Invoke();
        }
        else if (audioSource.clip == winterClips[3])
        {
            DoscentAnimation.OnIdleActive?.Invoke();
        }
        else if (audioSource.clip == winterClips[4])
        {
            DoscentAnimation.OnIdle?.Invoke();
        }
        else if (audioSource.clip == winterClips[5])
        {

        }
        else DoscentAnimation.OnIdle?.Invoke();
    }

}
