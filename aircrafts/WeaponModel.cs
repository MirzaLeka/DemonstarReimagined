
public class WeaponModel{

    public Weapons WeaponName;
    public int DealingDamage;
    public int FireRate;
    public int OverallAmmo;
    public string Color;

    public WeaponModel(Weapons weaponName, int damage, int fireRate, int ammo, string color) {
        this.WeaponName = weaponName;
        this.DealingDamage = damage;
        this.FireRate = fireRate;
        this.OverallAmmo = ammo;
        this.Color = color;
    }

}