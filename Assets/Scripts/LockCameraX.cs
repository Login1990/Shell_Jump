using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
 
[ExecuteInEditMode] [SaveDuringPlay] [AddComponentMenu("")] // Hide in menu
public class LockCameraX : CinemachineExtension
{
    [Tooltip("Lock the camera's X position to this value")]
    public float m_XPosition = 0f;
    public LowestY LowestY;
    [HideInInspector]
    public float m_YPosition;
 
    protected override void PostPipelineStageCallback(
        CinemachineVirtualCameraBase vcam1,
        CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (stage == CinemachineCore.Stage.Body)
        {
            var pos = state.RawPosition;
            if (pos.y < LowestY.GetY())
            {
                m_YPosition = LowestY.GetY();
            }
            else
            {
                m_YPosition = pos.y;
                LowestY.NewY(m_YPosition);
            }
            pos.x = m_XPosition;
            pos.y = m_YPosition;
            state.RawPosition = pos;
        }
    }
}
