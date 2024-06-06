using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Weapon")]

public class WeaponModel : ScriptableObject
{
    [SerializeField] float damage;
    [SerializeField] float range;
    [SerializeField] float fireRate;
    [SerializeField] float spread;
    [SerializeField] float reloadTime;
    [SerializeField] float timeBetweenShoot;
    [SerializeField] int magazineCap;
    [SerializeField] int bulletsForShoot;
    [SerializeField] bool automatic;
    [SerializeField] bool scope;
    [SerializeField] Mesh model;
    [SerializeField] Material material;
    [SerializeField] Vector3 weaponPosition;

    public float Damage { get => damage; set => damage = value; }
    public float Range { get => range; set => range = value; }
    public float FireRate { get => fireRate; set => fireRate = value; }
    public float Spread { get => spread; set => spread = value; }
    public float ReloadTime { get => reloadTime; set => reloadTime = value; }
    public float TimeBetweenShoot { get => timeBetweenShoot; set => timeBetweenShoot = value; }
    public int MagazineCap { get => magazineCap; set => magazineCap = value; }
    public int BulletsForShoot { get => bulletsForShoot; set => bulletsForShoot = value; }
    public bool Automatic { get => automatic; set => automatic = value; }
    public bool Scope { get => scope; set => scope = value; }
    public Mesh Model { get => model; set => model = value; }
    public Material Material { get => material; set => material = value; }
    public Vector3 WeaponPosition { get => weaponPosition; set => weaponPosition = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
