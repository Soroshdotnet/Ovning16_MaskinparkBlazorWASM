using Machines.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace Ovning16_MaskinparkBlazorWASM.Components
{
    public partial class MachineCard
    {
        [Parameter]
        public Machine Machine { get; set; } = default!;
    }
}
