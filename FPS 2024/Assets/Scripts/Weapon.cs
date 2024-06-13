using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.XR;

public class Weapon : MonoBehaviour
{
    [SerializeField] WeaponModel weaponModel;
    [SerializeField] Transform firePoint;
    [SerializeField] GameObject bulletImpact;

     MeshFilter meshFilter;
    MeshRenderer meshRenderer;

    int currentMagazine;

    float timeToShoot;

    void Start()
    {

        meshFilter = GetComponentInChildren<MeshFilter>();
        meshRenderer = GetComponentInChildren<MeshRenderer>();

        currentMagazine = weaponModel.MagazineCap; // Inicialize o carregador atual com a capacidade máxima do carregador da arma

       // Configure a aparência da arma ja feito acima

    }

    void Update()
    {
        
    }
    void Fire()
    {
        StartCoroutine(FireCoroutine()); // chamar um método
    }
    
    IEnumerator FireCoroutine()
    {
        // Verifica se pode disparar
        if (Time.time >= timeToShoot) // verificar munição e fire rate
        {

            // Define o tempo para o próximo disparo
            timeToShoot = Time.time + 1 / weaponModel.FireRate;

            // Dispara projéteis com o tempo entre cada disparo
            if (int i = 0; i < weaponModel.BulletsForShoot; i++)
            {
                if (currentMagazine > 0)
                {
                    // Reduz a munição do carregador
                    currentMagazine--;
                    Shoot();
                    yield return new WaitForSeconds(weaponModel.TimeBetweenShoot);
                }
            }

        }

    }

    private void Shoot()
    {
        // Variável para armazenar o que foi atingido
        RaycastHit hit;

        // Direção do disparo, considerando a dispersão da arma
        Vector3 dirction = new Vector3(Random.Range(-weaponModel.Spread, weaponModel.Spread), Random.Range(-weaponModel.Spread, weaponModel .Spread, 1));

        // Verifica se acertou algo na direção do disparo dentro do alcance
        if (Physics.Raycast(firePoint.position, out hit, weaponModel.Range))
        {

        }

        // Desenha uma linha para visualizar o trajeto do projétil
    }

    void Reload()
    {
        StartCoroutine(ReloadCoroutine());
    }

    private IEnumerator ReloadCoroutine()
    { 
        // Verifica se precisa recarregar e se há munição disponível

        // Atualiza a munição no carregador e no inventário

        // Aguarda o tempo de recarga
    }

    private void OnDrawGizmos()
    {
        // Você pode adicionar gizmos para visualizar coisas como o alcance do disparo
        Gizmos.color = Color.red; // talvez ?
    }
}