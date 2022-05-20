
namespace assignment1
{
    abstract class Character
    {
        private IWeaponBehaviour weapon;
        
        public IWeaponBehaviour Weapon 
        {
            get { return weapon; } 
            set { weapon = value; } 
        }

        public Character()
        {
            Weapon = new SwordBehaviour();
        }

        public void Fight()
        {
            weapon.UseWeapon();
        }
    }
}
