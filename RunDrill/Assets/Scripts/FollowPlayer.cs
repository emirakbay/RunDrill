using UnityEngine;
using Cinemachine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject targetPlayer;

    public Transform targetTransform;

    private CinemachineVirtualCamera vcam;

    public static FollowPlayer Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void  SetupFollowPlayer(Transform transform)
    {
        vcam = GetComponent<CinemachineVirtualCamera>();

        if (targetPlayer == null)
        {
            targetPlayer = GameObject.FindWithTag("Player");
        }

        targetTransform = targetPlayer.transform;

        vcam.Follow = targetTransform;
  
    }
}
