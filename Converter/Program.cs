using System;
using System.Linq;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var Websitedb = new WebsiteEntities())
                using (var Applicationdb = new OMRFinalEntities())
                {
                    int count = 0;
                    var list = Applicationdb.tblRNBEngs.ToList().Where(x=> x.StandardId == 4 || x.StandardId == 7);
                    var studentList = Applicationdb.tblStudentInfoEngs.ToList();
                    foreach (var item in list)
                    {
                        count++;
                        Console.WriteLine(count);
                        Result fr = new Result();
                        var student = studentList.FirstOrDefault(x => x.Id == item.StudentId);
                        if (student == null)
                            continue;
                        fr.Name = student.Name;
                        //fr.Address = student.Address;
                        fr.SchoolName = student.tblSchoolListEng.SchoolName;
                        //fr.Village = student.VillageName;

                        fr.Dist = student.tblSchoolListEng.tblVillagesEng.tblTalukaEng.tblDistrictEng.Name;
                        fr.Taluka = student.tblSchoolListEng.tblVillagesEng.tblTalukaEng.TalukaName;
                        fr.standard = student.tblStandardEng.ID;

                        fr.barcode1 = Convert.ToString(item.Barcode1);
                        fr.barcode2 = Convert.ToString(item.Barcode2);
                        fr.rollnumber = item.RollNumber;
                        fr.DateOfBirth = student.DateofBirth;
                        var correctAns = Applicationdb.tblMarksEngs.FirstOrDefault(x => x.StudentId == student.Id);
                        if (correctAns != null)
                        {
                            fr.correctans1 = correctAns.correctAns1;
                            fr.correctans2 = correctAns.correctAns2;
                            fr.marks1 = correctAns.Mark1;
                            fr.marks2 = correctAns.Mark2;
                            fr.total = correctAns.Mark1 + correctAns.Mark2;

                            if (correctAns.Standard == 1 || correctAns.Standard == 2)
                            {
                                fr.percentage = Math.Round(((double)fr.total / 100) * 100, 2);
                            }
                            else
                            {
                                fr.percentage = Math.Round(((double)fr.total / 300) * 100, 2);
                            }

                            // fr.Result = (correctAns.Mark1 >= 60 && correctAns.Mark2 >= 60) ? "PASS" : "FAIL";
                            fr.talukarank = correctAns.SubDistR;
                            fr.distrank = correctAns.DistrictR;
                            fr.staterank = correctAns.StateRank;
                            Websitedb.Results.Add(fr);
                        }
                    }
                    Websitedb.SaveChanges();
                }


            }
            catch (Exception ex)
            {

            }

        }

    }
}
