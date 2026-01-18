using UnityEngine;
using UnityEngine.XR.ARFoundation;
using System.Collections; // necessário para o pequeno delay

public class GerenciadorMascaras : MonoBehaviour
{
    public ARFaceManager faceManager;
    
    // Seus arquivos
    public GameObject prefabLimpo; 
    public GameObject prefabBase;
    public GameObject prefabBatom;
    public GameObject prefabBlush;
    public GameObject prefabSombra;
    public GameObject prefabDelineador;
    public GameObject prefabContorno;
    public GameObject prefabCilios;
    public GameObject prefabIluminador;    

    // função que troca e reinicia
    void ForcarTroca(GameObject novoPrefab)
    {
        // 1. troca para o novo prefab
        faceManager.facePrefab = novoPrefab;

        // 2. remove todos os rostos que estão na tela agora
        foreach (ARFace rosto in faceManager.trackables)
        {
            Destroy(rosto.gameObject);
        }

        // 3. desliga e liga o manager para garantir o reinício
        StartCoroutine(ReiniciarSistema());
    }

    // Pequena pausa com espera de 1 frame
    IEnumerator ReiniciarSistema()
    {
        faceManager.enabled = false;
        yield return null; // Espera 1 frame
        faceManager.enabled = true;
    }

    // --- BOTÕES ---
    // Se a camada já estiver ativada, rosto fica Limpo. Se não, a camada é adicionada.
    
    public void AtivarBase()
    {
        if(faceManager.facePrefab == prefabBase) ForcarTroca(prefabLimpo);
        else ForcarTroca(prefabBase);
    }

    public void AtivarBatom()
    {
        if(faceManager.facePrefab == prefabBatom) ForcarTroca(prefabLimpo);
        else ForcarTroca(prefabBatom);
    }

    public void AtivarBlush()
    {
        if(faceManager.facePrefab == prefabBlush) ForcarTroca(prefabLimpo);
        else ForcarTroca(prefabBlush);
    }
    
    public void AtivarSombra()
    {
        if(faceManager.facePrefab == prefabSombra) ForcarTroca(prefabLimpo);
        else ForcarTroca(prefabSombra);
    }
    
    public void AtivarDelineador()
    {
        if(faceManager.facePrefab == prefabDelineador) ForcarTroca(prefabLimpo);
        else ForcarTroca(prefabDelineador);
    }

    public void AtivarContorno()
    {
        if(faceManager.facePrefab == prefabContorno)  ForcarTroca(prefabLimpo);
        else ForcarTroca(prefabContorno);
    }

    public void AtivarCilios()
    {
        if(faceManager.facePrefab == prefabCilios) ForcarTroca(prefabLimpo);
        else ForcarTroca(prefabCilios);
    }

    public void AtivarIluminador()
    {
        if(faceManager.facePrefab == prefabIluminador) ForcarTroca(prefabLimpo);
        else ForcarTroca(prefabIluminador);
    }
}