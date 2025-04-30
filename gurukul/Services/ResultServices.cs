using gurukul.Database;
using gurukul.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace gurukul.Services
{
    public class ResultServices
    {

        public ResultModel getresult(Models.ResultModel model, int i)
        {
            using (var db = new SangliResultEntities())
            {

                var eve = db.Results.FirstOrDefault(x => x.Taluka == model.Taluka && x.rollnumber == model.rollnumber && x.Dist == model.dist && x.standard == model.standard);
                if (eve == null)
                    model = null;
            }

            return model;
        }

        public SearchResultModel getresult(Models.ResultModel model)
        {
            SearchResultModel model1 = null;
            using (var db = new SangliResultEntities())
            {

                var result = db.Results.FirstOrDefault(x => x.Taluka == model.Taluka && x.rollnumber == model.rollnumber && x.Dist == model.dist && x.standard == model.standard);
                if (result != null)
                {
                    if (model.standard == 1 || model.standard == 2)
                    {
                        model1 = new SearchResultModel()
                        {
                            Name = result.Name,
                            rollnumber = (int)result.rollnumber,
                            barcode1 = result.barcode1,
                            barcode2 = result.barcode2,
                            Correctans1 = (int)result.correctans1,
                            Marks1 = (int)result.marks1,
                            Marks2=0,
                            schoolname = result.SchoolName,
                        
                            Taluka = result.Taluka,
                            dist = result.Dist,
                            standard = (int)result.standard,
                            //DistaRank = (int)result.distrank,
                            //TalukaRank = (int)result.talukarank,
                            //StateRank = (int)result.staterank,
                            Percentage = (double)result.percentage,
                            Total = (int)result.total
                        };
                    }
                    else
                    {
                        model1 = new SearchResultModel()
                        {
                            Name = result.Name,
                            rollnumber = (int)result.rollnumber,
                            barcode1 = result.barcode1,
                            barcode2 = result.barcode2,
                            Correctans1 = (int)result.correctans1,
                            Correctans2 = (int)result.correctans2,
                            Marks1 = (int)result.marks1,
                            Marks2 = (int)result.marks2,
                            schoolname = result.SchoolName,
                          
                            Taluka = result.Taluka,
                            dist = result.Dist,
                            standard = (int)result.standard,
                            DistaRank = (int)result.distrank,
                            TalukaRank = (int)result.talukarank,
                            StateRank = (int)result.staterank,
                            Percentage = (double)result.percentage,
                            Total = (int)result.total
                        };
                    }

                }
            }

            return model1;
        }

        internal object GetDistricts(string language)
        {
            try
            {
                using (var db = new SangliResultEntities())
                {
                    if (language == "Marathi")
                    {
                        var list = db.Results.Select(x => x.Dist).Distinct().ToList();
                        return list;
                    }
                    else
                    {
                        var list = new List<string>();
                        list.Add("eNGdIST1");
                        list.Add("eNGdIST2");
                        list.Add("eNGdIST3");
                        return list;
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.InnerException;
            }
        }

        internal object GetTaluka(string language, string district)
        {
            try
            {
                using (var db = new SangliResultEntities())
                {
                    if (language == "Marathi")
                    {
                        var list = db.Results.Where(x => x.Dist == district).Select(x => x.Taluka).Distinct().ToList();
                        return list;
                    }
                    else
                    {
                        var list = new List<string>();
                        list.Add("eNGdIST1");
                        list.Add("eNGdIST2");
                        list.Add("eNGdIST3");
                        return list;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}