using UnityEngine;
using Cinemachine;

public class PlayerCameraController : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCam;

    private CinemachinePOV pov;

    void Start()
    {
        // Virtual Camera에서 POV 컴포넌트 가져오기
        pov = virtualCam.GetCinemachineComponent<CinemachinePOV>();
    }

    void LateUpdate()
    {
        if (pov == null) return;

        float cameraYaw = pov.m_HorizontalAxis.Value;
        transform.rotation = Quaternion.Euler(0f, cameraYaw, 0f);
    }
}
