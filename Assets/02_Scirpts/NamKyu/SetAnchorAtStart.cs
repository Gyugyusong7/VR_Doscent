using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SetAnchorAtStart : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<ARAnchor>();
    }

}
