using ExileCore.Shared.Attributes;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;

namespace ScourgeArrowCharges
{
    public class ScourgeArrowChargesSettings : ISettings
    {
        public ScourgeArrowChargesSettings()
        {
            LeftClick = new ToggleNode(false);
            TimeCheckCharges = new RangeNode<int>(1000, 10, 1000);
        }
        
        [Menu("Use Left Click", 1)]
        public ToggleNode LeftClick { get; set; }

        [Menu("Every N ms check charges")]
        public RangeNode<int> TimeCheckCharges { get; set; }
        public ToggleNode Enable { get; set; } = new ToggleNode(false);
    }
}
