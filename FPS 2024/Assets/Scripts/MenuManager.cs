using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    #region Singleton
    public static MenuManager instance;

    // M�todo chamado quando o script � inicializado
    private void Awake()
    {
        // Verifica se a inst�ncia � nula
        if (instance == null)
        {
            instance = this; // Define a inst�ncia para este objeto
        }
        else if (instance != this)
        {
            Destroy(gameObject); // Destroi o objeto se j� houver uma inst�ncia existente
        }
    }
    #endregion

    public void Connected()
    {

    }
}
