using Labb3AnropNy.Data;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Labb3AnropNy
{

    public class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Start();

            using SchoolContext db = new SchoolContext();
        }
    }

}
/* Mna sql querys
 --Se Alla anställda/en kategori (advisor) 
Select * from EmploAdmin
Select * from EmploOther
Select * from EmploTeacher

SELECT * FROM EmploAdmin
WHERE Position='Advisor'

--lista med alla betyg som satts senaste månaden där elevens namn, kursens namn och betyget framgår.
SELECT s.Fname, s.Lname, g.Subject, g.Grade
FROM Student s
Join Grade g on s.StudId = g.FK_StudId
Where Date Between '2022-12-01' and '2022-12-31'

--Lista med alla kurser och det snittbetyg som eleverna fått på den kursen samt det högsta och lägsta betyget som någon fått i kursen 
Select Subject, max(Grade)' Högsta', min(Grade)'Lägsta', Avg(Grade)'Snitt' 
From Grade
Group By Subject


--Lägga till ny elev
INSERT INTO Student
(StudId, SSN, Fname, Lname, FK_ClassId, Class)
VALUES
(7,'20080513-4724', 'Johan', 'Lindblom', 601, '3A')*/