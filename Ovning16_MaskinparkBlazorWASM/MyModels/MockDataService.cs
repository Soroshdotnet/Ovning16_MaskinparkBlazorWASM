using Machines.Shared.Domain;

namespace Ovning16_MaskinparkBlazorWASM.MyModels
{
    public class MockDataService
    {
        private static List<Machine>? _machines = default!;

        public static List<Machine> Machine
        {
            get
            {
                //we will use these in initialization of Machines
                _machines ??= InitializeMockMachine();

                return _machines;
            }
        }

        private static List<Machine> InitializeMockMachine()
        {
            var m1 = new Machine
            {
                Id = 1,
                Name = "Transformer",
                Description = "Very good at transforming",
                Status = true

            };

            var m2 = new Machine
            {
                Id = 2,
                Name = "Droid",
                Description = "Cousin Android",
                Status = false
            };

            var m3 = new Machine
            {
                Id = 3,
                Name = "Weatherman",
                Description = "Talks about weather",
                Status = false
            };

            return new List<Machine>() { m1, m2, m3 };
        }
    }
}
