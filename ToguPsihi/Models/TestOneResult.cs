

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
                    where ((testOne.OneNature == null || testOne.OneNature <= body.OneNature)
                           && (testOne.OneArtistic == null || testOne.OneArtistic <= body.OneArtistic)
                           && (testOne.OneHuman == null || testOne.OneHuman <= body.OneHuman)
                           && (testOne.OneSign == null || testOne.OneSign <= body.OneSign)
                           && (testOne.OneTechnology == null || testOne.OneTechnology <= body.OneTechnology))
                           || ((testOne.ThreeArtistic == null || testOne.ThreeArtistic <= body.ThreeArtistic)
                           && (testOne.ThreeConventional == null || testOne.ThreeConventional <= body.ThreeConventional)
                           && (testOne.ThreeEnterprisingn == null || testOne.ThreeEnterprisingn <= body.ThreeEnterprisingn)
                           && (testOne.ThreeInvestigative == null || testOne.ThreeInvestigative <= body.ThreeInvestigative)
                           && (testOne.ThreeReal == null || testOne.ThreeReal <= body.ThreeReal)
                           && (testOne.ThreeSocial == null || testOne.ThreeSocial <= body.ThreeSocial))
                           ||((testOne.TwoAAM == null || testOne.TwoAAM <= body.TwoAAM)
                           && (testOne.TwoLaw == null || testOne.TwoLaw <= body.TwoLaw)
                           && (testOne.TwoSocial == null || testOne.TwoSocial <= body.TwoSocial)
                           && (testOne.Twomusic == null || testOne.Twomusic <= body.Twomusic)
                           && (testOne.TwoGeology == null || testOne.TwoGeology <= body.TwoGeology)
                           && (testOne.TwoArt == null || testOne.TwoArt <= body.TwoArt)
                           && (testOne.TwoSports == null || testOne.TwoSports <= body.TwoSports)
                           && (testOne.TwoBiology == null || testOne.TwoBiology <= body.TwoBiology)
                           && (testOne.TwoChemistry == null || testOne.TwoChemistry <= body.TwoChemistry)
                           && (testOne.TwoConstruction == null || testOne.TwoConstruction <= body.TwoConstruction)
                           && (testOne.TwoEconomy == null || testOne.TwoEconomy <= body.TwoEconomy)
                           && (testOne.TwoEngineering== null || testOne.TwoEngineering <= body.TwoEngineering)
                           && (testOne.TwoFigurative == null || testOne.TwoFigurative <= body.TwoFigurative)
                           && (testOne.TwoForeign == null || testOne.TwoForeign <= body.TwoForeign)
                           && (testOne.TwoGeography== null || testOne.TwoGeography <= body.TwoGeography)
                           && (testOne.TwoHistory == null || testOne.TwoHistory <= body.TwoHistory)
                           && (testOne.TwoService == null || testOne.TwoService <= body.TwoService)
                           && (testOne.TwoIndustry == null || testOne.TwoIndustry <= body.TwoIndustry)
                           && (testOne.TwoJournalism == null || testOne.TwoJournalism <= body.TwoJournalism)
                           && (testOne.TwoLiterature == null || testOne.TwoLiterature <= body.TwoLiterature)
                           && (testOne.TwoMaths == null || testOne.TwoMaths <= body.TwoMaths)
                           && (testOne.TwoMetalworking == null || testOne.TwoMetalworking <= body.TwoMetalworking)
                           && (testOne.TwoMilitary == null || testOne.TwoMilitary <= body.TwoMilitary)
                           && (testOne.TwoPedagogy == null || testOne.TwoPedagogy <= body.TwoPedagogy)
                           && (testOne.TwoPerforming == null || testOne.TwoPerforming <= body.TwoPerforming)
                           && (testOne.TwoPhysics == null || testOne.TwoPhysics <= body.TwoPhysics)
                           && (testOne.TwoSocial == null || testOne.TwoSocial <= body.TwoSocial)
                           && (testOne.TwoTechnique == null || testOne.TwoTechnique <= body.TwoTechnique)
                           && (testOne.TwoTransport == null || testOne.TwoTransport <= body.TwoTransport)
                           && (testOne.TwoWoodworking == null || testOne.TwoWoodworking <= body.TwoWoodworking))

                        
                    select testOne).ToList();
                foreach (TestOne testOne in results)
                    Console.WriteLine($"{testOne.Name} ({testOne.Education_level}) ({testOne.Description}) ({testOne.Exams}) ({testOne.desription_additional})");
            }
        }
        
        public List<TestOne> results = new List<TestOne>();
    }
}
