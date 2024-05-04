using CharasterType;
using Characteristics;

namespace Charaster{

    public class Charaster
    {
        public Charaster(CharasterType charasterType)
        {
            
        }

        Characteristics.Basic BasicAttributes? { get; set; }
        Characteristics.Secondary SecondaryCharacteristics ? { get; set; }  
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
    }
}
