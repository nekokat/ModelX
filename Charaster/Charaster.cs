using Characteristics;
using Types;

namespace Charaster{

    public class Charaster
    {
        public Charaster(CharasterType charasterType)
        {
        }

        public Charaster()
        {            
            Dexterity = new(BasicAttributesType.Dexterity);
            Health = new(BasicAttributesType.Health);
            Intelligence = new(BasicAttributesType.Intelligence);
            Strength = new(BasicAttributesType.Strength);
        }
        
        Basic? Dexterity { get; set; }
        Basic? Health { get; set; }
        Basic? Intelligence { get; set; }
        Basic? Strength { get; set; }
        
        Secondary? SecondaryCharacteristics { get; set; }  
        /*
        Build?;
        AgeAndBeauty?;
        SocialBackground?;
        Wealth?;
        Influence?;
        Friends?;
        Foes?;
        Identities?;
        Advantages?;
        Perks?;
        Disadvantages?;
        Quirks?;
        Skills?;
        Techniques?;
        */
    }
}
