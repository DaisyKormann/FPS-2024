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

        // Inicialize o carregador atual com a capacidade máxima do carregador da arma

        // Configure a aparência da arma
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

        // Reduz a munição do carregador
        // Define o tempo para o próximo disparo

        // Dispara projéteis com o tempo entre cada disparo
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
