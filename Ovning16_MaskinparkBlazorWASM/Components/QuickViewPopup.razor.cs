using Machines.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace Ovning16_MaskinparkBlazorWASM.Components
{
    public partial class QuickViewPopup
    {

        [Parameter]
        public Machine? Machine { get; set; }

        private Machine? _machine;

        protected override void OnParametersSet()
        {
            _machine = Machine;
        }

        public void Close()
        {
            _machine = null;
        }

    }
}
