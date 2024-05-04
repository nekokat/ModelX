using Characteristics;
using Support.Types;

namespace Charaster{

    public class Charaster
    {
        public Charaster(CharasterType charasterType)
        {
        }

        public Charaster()
        {            
            Dexterity = new(BasicAttributesType.Dexterity);
        }
        
        Basic Dexterity { get; set; }
        Secondary SecondaryCharacteristics { get; set; }  
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
