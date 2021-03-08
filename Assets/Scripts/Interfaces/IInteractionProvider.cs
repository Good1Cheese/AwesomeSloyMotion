using UnityEngine;

/// <summary>
/// Интерфейс для предоставления взаимодействия
/// </summary>
public interface IInteractionProvider 
{
    /// <summary>
    /// Предоствление взаимодствия
    /// </summary>
    /// <param name="gameObject">Объект для взяимодействия</param>
    void ProvideInteraction(GameObject gameObject);
}
    
