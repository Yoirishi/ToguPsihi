

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
            body.OneArtistic = fun1(body.OneArtistic);
            body.OneHuman = fun1(body.OneHuman);
            body.OneNature = fun1(body.OneNature);
            body.OneSign = fun1(body.OneSign);
            body.OneTechnology = fun1(body.OneTechnology);
            body.TwoBiology = fun2(body.TwoBiology);
            body.TwoGeography = fun2(body.TwoGeography);
            body.TwoGeology = fun2(body.TwoGeology);
            body.TwoIndustry = fun2(body.TwoIndustry);
            body.TwoPhysics = fun2(body.TwoPhysics);
            body.TwoChemistry = fun2(body.TwoChemistry);
            body.TwoTechnique = fun2(body.TwoTechnique);
            body.TwoEngineering = fun2(body.TwoEngineering);
            body.TwoMetalworking = fun2(body.TwoMetalworking);
            body.TwoWoodworking = fun2(body.TwoWoodworking);
            body.TwoConstruction = fun2(body.TwoConstruction);
            body.TwoTransport = fun2(body.TwoTransport);
            body.TwoAAM = fun2(body.TwoAAM);
            body.TwoMilitary = fun2(body.TwoMilitary);
            body.TwoHistory = fun2(body.TwoHistory);
            body.TwoLiterature = fun2(body.TwoLiterature);
            body.TwoJournalism = fun2(body.TwoJournalism);
            body.TwoSocial = fun2(body.TwoSocial);
            body.TwoPedagogy = fun2(body.TwoPedagogy);
            body.TwoLaw = fun2(body.TwoLaw);
            body.TwoService = fun2(body.TwoService);
            body.TwoMaths = fun2(body.TwoMaths);
            body.TwoEconomy = fun2(body.TwoEconomy);
            body.TwoForeign = fun2(body.TwoForeign);
            body.TwoFigurative = fun2(body.TwoFigurative);
            body.TwoArt = fun2(body.TwoArt);
            body.TwoPerforming = fun2(body.TwoPerforming);
            body.Twomusic = fun2(body.Twomusic);
            body.TwoSports = fun2(body.TwoSports);
            body.ThreeReal = fun3(body.ThreeReal);
            body.ThreeInvestigative = fun3(body.ThreeInvestigative);
            body.ThreeArtistic = fun3(body.ThreeArtistic);
            body.ThreeSocial = fun3(body.ThreeSocial);
            body.ThreeEnterprisingn = fun3(body.ThreeEnterprisingn);
            body.ThreeConventional = fun3(body.ThreeConventional);






            using (ApplicationContext db = new ApplicationContext())
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

        private int? fun1(int? x)
        {
            if (x != null)
            {
                switch (x)
                {
                    case 0: x = 1; break;
                    case 1: x = 1; break;
                    case 2: case 3: x = 2; break;
                    case 4: x = 3; break;
                    case 5: case 6: x = 4; break;
                    case 7: case 8: x = 5; break;
                }
                return x;
            }


            return null;
        }

        private int? fun2(int? x)
        {
            if (x != null)
            {
                switch (x)
                {
                    case 0: case 1: case 2: case 3: case 4: x = 1; break;
                    case 5: case 6: x = 2; break;

                    case 7: case 8: case 9: x = 3; break;
                    case 10: case 11: case 12: x = 4; break;
                    case 13: case 14: x = 5; break;
                }
                return x;
            }


            return null;
        }
        private int? fun3(int? x)
        {
            if (x != null)
            {
                switch (x)
                {
                    case 0: case 1: case 2: case 3: x = 1; break;
                    case 4: case 5: x = 2; break;
                    case 6: case 7: case 8: x = 3; break;

                    case 9: case 10: x = 4; break;
                    case 11: case 12: x = 5; break;
                }
                return x;
            }


            return null;
        }
    }
}
