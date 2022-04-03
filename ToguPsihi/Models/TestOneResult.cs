

// using(ApplicationContext db = new ApplicationContext())
// {
//     var results = (from testOne in db.TestOnes
//         where testOne.OneNature! >= 1 && testOne.TwoGeography! >= 2
//             
//         select testOne).ToList();
//     foreach (TestOne testOne in results)
//         Console.WriteLine($"{testOne.Name} ({testOne.Education_level}) ({testOne.Description}) ({testOne.Exams}) ({testOne.desription_additional})");
// }

namespace ToguPsihi.Models
{
    public class TestOneResult
    {
        public TestOneResult(TestOne body)
        {
            using(ApplicationContext db = new ApplicationContext())
            {
                
                this.results = (from testOne in db.TestOnes
                    where (testOne.OneNature == null || testOne.OneNature <= body.OneNature)
                           && (testOne.OneArtistic == null || testOne.OneArtistic <= body.OneArtistic)
                           && (testOne.OneHuman == null || testOne.OneHuman <= body.OneHuman)
                           && (testOne.OneSign == null || testOne.OneSign <= body.OneSign)
                           && (testOne.OneTechnology == null || testOne.OneTechnology <= body.OneTechnology)
                        
                    select testOne).ToList();
                foreach (TestOne testOne in results)
                    Console.WriteLine($"{testOne.Name} ({testOne.Education_level}) ({testOne.Description}) ({testOne.Exams}) ({testOne.desription_additional})");
            }
        }
        
        public List<TestOne> results = new List<TestOne>();
    }
}
