using BepInEx;
using RoR2;

namespace ChronobaubleIsWhite
{
    [BepInPlugin("io.github.Theray070696.chronobaubleiswhite", "ChronobaubleIsWhite", "1.0.0")]
    public class ChronobaubleIsWhite : BaseUnityPlugin
    {
        public void Awake()
        {
            ItemCatalog.GetItemDef(ItemIndex.SlowOnHit).tier = ItemTier.Tier1;
        }
    }
}