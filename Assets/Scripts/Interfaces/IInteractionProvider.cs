using UnityEngine;

/// <summary>
/// ��������� ��� �������������� ��������������
/// </summary>
public interface IInteractionProvider 
{
    /// <summary>
    /// ������������� ������������
    /// </summary>
    /// <param name="gameObject">������ ��� ��������������</param>
    void ProvideInteraction(GameObject gameObject);
}
    
