using maskiner.shared.Domain;

namespace BethanysPieShopHRM.App.Models
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
            var e1 = new Machine
            {
                Id = 1,
                Name = "Machine1",
                Description = "Some info",
                Status = true
                
            };

            var e2 = new Machine
            {
                Id = 1,
                Name = "Machine 2",
                Description = "Some info",
                Status = false
            };

            return new List<Machine>() { e1, e2 };
        }

        //private static List<JobCategory> InitializeMockJobCategories()
        //{
        //    return new List<JobCategory>()
        //    {
        //        new JobCategory{JobCategoryId = 1, JobCategoryName = "Pie research"},
        //        new JobCategory{JobCategoryId = 2, JobCategoryName = "Sales"},
        //        new JobCategory{JobCategoryId = 3, JobCategoryName = "Management"},
        //        new JobCategory{JobCategoryId = 4, JobCategoryName = "Store staff"},
        //        new JobCategory{JobCategoryId = 5, JobCategoryName = "Finance"},
        //        new JobCategory{JobCategoryId = 6, JobCategoryName = "QA"},
        //        new JobCategory{JobCategoryId = 7, JobCategoryName = "IT"},
        //        new JobCategory{JobCategoryId = 8, JobCategoryName = "Cleaning"},
        //        new JobCategory{JobCategoryId = 9, JobCategoryName = "Bakery"},
        //        new JobCategory{JobCategoryId = 9, JobCategoryName = "Bakery"}
        //    };
        //}

        //private static List<Country> InitializeMockCountries()
        //{
        //    return new List<Country>
        //    {
        //        new Country {CountryId = 1, Name = "Belgium"},
        //        new Country {CountryId = 2, Name = "Netherlands"},
        //        new Country {CountryId = 3, Name = "USA"},
        //        new Country {CountryId = 4, Name = "Japan"},
        //        new Country {CountryId = 5, Name = "China"},
        //        new Country {CountryId = 6, Name = "UK"},
        //        new Country {CountryId = 7, Name = "France"},
        //        new Country {CountryId = 8, Name = "Brazil"}
        //    };
        //}
    }
}
