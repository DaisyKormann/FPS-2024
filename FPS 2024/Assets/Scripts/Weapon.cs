using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] WeaponModel weapon;
    [SerializeField] Transform firePoint;
    [SerializeField] GameObject bulletImpact;


    void Start()
    {
        GetComponentInChildren<MeshFilter>();
        GetComponentInChildren<MeshRenderer>();

        // Inicialize o carregador atual com a capacidade m�xima do carregador da arma

        // Configure a apar�ncia da arma
    }

    void Update()
    {
        
    }
    void Fire()
    {
        StartCoroutine("Disparo Arma");
    }

    private IEnumerator FireCoroutine()
    {
        
        // Verifica se pode disparar

        // Reduz a muni��o do carregador
        // Define o tempo para o pr�ximo disparo

        // Dispara proj�teis com o tempo entre cada disparo
    }

    private void Shoot()
    {

    }

    void Reload()
    {

    }

    private IEnumerator ReloadCoroutine()
    {

    }

    private void OnDrawGizmos()
    {
        
    }
}
