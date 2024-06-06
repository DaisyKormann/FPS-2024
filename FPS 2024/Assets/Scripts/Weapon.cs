using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] WeaponModel weapon;
    [SerializeField] Transform firePoint;
    [SerializeField] GameObject bulletImpact;
    [SerializeField] int magazine;


    void Start()
    {

        GetComponentInChildren<MeshFilter>();
        GetComponentInChildren<MeshRenderer>();

        magazine = weapon.MagazineCap; // Inicialize o carregador atual com a capacidade máxima do carregador da arma

       //? Configure a aparência da arma 

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

        if () // Verifica se pode disparar
        {
            magazine--;         // Reduz a munição do carregador
            weapon.FireRate = 7;         // Define o tempo para o próximo disparo

        }



        // Dispara projéteis com o tempo entre cada disparo

    }

    private void Shoot()
    {
        // Variável para armazenar o que foi atingido
        // Direção do disparo, considerando a dispersão da arma

        // Verifica se acertou algo na direção do disparo dentro do alcance

        // Desenha uma linha para visualizar o trajeto do projétil
    }

    void Reload()
    {
        StartCoroutine("Recarga");
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