using UnityEngine;
public class SeasonChange : MonoBehaviour
{
    [SerializeField] private seasons season;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Doscent"))
        {
            SceneMgr.OnEnterLayerDesign.Invoke();
            SceneMgr.OnExitLobby?.Invoke();
            SeasonsSystemURP.onSeasonChange?.Invoke(this.season);
            DoscentScript.OnSeasonChange?.Invoke(this.season);
            Destroy(this.gameObject);
        }
    }
}
