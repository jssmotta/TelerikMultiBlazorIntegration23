﻿using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using TelerikBlazorAppMain.Models.Employee;
using TelerikBlazorAppMain.Models.Sales;

namespace TelerikBlazorAppMain.Data;
public class DataService : IDataService
{
    public IWebHostEnvironment WebHostEnvironment { get; set; }

    public DataService(IWebHostEnvironment webHostEnvironment)
    {
        WebHostEnvironment = webHostEnvironment;
    }
    private static List<Team>? Teams { get; set; }
    private static List<Sale>? Sales { get; set; }
    private static List<Employee>? Employees { get; set; }
    public List<Team> GetTeams()
    {
        if (Teams == null)
        {

            Teams = new List<Team> {
                new()
                {
                    TeamId = 1,
                    TeamName = "Tiger Team",
                    TeamColor =  "#FF6358"
                },
                new()
                {
                    TeamId = 2,
                    TeamName = "Lemon Team",
                    TeamColor =  "#F7C62F"
                },
                new()
                {
                    TeamId = 3,
                    TeamName = "Organic Team",
                    TeamColor =  "#55AB1D"
                },
                new()
                {
                    TeamId = 4,
                    TeamName = "Ocean Team",
                    TeamColor =  "#28B4C8"
                }
            };
        }

        return Teams;
    }

    public List<Employee> GetEmployees()
    {
        if (Employees == null)
        {

            Employees = new List<Employee> {
            new()
            {

               TeamId = 3,
               FullName = "Sig Jeannel",
               JobTitle = "Human Resources Assistant III",
               Country = "US",
               IsOnline = true,
               Rating =  3,
               Target = 100,
               Budget = 47601,
               Phone = "(936) 9429601",
               Address = "138 Buhler Avenue",
               ImgId = 1,
               Gender = "M",
        },
                    new()
                    { TeamId = 3,
        FullName = "Shelden Greyes",
        JobTitle = "Operator",
        Country = "GB",
        IsOnline = true,
        Rating =  5,
        Target = 40,
        Budget = 12253,
        Phone = "(343) 6656271",
        Address = "2 Waxwing Point",
        ImgId = 2,
        Gender = "M"},
                    new()
                    { TeamId = 4,

        FullName = "Megen Cody",
        JobTitle = "Operator",
        Country = "BR",
        IsOnline = true,
        Rating =  1,
        Target = 66,
        Budget = 96183,
        Phone = "(178) 2336256",
        Address = "4082 Stephen Court",
        ImgId = 6,
        Gender = "F",

                },
                    new()
                    { TeamId = 1,

        FullName = "Clevey Thursfield",
        JobTitle = "VP Quality Control",
        Country = "BR",
        IsOnline = true,
        Rating =  2,
        Target = 58,
        Budget = 54936,
        Phone = "(277) 7415010",
        Address = "1563 Glacier Hill Parkway",
        ImgId = 5,
        Gender = "M",

                },
                    new()
                    { TeamId = 2,

        FullName = "Ruthi Baldini",
        JobTitle = "Data Coordiator",
        Country = "BR",
        IsOnline = true,
        Rating =  3,
        Target = 37,
        Budget = 46572,
        Phone = "(766) 5691615",
        Address = "6 Laurel Avenue",
        ImgId = 8,
        Gender = "F",

                },
                    new()
                    { TeamId = 4,

        FullName = "Annecorinne Morter",
        JobTitle = "Professor",
        Country = "FR",
        IsOnline = false,
        Rating =  2,
        Target = 35,
        Budget = 37198,
        Phone = "(807) 2524830",
        Address = "106 Green Street",
        ImgId = 3,
        Gender = "F",

                },
                    new()
                    { TeamId = 2,

        FullName = "Gracia Punyer",
        JobTitle = "Assistant Manager",
        Country = "ES",
        IsOnline = true,
        Rating =  4,
        Target = 64,
        Budget = 84752,
        Phone = "(515) 9749536",
        Address = "69 Brentwood Alley",
        ImgId = 2,
        Gender = "F",

                },
                    new()
                    { TeamId = 2,

        FullName = "Duky Hurring",
        JobTitle = "Account Executive",
        Country = "BR",
        IsOnline = false,
        Rating =  3,
        Target = 61,
        Budget = -1266,
        Phone = "(897) 7202034",
        Address = "39 Morning Circle",
        ImgId = 3,
        Gender = "M",

                },
                    new()
                    { TeamId = 1,

        FullName = "Briana Shemelt",
        JobTitle = "Professor",
        Country = "US",
        IsOnline = false,
        Rating =  3,
        Target = 63,
        Budget = -9308,
        Phone = "(205) 2560799",
        Address = "11 Walton Court",
        ImgId = 2,
        Gender = "F",

                },
                    new()
                    { TeamId = 4,

        FullName = "Lexis Mostin",
        JobTitle = "Analyst Programmer",
        Country = "FR",
        IsOnline = true,
        Rating =  4,
        Target = 81,
        Budget = 38153,
        Phone = "(903) 8388089",
        Address = "38547 Westend Way",
        ImgId = 4,
        Gender = "F",

                },
                    new()
                    { TeamId = 2,

        FullName = "Felizio Gooda",
        JobTitle = "GIS Technical Architect",
        Country = "DE",
        IsOnline = true,
        Rating =  3,
        Target = 89,
        Budget = 81585,
        Phone = "(372) 2389397",
        Address = "9 Summer Ridge Circle",
        ImgId = 2,
        Gender = "M",

                },
                    new()
                    { TeamId = 2,

        FullName = "Aubry Oxberry",
        JobTitle = "Financial Advisor",
        Country = "BR",
        IsOnline = false,
        Rating =  2,
        Target = 3,
        Budget = -6095,
        Phone = "(665) 4176083",
        Address = "06 Lerdahl Point",
        ImgId = 10,
        Gender = "F",

                },
                    new()
                    { TeamId = 1,

        FullName = "Orly Glasbey",
        JobTitle = "Environmental Tech",
        Country = "BR",
        IsOnline = true,
        Rating =  5,
        Target = 63,
        Budget = 63945,
        Phone = "(449) 8482879",
        Address = "4035 Porter Parkway",
        ImgId = 6,
        Gender = "F",

                },
                    new()
                    { TeamId = 4,

        FullName = "Stephanus Culp",
        JobTitle = "Cost Accountant",
        Country = "BR",
        IsOnline = false,
        Rating =  2,
        Target = 60,
        Budget = 10613,
        Phone = "(148) 3124030",
        Address = "57028 Moland Terrace",
        ImgId = 8,
        Gender = "M",

                },
                    new()
                    { TeamId = 2,

        FullName = "Roseanna Janecek",
        JobTitle = "Database Administrator IV",
        Country = "FR",
        IsOnline = false,
        Rating =  4,
        Target = 97,
        Budget = 77351,
        Phone = "(125) 4421623",
        Address = "21973 Beilfuss Alley",
        ImgId = 4,
        Gender = "F",

                },
                    new()
                    { TeamId = 1,

        FullName = "Weidar McCombe",
        JobTitle = "Civil Engineer",
        Country = "FR",
        IsOnline = true,
        Rating =  1,
        Target = 77,
        Budget = 35924,
        Phone = "(488) 7911627",
        Address = "7 Dahle Terrace",
        ImgId = 1,
        Gender = "M",

                },
                    new()
                    { TeamId = 4,

        FullName = "Evelin Spirritt",
        JobTitle = "Analyst Programmer",
        Country = "BR",
        IsOnline = false,
        Rating =  2,
        Target = 18,
        Budget = 58552,
        Phone = "(821) 9538078",
        Address = "89418 Knutson Pass",
        ImgId = 1,
        Gender = "M",

                },
                    new()
                    { TeamId = 2,

        FullName = "Andria Helbeck",
        JobTitle = "Nurse Practicioner",
        Country = "BR",
        IsOnline = true,
        Rating =  4,
        Target = 53,
        Budget = 72526,
        Phone = "(387) 9614638",
        Address = "8589 Vernon Drive",
        ImgId = 8,
        Gender = "F",

                },
                    new()
                    { TeamId = 1,

        FullName = "Mariellen Ravelus",
        JobTitle = "Systems Administrator I",
        Country = "DE",
        IsOnline = true,
        Rating =  2,
        Target = 22,
        Budget = -6659,
        Phone = "(300) 6741661",
        Address = "707 Gale Hill",
        ImgId = 9,
        Gender = "F",

                },
                    new()
                    { TeamId = 3,

        FullName = "Corri Pergens",
        JobTitle = "Help Desk Operator",
        Country = "BR",
        IsOnline = true,
        Rating =  2,
        Target = 74,
        Budget = 12376,
        Phone = "(769) 7145603",
        Address = "856 Forest Crossing",
        ImgId = 3,
        Gender = "F",

                },
                    new()
                    { TeamId = 3,

        FullName = "Friedrick Macknish",
        JobTitle = "Human Resources Assistant II",
        Country = "FR",
        IsOnline = true,
        Rating =  2,
        Target = 38,
        Budget = 97848,
        Phone = "(196) 4156385",
        Address = "157 Talisman Trail",
        ImgId = 9,
        Gender = "M",

                },
                    new()
                    { TeamId = 4,

        FullName = "Georgette Trevorrow",
        JobTitle = "VP Accounting",
        Country = "FR",
        IsOnline = true,
        Rating =  3,
        Target = 3,
        Budget = 17327,
        Phone = "(319) 1412549",
        Address = "07 Marquette Point",
        ImgId = 3,
        Gender = "F",

                },
                    new()
                    { TeamId = 4,

        FullName = "Vanya Goalby",
        JobTitle = "Senior Cost Accountant",
        Country = "FR",
        IsOnline = false,
        Rating =  2,
        Target = 77,
        Budget = 33584,
        Phone = "(496) 7538982",
        Address = "2192 Iowa Lane",
        ImgId = 6,
        Gender = "F",

                },
                    new()
                    { TeamId = 1,

        FullName = "Abel Ansell",
        JobTitle = "Actuary",
        Country = "US",
        IsOnline = false,
        Rating =  4,
        Target = 52,
        Budget = 12312,
        Phone = "(571) 9908377",
        Address = "4355 Iowa Parkway",
        ImgId = 4,
        Gender = "M",

                },
                    new()
                    { TeamId = 2,

        FullName = "Odille Barus",
        JobTitle = "Speech Pathologist",
        Country = "FR",
        IsOnline = true,
        Rating =  4,
        Target = 60,
        Budget = 46911,
        Phone = "(974) 1137672",
        Address = "496 Lotheville Avenue",
        ImgId = 8,
        Gender = "F",

                },
                    new()
                    { TeamId = 4,

        FullName = "Rudolf Consadine",
        JobTitle = "Structural Analysis Engineer",
        Country = "FR",
        IsOnline = true,
        Rating =  4,
        Target = 20,
        Budget = 94258,
        Phone = "(450) 7612220",
        Address = "93 Thierer Park",
        ImgId = 6,
        Gender = "M",

                },
                    new()
                    { TeamId = 3,

        FullName = "Christabel Bick",
        JobTitle = "Engineer III",
        Country = "FR",
        IsOnline = true,
        Rating =  5,
        Target = 0,
        Budget = 65359,
        Phone = "(361) 5159566",
        Address = "191 Bunting Pass",
        ImgId = 5,
        Gender = "F",

                },
                    new()
                    { TeamId = 3,

        FullName = "Lancelot Tanzer",
        JobTitle = "Senior Developer",
        Country = "US",
        IsOnline = true,
        Rating =  5,
        Target = 80,
        Budget = 13246,
        Phone = "(502) 3949900",
        Address = "4287 Corben Plaza",
        ImgId = 8,
        Gender = "M",

                },
                    new()
                    { TeamId = 4,

        FullName = "Bink Byk",
        JobTitle = "Software Engineer I",
        Country = "FR",
        IsOnline = false,
        Rating =  3,
        Target = 17,
        Budget = 56472,
        Phone = "(475) 9070061",
        Address = "075 Eggendart Avenue",
        ImgId = 9,
        Gender = "M",

                },
                    new()
                    { TeamId = 1,

        FullName = "Rhys Pheazey",
        JobTitle = "Speech Pathologist",
        Country = "BR",
        IsOnline = false,
        Rating =  5,
        Target = 98,
        Budget = 62483,
        Phone = "(365) 8904529",
        Address = "987 Carioca Lane",
        ImgId = 9,
        Gender = "M",

                },
                    new()
                    { TeamId = 1,

        FullName = "Lyndell Howieson",
        JobTitle = "Speech Pathologist",
        Country = "DE",
        IsOnline = true,
        Rating =  2,
        Target = 82,
        Budget = 16694,
        Phone = "(461) 3130038",
        Address = "9 Pennsylvania Crossing",
        ImgId = 8,
        Gender = "F",

                },
                    new()
                    { TeamId = 1,

        FullName = "Cassey Fitchell",
        JobTitle = "Software Engineer III",
        Country = "FR",
        IsOnline = true,
        Rating =  2,
        Target = 10,
        Budget = 91253,
        Phone = "(985) 5060547",
        Address = "652 Merry Place",
        ImgId = 9,
        Gender = "F",

                },
                    new()
                    { TeamId = 4,

        FullName = "Coralyn Steljes",
        JobTitle = "Accounting Assistant III",
        Country = "FR",
        IsOnline = false,
        Rating =  2,
        Target = 81,
        Budget = -9871,
        Phone = "(760) 5696853",
        Address = "4 Norway Maple Pass",
        ImgId = 9,
        Gender = "F",

                },
                    new()
                    { TeamId = 2,

        FullName = "Bruis Creavin",
        JobTitle = "Nuclear Power Engineer",
        Country = "BR",
        IsOnline = false,
        Rating =  1,
        Target = 59,
        Budget = -5798,
        Phone = "(570) 8801169",
        Address = "71 Carioca Park",
        ImgId = 6,
        Gender = "M",

                },
                    new()
                    { TeamId = 2,

        FullName = "Adrianne Peery",
        JobTitle = "Chief Design Engineer",
        Country = "FR",
        IsOnline = false,
        Rating =  2,
        Target = 2,
        Budget = 56575,
        Phone = "(793) 1143493",
        Address = "3 2nd Drive",
        ImgId = 7,
        Gender = "F",

                },
                    new()
                    { TeamId = 2,

        FullName = "Port Gerauld",
        JobTitle = "Senior Cost Accountant",
        Country = "FR",
        IsOnline = true,
        Rating =  2,
        Target = 27,
        Budget = 97919,
        Phone = "(155) 5488067",
        Address = "9 High Crossing Center",
        ImgId = 5,
        Gender = "M",

                },
                    new()
                    { TeamId = 1,

        FullName = "Boy Antoszewski",
        JobTitle = "VP Accounting",
        Country = "GB",
        IsOnline = true,
        Rating =  2,
        Target = 11,
        Budget = 74779,
        Phone = "(715) 9192627",
        Address = "3773 Hazelcrest Road",
        ImgId = 6,
        Gender = "M",

                },
                    new()
                    { TeamId = 1,

        FullName = "Gib Yakebowitch",
        JobTitle = "Marketing Assistant",
        Country = "BR",
        IsOnline = false,
        Rating =  5,
        Target = 57,
        Budget = 89028,
        Phone = "(923) 6953600",
        Address = "7 Mariners Cove Point",
        ImgId = 8,
        Gender = "M",

                },
                    new()
                    { TeamId = 1,

        FullName = "Minerva Gilders",
        JobTitle = "Administrative Officer",
        Country = "BR",
        IsOnline = false,
        Rating =  3,
        Target = 54,
        Budget = 32267,
        Phone = "(773) 8863232",
        Address = "82 Annamark Way",
        ImgId = 4,
        Gender = "F",

                },
                    new()
                    { TeamId = 3,

        FullName = "Wait Peperell",
        JobTitle = "Sales Representative",
        Country = "US",
        IsOnline = true,
        Rating =  4,
        Target = 94,
        Budget = 72251,
        Phone = "(419) 5806752",
        Address = "0355 Petterle Avenue",
        ImgId = 1,
        Gender = "M",

                },
                    new()
                    { TeamId = 3,

        FullName = "Ailsun Esmead",
        JobTitle = "Software Test Engineer III",
        Country = "FR",
        IsOnline = true,
        Rating =  1,
        Target = 12,
        Budget = 69596,
        Phone = "(852) 7039628",
        Address = "0 Lunder Crossing",
        ImgId = 8,
        Gender = "F",

                },
                    new()
                    { TeamId = 2,

        FullName = "Vallie Van der Velde",
        JobTitle = "Nurse",
        Country = "GB",
        IsOnline = true,
        Rating =  3,
        Target = 89,
        Budget = 19530,
        Phone = "(331) 7690832",
        Address = "2 Almo Lane",
        ImgId = 4,
        Gender = "F",

                },
                    new()
                    { TeamId = 1,

        FullName = "Dov Amber",
        JobTitle = "Sales Representative",
        Country = "FR",
        IsOnline = false,
        Rating =  4,
        Target = 55,
        Budget = 61106,
        Phone = "(793) 4768356",
        Address = "4 Rockefeller Street",
        ImgId = 3,
        Gender = "M",

                },
                    new()
                    { TeamId = 3,

        FullName = "Tedie Alu",
        JobTitle = "Business Systems Analyst",
        Country = "FR",
        IsOnline = false,
        Rating =  1,
        Target = 76,
        Budget = 3114,
        Phone = "(602) 5831373",
        Address = "28 Claremont Plaza",
        ImgId = 5,
        Gender = "M",

                },
                    new()
                    { TeamId = 4,

        FullName = "Tally Rizzi",
        JobTitle = "Civil Engineer",
        Country = "US",
        IsOnline = false,
        Rating =  1,
        Target = 5,
        Budget = 78575,
        Phone = "(302) 6856300",
        Address = "1 Roth Park",
        ImgId = 10,
        Gender = "M",

                },
                    new()
                    { TeamId = 2,

        FullName = "Ilise Lewnden",
        JobTitle = "Database Administrator I",
        Country = "BR",
        IsOnline = false,
        Rating =  4,
        Target = 33,
        Budget = -1059,
        Phone = "(659) 8660881",
        Address = "19 Stuart Alley",
        ImgId = 2,
        Gender = "F",

                },
                    new()
                    { TeamId = 1,

        FullName = "Farr Penwright",
        JobTitle = "Senior Editor",
        Country = "US",
        IsOnline = true,
        Rating =  3,
        Target = 82,
        Budget = 30505,
        Phone = "(505) 3900066",
        Address = "9200 Karstens Crossing",
        ImgId = 6,
        Gender = "M",

                },
                    new()
                    { TeamId = 1,

        FullName = "Chantal Bidgod",
        JobTitle = "Vice President, Sales",
        Country = "BR",
        IsOnline = false,
        Rating =  3,
        Target = 62,
        Budget = 25742,
        Phone = "(746) 3962702",
        Address = "8807 Kinsman Drive",
        ImgId = 2,
        Gender = "F",

                },
                    new()
                    { TeamId = 3,

        FullName = "Johanna Bergin",
        JobTitle = "Electrical Engineer",
        Country = "BR",
        IsOnline = false,
        Rating =  2,
        Target = 54,
        Budget = 25864,
        Phone = "(720) 6442547",
        Address = "93166 Spohn Court",
        ImgId = 3,
        Gender = "F",

                },
                    new()
                    { TeamId = 1,

        FullName = "Padriac Syphas",
        JobTitle = "Marketing Assistant",
        Country = "BR",
        IsOnline = true,
        Rating =  1,
        Target = 50,
        Budget = 20879,
        Phone = "(606) 9062546",
        Address = "50465 Buena Vista Plaza",
        ImgId = 5,
        Gender = "M",

                },
                    new()
                    { TeamId = 3,

        FullName = "Garey De Maria",
        JobTitle = "Operator",
        Country = "US",
        IsOnline = true,
        Rating =  2,
        Target = 54,
        Budget = 94251,
        Phone = "(972) 1133958",
        Address = "24 Maple Wood Terrace",
        ImgId = 9,
        Gender = "M",

                },
                    new()
                    { TeamId = 2,

        FullName = "Glenn Thorwarth",
        JobTitle = "Developer IV",
        Country = "BR",
        IsOnline = false,
        Rating =  5,
        Target = 39,
        Budget = 33511,
        Phone = "(394) 3115946",
        Address = "8 Dryden Park",
        ImgId = 1,
        Gender = "M",

                },
                    new()
                    { TeamId = 4,

        FullName = "Bron Crosson",
        JobTitle = "Sales Representative",
        Country = "FR",
        IsOnline = true,
        Rating =  2,
        Target = 80,
        Budget = 62081,
        Phone = "(686) 7934926",
        Address = "974 Mayfield Place",
        ImgId = 9,
        Gender = "M",

                },
                    new()
                    { TeamId = 4,

        FullName = "Garey Malecky",
        JobTitle = "Account Executive",
        Country = "BR",
        IsOnline = false,
        Rating =  5,
        Target = 51,
        Budget = 76354,
        Phone = "(304) 6324519",
        Address = "3 Paget Court",
        ImgId = 9,
        Gender = "M",

                },
                    new()
                    { TeamId = 2,

        FullName = "Elisabet Kimblin",
        JobTitle = "Automation Specialist I",
        Country = "US",
        IsOnline = true,
        Rating =  3,
        Target = 35,
        Budget = 26755,
        Phone = "(904) 3334563",
        Address = "75 Buell Court",
        ImgId = 1,
        Gender = "F",

                },
                    new()
                    { TeamId = 2,

        FullName = "Berk Uttley",
        JobTitle = "Health Coach IV",
        Country = "FR",
        IsOnline = false,
        Rating =  4,
        Target = 58,
        Budget = 82064,
        Phone = "(200) 2124940",
        Address = "4 Mockingbird Trail",
        ImgId = 8,
        Gender = "M",

                },
                    new()
                    { TeamId = 4,

        FullName = "Kenny Clackers",
        JobTitle = "Assistant Manager",
        Country = "FR",
        IsOnline = true,
        Rating =  4,
        Target = 37,
        Budget = 47477,
        Phone = "(926) 3235464",
        Address = "53315 Bashford Lane",
        ImgId = 2,
        Gender = "M",

                },
                    new()
                    { TeamId = 1,

        FullName = "Rickard Pingston",
        JobTitle = "Sales Representative",
        Country = "BR",
        IsOnline = true,
        Rating =  5,
        Target = 72,
        Budget = 94173,
        Phone = "(902) 4658383",
        Address = "8 Mesta Court",
        ImgId = 2,
        Gender = "M",

                },
                    new()
                    { TeamId = 4,

        FullName = "Hobard Clabburn",
        JobTitle = "Sales Representative",
        Country = "BR",
        IsOnline = true,
        Rating =  2,
        Target = 37,
        Budget = 66166,
        Phone = "(711) 6587550",
        Address = "29796 Mcbride Court",
        ImgId = 4,
        Gender = "M",

                },
                    new()
                    { TeamId = 2,

        FullName = "Uri Champken",
        JobTitle = "Software Test Engineer IV",
        Country = "BR",
        IsOnline = false,
        Rating =  1,
        Target = 39,
        Budget = 65176,
        Phone = "(514) 1953919",
        Address = "78 Rowland Alley",
        ImgId = 6,
        Gender = "M",

                },
                    new()
                    { TeamId = 1,

        FullName = "Obidiah Fold",
        JobTitle = "Budget/Accounting Analyst I",
        Country = "FR",
        IsOnline = false,
        Rating =  5,
        Target = 66,
        Budget = 74529,
        Phone = "(747) 8711780",
        Address = "58 Lakeland Court",
        ImgId = 9,
        Gender = "M",

                },
                    new()
                    { TeamId = 2,

        FullName = "Angelia Marconi",
        JobTitle = "Associate Professor",
        Country = "FR",
        IsOnline = false,
        Rating =  4,
        Target = 91,
        Budget = 38996,
        Phone = "(530) 7506861",
        Address = "7 Ohio Parkway",
        ImgId = 2,
        Gender = "F",

                },
                    new()
                    { TeamId = 3,

        FullName = "Ronda Lock",
        JobTitle = "Quality Engineer",
        Country = "US",
        IsOnline = false,
        Rating =  5,
        Target = 36,
        Budget = 69903,
        Phone = "(916) 6819628",
        Address = "802 American Ash Street",
        ImgId = 6,
        Gender = "F",

                },
                    new()
                    { TeamId = 4,

        FullName = "Rachele Fantham",
        JobTitle = "Business Systems Analyst",
        Country = "FR",
        IsOnline = true,
        Rating =  2,
        Target = 100,
        Budget = 79333,
        Phone = "(652) 3112938",
        Address = "62 Grim Center",
        ImgId = 4,
        Gender = "F",

                },
                    new()
                    { TeamId = 4,

        FullName = "Emanuel Deery",
        JobTitle = "Sales Representative",
        Country = "BR",
        IsOnline = false,
        Rating =  3,
        Target = 93,
        Budget = 77477,
        Phone = "(860) 8318923",
        Address = "850 Mifflin Junction",
        ImgId = 8,
        Gender = "M",

                },
                    new()
                    { TeamId = 4,

        FullName = "Clay Ellins",
        JobTitle = "Design Engineer",
        Country = "US",
        IsOnline = true,
        Rating =  4,
        Target = 98,
        Budget = 4120,
        Phone = "(682) 4688237",
        Address = "458 Scoville Lane",
        ImgId = 5,
        Gender = "M",

                },
                    new()
                    { TeamId = 4,

        FullName = "Bettina Menlove",
        JobTitle = "Senior Financial Analyst",
        Country = "FR",
        IsOnline = false,
        Rating =  5,
        Target = 78,
        Budget = 80574,
        Phone = "(293) 8801412",
        Address = "29 Onsgard Junction",
        ImgId = 8,
        Gender = "F",

                },
                    new()
                    { TeamId = 2,

        FullName = "Claiborne Willoughey",
        JobTitle = "Food Chemist",
        Country = "US",
        IsOnline = true,
        Rating =  5,
        Target = 44,
        Budget = 44673,
        Phone = "(707) 3380798",
        Address = "39114 Killdeer Terrace",
        ImgId = 6,
        Gender = "M",

                },
                    new()
                    { TeamId = 3,

        FullName = "Desmond Gritskov",
        JobTitle = "Pharmacist",
        Country = "BR",
        IsOnline = false,
        Rating =  4,
        Target = 66,
        Budget = 45319,
        Phone = "(412) 1336481",
        Address = "6912 Farwell Street",
        ImgId = 6,
        Gender = "M",

                },
                    new()
                    { TeamId = 2,

        FullName = "Codee Maybery",
        JobTitle = "Clinical Specialist",
        Country = "US",
        IsOnline = true,
        Rating =  2,
        Target = 26,
        Budget = 43462,
        Phone = "(682) 7969803",
        Address = "4 Tennessee Plaza",
        ImgId = 3,
        Gender = "F",

                },
                    new()
                    { TeamId = 3,

        FullName = "Denys Beynke",
        JobTitle = "Occupational Therapist",
        Country = "BR",
        IsOnline = true,
        Rating =  4,
        Target = 60,
        Budget = 32402,
        Phone = "(110) 4341370",
        Address = "99 Trailsway Park",
        ImgId = 4,
        Gender = "M",

                },
                    new()
                    { TeamId = 2,

        FullName = "Guthry Limpricht",
        JobTitle = "Geologist II",
        Country = "DE",
        IsOnline = true,
        Rating =  3,
        Target = 65,
        Budget = 68462,
        Phone = "(100) 8946768",
        Address = "3117 Commercial Crossing",
        ImgId = 2,
        Gender = "M",

                },
                    new()
                    { TeamId = 3,

        FullName = "Cammie Knoble",
        JobTitle = "Community Outreach Specialist",
        Country = "GB",
        IsOnline = false,
        Rating =  2,
        Target = 1,
        Budget = 70198,
        Phone = "(352) 1663192",
        Address = "55 Longview Place",
        ImgId = 4,
        Gender = "F",

                },
                    new()
                    { TeamId = 3,

        FullName = "Kiri Espinal",
        JobTitle = "Accounting Assistant I",
        Country = "FR",
        IsOnline = false,
        Rating =  3,
        Target = 47,
        Budget = 3712,
        Phone = "(946) 6686147",
        Address = "90480 Chinook Drive",
        ImgId = 4,
        Gender = "F",

                },
                    new()
                    { TeamId = 3,

        FullName = "Joy Tiddy",
        JobTitle = "Engineer III",
        Country = "FR",
        IsOnline = true,
        Rating =  5,
        Target = 80,
        Budget = 61355,
        Phone = "(849) 1097790",
        Address = "76 Summerview Hill",
        ImgId = 9,
        Gender = "F",

                },
                    new()
                    { TeamId = 1,

        FullName = "Arlene Karlsson",
        JobTitle = "Civil Engineer",
        Country = "BR",
        IsOnline = true,
        Rating =  4,
        Target = 98,
        Budget = 14267,
        Phone = "(699) 4713080",
        Address = "90 Dorton Point",
        ImgId = 5,
        Gender = "F",

                },
                    new()
                    { TeamId = 2,

        FullName = "Melony Millwater",
        JobTitle = "Sales Representative",
        Country = "US",
        IsOnline = true,
        Rating =  2,
        Target = 27,
        Budget = 67126,
        Phone = "(352) 5197697",
        Address = "65242 Derek Place",
        ImgId = 1,
        Gender = "F",

                },
                    new()
                    { TeamId = 2,

        FullName = "Mab Ballham",
        JobTitle = "Sales Representative",
        Country = "FR",
        IsOnline = false,
        Rating =  1,
        Target = 34,
        Budget = 65648,
        Phone = "(699) 9285470",
        Address = "2579 Messerschmidt Crossing",
        ImgId = 8,
        Gender = "F",

                },
                    new()
                    { TeamId = 2,

        FullName = "Nixie MacAskie",
        JobTitle = "Structural Analysis Engineer",
        Country = "BR",
        IsOnline = true,
        Rating =  2,
        Target = 13,
        Budget = -5312,
        Phone = "(434) 6153212",
        Address = "59672 Village Court",
        ImgId = 4,
        Gender = "F",

                },
                    new()
                    { TeamId = 1,

        FullName = "Gianni Crafts",
        JobTitle = "Tax Accountant",
        Country = "FR",
        IsOnline = false,
        Rating =  3,
        Target = 54,
        Budget = 85744,
        Phone = "(428) 3135618",
        Address = "53766 Buhler Parkway",
        ImgId = 8,
        Gender = "M",

                },
                    new()
                    { TeamId = 1,

        FullName = "Moyra Summerlie",
        JobTitle = "Business Systems Analyst",
        Country = "FR",
        IsOnline = true,
        Rating =  5,
        Target = 3,
        Budget = 19109,
        Phone = "(960) 7792763",
        Address = "127 Spohn Crossing",
        ImgId = 6,
        Gender = "F",

                },
                    new()
                    { TeamId = 3,

        FullName = "Hagan Trevers",
        JobTitle = "Sales Representative",
        Country = "FR",
        IsOnline = false,
        Rating =  2,
        Target = 93,
        Budget = 28290,
        Phone = "(749) 8913157",
        Address = "516 Clove Road",
        ImgId = 7,
        Gender = "M",

                },
                    new()
                    { TeamId = 3,

        FullName = "Sela Westmacott",
        JobTitle = "Account Executive",
        Country = "BR",
        IsOnline = false,
        Rating =  3,
        Target = 29,
        Budget = 58239,
        Phone = "(130) 9778509",
        Address = "81 Maple Point",
        ImgId = 2,
        Gender = "F",

                },
                    new()
                    { TeamId = 2,

        FullName = "Lilia Wiz",
        JobTitle = "VP Product Management",
        Country = "FR",
        IsOnline = false,
        Rating =  1,
        Target = 65,
        Budget = 1438,
        Phone = "(418) 5940094",
        Address = "905 Hauk Point",
        ImgId = 1,
        Gender = "F",

                },
                    new()
                    { TeamId = 1,

        FullName = "Orlan MacAlpin",
        JobTitle = "Statistician I",
        Country = "US",
        IsOnline = false,
        Rating =  1,
        Target = 1,
        Budget = 9094,
        Phone = "(512) 7106617",
        Address = "6055 Truax Way",
        ImgId = 2,
        Gender = "M",

                },
                    new()
                    { TeamId = 2,

        FullName = "Ty Nutton",
        JobTitle = "Speech Pathologist",
        Country = "FR",
        IsOnline = false,
        Rating =  5,
        Target = 88,
        Budget = 76684,
        Phone = "(250) 2530424",
        Address = "37247 Merry Plaza",
        ImgId = 1,
        Gender = "M",

                },
                    new()
                    { TeamId = 1,

        FullName = "Mirelle Jandl",
        JobTitle = "Civil Engineer",
        Country = "DE",
        IsOnline = true,
        Rating =  3,
        Target = 19,
        Budget = 94486,
        Phone = "(871) 7917453",
        Address = "31 Anderson Hill",
        ImgId = 10,
        Gender = "F",

                },
                    new()
                    { TeamId = 4,

        FullName = "Diann Bertram",
        JobTitle = "Structural Engineer",
        Country = "BR",
        IsOnline = true,
        Rating =  2,
        Target = 38,
        Budget = 2769,
        Phone = "(716) 9445650",
        Address = "958 Swallow Drive",
        ImgId = 4,
        Gender = "F",

                },
                    new()
                    { TeamId = 1,

        FullName = "Cindra Slobom",
        JobTitle = "Web Designer III",
        Country = "BR",
        IsOnline = true,
        Rating =  5,
        Target = 48,
        Budget = 81624,
        Phone = "(409) 9223432",
        Address = "82525 Northridge Junction",
        ImgId = 1,
        Gender = "F",

                },
                    new()
                    { TeamId = 2,

        FullName = "Tymon Mattheissen",
        JobTitle = "Dental Hygienist",
        Country = "FR",
        IsOnline = false,
        Rating =  2,
        Target = 51,
        Budget = 42972,
        Phone = "(724) 3234885",
        Address = "64363 Anzinger Plaza",
        ImgId = 3,
        Gender = "M",

                },
                    new()
                    { TeamId = 4,

        FullName = "Fancie Heighton",
        JobTitle = "Paralegal",
        Country = "FR",
        IsOnline = true,
        Rating =  5,
        Target = 52,
        Budget = 67403,
        Phone = "(738) 9982239",
        Address = "4353 Hermina Junction",
        ImgId = 1,
        Gender = "F",

                },
                    new()
                    { TeamId = 4,

        FullName = "Kit Utteridge",
        JobTitle = "Office Assistant I",
        Country = "FR",
        IsOnline = true,
        Rating =  4,
        Target = 93,
        Budget = 36268,
        Phone = "(710) 2371400",
        Address = "46806 Moland Center",
        ImgId = 7,
        Gender = "F",

                },
                    new()
                    { TeamId = 3,

        FullName = "Lea Willey",
        JobTitle = "VP Quality Control",
        Country = "US",
        IsOnline = false,
        Rating =  3,
        Target = 19,
        Budget = 54614,
        Phone = "(304) 3327700",
        Address = "1 Moland Crossing",
        ImgId = 6,
        Gender = "F",

                },
                    new()
                    { TeamId = 1,

        FullName = "Arri Halton",
        JobTitle = "Staff Accountant II",
        Country = "GB",
        IsOnline = true,
        Rating =  5,
        Target = 73,
        Budget = 32500,
        Phone = "(743) 8449571",
        Address = "3 Starling Trail",
        ImgId = 3,
        Gender = "M",

                },
                    new()
                    { TeamId = 2,

        FullName = "Malva Pierpoint",
        JobTitle = "Operator",
        Country = "US",
        IsOnline = true,
        Rating =  4,
        Target = 98,
        Budget = 20312,
        Phone = "(423) 8195288",
        Address = "57584 Algoma Plaza",
        ImgId = 1,
        Gender = "F",

                },
                    new()
                    { TeamId = 2,

        FullName = "Dalston Sabben",
        JobTitle = "Social Worker",
        Country = "BR",
        IsOnline = true,
        Rating =  4,
        Target = 85,
        Budget = 99048,
        Phone = "(388) 2523908",
        Address = "53578 Clove Lane",
        ImgId = 4,
        Gender = "M",

                },
                    new()
                    { TeamId = 3,

        FullName = "Delinda Margrie",
        JobTitle = "Financial Advisor",
        Country = "US",
        IsOnline = false,
        Rating =  1,
        Target = 1,
        Budget = 8398,
        Phone = "(702) 6480692",
        Address = "9 Dapin Plaza",
        ImgId = 9,
        Gender = "F",

                },
                    new()
                    { TeamId = 3,

        FullName = "Meggi Westman",
        JobTitle = "Librarian",
        Country = "US",
        IsOnline = true,
        Rating =  3,
        Target = 64,
        Budget = 63413,
        Phone = "(682) 3495155",
        Address = "82 Duke Terrace",
        ImgId = 7,
        Gender = "F",

                },
                    new()
                    { TeamId = 4,

        FullName = "Bret Barnsdall",
        JobTitle = "Registered Nurse",
        Country = "BR",
        IsOnline = true,
        Rating =  3,
        Target = 52,
        Budget = 55153,
        Phone = "(222) 2089814",
        Address = "4 Corry Park",
        ImgId = 8,
        Gender = "M",

                },
                    new()
                    { TeamId = 4,

        FullName = "Matthus Shyres",
        JobTitle = "Marketing Manager",
        Country = "FR",
        IsOnline = false,
        Rating =  3,
        Target = 68,
        Budget = 33697,
        Phone = "(539) 9486139",
        Address = "460 Norway Maple Junction",
        ImgId = 1,
        Gender = "M",

                }
        };

            for (int i = 0; i < Employees.Count; i++)
            {
                Employees[i].Id = i + 1;
            }
        }

        return Employees;
    }

    public IEnumerable<Sale> GetSales()
    {
        if (Sales == null)
        {
            Sales = new List<Sale>();

            var physicalPath = Path.Combine(WebHostEnvironment.WebRootPath, "assets", "sales_data.json");
            using (StreamReader r = new StreamReader(physicalPath))
            {
                string json = r.ReadToEnd();
                Sales = JsonSerializer.Deserialize<List<Sale>>(json);
            }
        }

        return Sales!;
    }
}
