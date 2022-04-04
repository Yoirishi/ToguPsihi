

using System.ComponentModel.DataAnnotations;
using ToguPsihi.Models;
using System.ComponentModel.DataAnnotations.Schema;
// using(ApplicationContext db = new ApplicationContext())
// {
//     var results = (from testOne in db.TestOnes
//         where testOne.OneNature! >= 1 && testOne.TwoGeography! >= 2
//             
//         select testOne).ToList();
//     foreach (TestOne testOne in results)
//         Console.WriteLine($"{testOne.Name} ({testOne.Education_level}) ({testOne.Description}) ({testOne.Exams}) ({testOne.desription_additional})");
// }


    

[Table("specials")]
public class TestOne 
{
    [Key]
    public int id { get; set; }

    public string? Name { get; set; }
    public string? Education_level { get; set; }
    public string? Description { get; set; }
    public string? Exams { get; set; }
    public string? desription_additional { get; set; }
    
    
    public int? OneNature { get; set; }
    public int? OneTechnology { get; set; }
    public int? OneHuman { get; set; }
    public int? OneSign { get; set; }
    public int? OneArtistic { get; set; }
    public int? TwoBiology { get; set; }
    public int? TwoGeography { get; set; }
    public int? TwoGeology { get; set; }
    // public int  TwoMedicine { get; set; }
    public int? TwoIndustry { get; set; }
    public int? TwoPhysics { get; set; }
    public int? TwoChemistry { get; set; }
    public int? TwoTechnique { get; set; }
    public int? TwoEngineering { get; set; }
    public int? TwoMetalworking { get; set; }
    public int? TwoWoodworking { get; set; }
    public int? TwoConstruction { get; set; }
    public int? TwoTransport { get; set; }
    public int? TwoAAM { get; set; }
    public int? TwoMilitary { get; set; }
    public int? TwoHistory { get; set; }
    public int? TwoLiterature { get; set; }
    public int? TwoJournalism { get; set; }
    public int? TwoSocial { get; set; }
    public int? TwoPedagogy { get; set; }
    public int? TwoLaw { get; set; }
    public int? TwoService { get; set; }
    public int? TwoMaths { get; set; }
    public int? TwoEconomy { get; set; }
    public int? TwoForeign { get; set; }
    public int? TwoFigurative { get; set; }
    public int? TwoArt { get; set; }
    public int? TwoPerforming { get; set; }
    public int? Twomusic { get; set; }
    public int? TwoSports { get; set; }
    public int? ThreeReal { get; set; }
    public int? ThreeInvestigative { get; set; }
    public int? ThreeArtistic { get; set; }
    public int? ThreeSocial { get; set; }
    public int? ThreeEnterprisingn { get; set; }
    public int? ThreeConventional { get; set; }

}



