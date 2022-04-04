using Microsoft.AspNetCore.Mvc;
using ToguPsihi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToguPsihi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        // GET: api/<MainController>
        [Route("testOne")]
        [HttpPost]
        public IActionResult BlockOne([FromBody]TestOne model)
        {
            model.OneArtistic = fun1(model.OneArtistic);
            model.OneHuman= fun1(model.OneHuman);
            model.OneNature = fun1(model.OneNature);
            model.OneSign = fun1(model.OneSign);
            model.OneTechnology = fun1(model.OneTechnology);
            model.TwoBiology = fun2(model.TwoBiology);
            model.TwoGeography = fun2(model.TwoGeography);
            model.TwoGeology = fun2(model.TwoGeology);
            model.TwoIndustry = fun2(model.TwoIndustry);
            model.TwoPhysics = fun2(model.TwoPhysics);
            model.TwoChemistry = fun2(model.TwoChemistry);
            model.TwoTechnique = fun2(model.TwoTechnique);
            model.TwoEngineering = fun2(model.TwoEngineering);
            model.TwoMetalworking = fun2(model.TwoMetalworking);
            model.TwoWoodworking = fun2(model.TwoWoodworking);
            model.TwoConstruction = fun2(model.TwoConstruction);
            model.TwoTransport = fun2(model.TwoTransport);
            model.TwoAAM = fun2(model.TwoAAM);
            model.TwoMilitary = fun2(model.TwoMilitary);
            model.TwoHistory = fun2(model.TwoHistory);
            model.TwoLiterature = fun2(model.TwoLiterature);
            model.TwoJournalism = fun2(model.TwoJournalism);
            model.TwoSocial = fun2(model.TwoSocial);
            model.TwoPedagogy = fun2(model.TwoPedagogy);
            model.TwoLaw = fun2(model.TwoLaw);
            model.TwoService = fun2(model.TwoService);
            model.TwoMaths = fun2(model.TwoMaths);
            model.TwoEconomy = fun2(model.TwoEconomy);
            model.TwoForeign = fun2(model.TwoForeign);
            model.TwoFigurative = fun2(model.TwoFigurative);
            model.TwoArt = fun2(model.TwoArt);
            model.TwoPerforming = fun2(model.TwoPerforming);
            model.Twomusic = fun2(model.Twomusic);
            model.TwoSports = fun2(model.TwoSports);
            model.ThreeReal = fun3(model.ThreeReal);
            model.ThreeInvestigative = fun3(model.ThreeInvestigative);
            model.ThreeArtistic = fun3(model.ThreeArtistic);
            model.ThreeSocial = fun3(model.ThreeSocial);
            model.ThreeEnterprisingn = fun3(model.ThreeEnterprisingn);
            model.ThreeConventional = fun3(model.ThreeConventional);



            TestOneResult result = new TestOneResult(model);
            return Ok(result.results.ToHashSet());
        }
        [Route("testTwo")]
        [HttpPost]
        public IActionResult BlockTwo()
        {

           return Ok(new TestTwo());
        }

        private int? fun1(int? x) {
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
                    case 0:case 1:case 2:case 3:case 4:x = 1; break;
                    case 5: case 6: x = 2; break;

                    case 7: case 8:case 9: x = 3; break;
                    case 10:case 11: case 12: x = 4; break;
                    case 13:case 14: x = 5; break;
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
