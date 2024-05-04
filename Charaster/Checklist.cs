namespace Charaster
{
    public class Checklist
    {
        public Checklist(Charaster charaster)
        {
            Item = charaster;
        }

        public Checklist(){}

        public Charaster? Item { get; set; }
        /*
        private bool CheckBasicAttributes => Item.BasicAttributes?
        private bool CheckSecondaryCharacteristics => Item.SecondaryCharacteristics ?
        private bool CheckBuild => return Item.Build?
        private bool CheckAgeAndBeauty => Item.AgeAndBeauty?
        private bool CheckSocialBackground => Item.SocialBackground?
        private bool CheckWealth => Item.Wealth?
        private bool CheckInfluence => Item.Influence?
        private bool CheckFriends => Item.Friends?
        private bool CheckFoes => Item.Foes?
        private bool CheckIdentities => Item.Identities?
        private bool CheckAdvantages => Item.Advantages?
        private bool CheckPerks => Item.Perks?
        private bool CheckDisadvantages => Item.Disadvantages??  
        private bool CheckQuirks => Item.Quirks?
        private bool CheckSkills => Item.Skills?
        private bool CheckTechniques => Item.Techniques?
        */
        public void Add(Charaster charaster)
        {
            Item = charaster;
        }

        public bool CheckAll()
        {
            return true;
            /*
            return CheckBasicAttributes &&
            CheckSecondaryCharacteristics &&
            CheckBuild &&
            CheckAgeAndBeauty && 
            CheckSocialBackground && 
            CheckWealth && 
            CheckInfluence &&
            CheckIdentities && 
            CheckFriends && 
            CheckFoes &&
            CheckAdvantages &&
            CheckPerks &&
            CheckDisadvantages &&
            CheckQuirks &&
            CheckSkills &&
            CheckTechniques;
            */
        }
    }
}