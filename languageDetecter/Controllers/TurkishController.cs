using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using languageDetecter.Helper;

namespace languageDetecter.Controllers
{
    public class TurkishController : Controller
    {
        // GET: Turkish
        public ActionResult Index()
        {
            string sql = "Select * from Languages";
            ViewBag.Diller = DapperOrm.Get<Languages>(sql);
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Word, int diller)
        {
            string sql = "Select * from Languages";
            ViewBag.Diller = DapperOrm.Get<Languages>(sql);

           
            string[] kelimeler = Word.Split('\n','\r');

            

            int adet = kelimeler.Length;

            for (int i = 0; i < adet; i++)
            {
                if (kelimeler[i] != "")
                {
                    var test = kelimeler[i];
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@Word",test);
                    param.Add("@LanguagesId", diller);
                    string sqlinsert = $"insert into İ (Word,LanguagesId) values (@Word,@LanguagesId)";
                    try
                    {
                        ViewBag.succes = "İşlem Başarılı";
                        DapperOrm.InsertUpdate<A>(sqlinsert, param);
                        

                    }
                    catch (Exception)
                    {

                        throw;
                    }



                }
                
            }

            


            return View();
        }

    }
}