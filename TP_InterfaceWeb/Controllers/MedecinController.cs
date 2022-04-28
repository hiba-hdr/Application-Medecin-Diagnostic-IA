using KnnLibrary;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;
using TP_InterfaceWeb.Security;

namespace TP_InterfaceWeb.Controllers
{
    public class MedecinController : Controller
    {
        private Models.MedecinDbContext db = new Models.MedecinDbContext();
        private SecurityManager securityManager = new SecurityManager();


        public IActionResult Index()
        {

            return View();
        }

        

        [HttpPost]
        public IActionResult Index(string username, string password)
        {

            List<Models.NewAccount> accounts = db.NewAccounts.ToList();
           

            var account = processLogin(username, password);
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || account == null)
            {
                ViewBag.error = "Invalid";
                return View("Index");
            }
            else
            {
                
                securityManager.SignIn(this.HttpContext, account);
                return RedirectToAction("Login2");
            }
            return View(accounts);

        }

        private Models.NewAccount processLogin(string username, string password)
        {
            var account1 = db.NewAccounts.SingleOrDefault(a => a.UserName.Equals(username));
            var account2 = db.NewAccounts.SingleOrDefault(a => a.Password.Equals(password) );

            if (account1 != null)
                        {
                            if (account2 != null)
                            {
                               
                                return account1;
                            }

                        }
                
            
            return null;
           
        }

        public IActionResult Login2()
        {

            return View();
        }

        public IActionResult Infomedecin2(string name)
        {

            var myUser = db.NewAccounts.SingleOrDefault(user => user.UserName == name);

            return View("Infomedecin2", myUser);
        }

        [HttpPost]
        public IActionResult Infomedecin2(Models.NewAccount newAccount)
        {

            db.Entry(newAccount).State = EntityState.Added;
            db.SaveChanges();
            

            return View();
        }

        public IActionResult AccessDenied()
        {
            return View("AccessDenied");
        }

        public IActionResult SignOut()
        {
            securityManager.SignOut(this.HttpContext);
            return RedirectToAction("Index");
        }

        public IActionResult Login(Models.NewAccount newAccount)
        {
            

            db.NewAccounts.Add(newAccount);
            db.SaveChanges();

            //return View(newAccount);

            //Models.MedecinDbContext db = new Models.MedecinDbContext();
            List<Models.NewAccount> accounts = db.NewAccounts.ToList();
            return View(accounts);
        }


        [HttpGet]
        public IActionResult NewAccountView()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewAccountView(Models.NewAccount newAccount)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Login", newAccount);
            }

            return View();

        }


        public IActionResult Infomedecin()
        {

            List<Models.NewAccount> accounts = db.NewAccounts.ToList();
            return View(accounts);
        }



       
        public ActionResult Modify(int id)
        {
           
            var newAccount = db.NewAccounts.Find(id);
            return View("Modify", newAccount);
        }

        [HttpPost]
        public ActionResult Modify(Models.NewAccount newAccount )
        {

            db.Entry(newAccount).State = EntityState.Modified;
            db.SaveChanges();
            if (ModelState.IsValid)
            {
                
                return RedirectToAction("Infomedecin", newAccount);
            }
            

            return View();
            
            

            
           
        }

     
        public IActionResult Diagnostic()
        {
            


            List<Models.AjoutPatient> patients = db.AjoutPatients.ToList();
            
            //if (ModelState.IsValid)
            //{

            //    return View("Diagnostic", patients);
            //}

            return View(patients);
        }




        public IActionResult PatientAjoute(Models.AjoutPatient newPatient)
        {
            

            List<Models.AjoutPatient> patients = db.AjoutPatients.ToList();

           
            return View(patients);

        }



        [HttpGet]
        public IActionResult AjoutPatient()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AjoutPatient(Models.AjoutPatient newPatient)
        {
            if (ModelState.IsValid)
            {
                db.AjoutPatients.Add(newPatient);
                db.SaveChanges();
                return RedirectToAction("PatientAjoute", newPatient);
            }

            return View();

        }

        public IActionResult Infopatient(int id)
        {

            var myUser = db.AjoutPatients.Find(id);

            return View("Infopatient", myUser);
        }

        [HttpPost]
        public IActionResult Infopatient(Models.AjoutPatient newPatient)
        {

            db.Entry(newPatient).State = EntityState.Unchanged;
            db.SaveChanges();


            return View();
        }




        public IActionResult SupprimerPatient()
        {


            return View("SupprimerPatient");
        }



        [HttpPost, ActionName("SupprimerPatient")]
        [ValidateAntiForgeryToken]
        public IActionResult SupprimerPatient(int id, Models.AjoutPatient patient)
        {
            db.AjoutPatients.Remove(db.AjoutPatients.Find(id));
            db.SaveChanges();
            return RedirectToAction("PatientAjoute", patient);
        }




        public IActionResult DiagnostiquerPatient(int id)
        {
            KNN knn = new KNN();
            var myUser = db.AjoutPatients.Find(id);

            foreach (Diagnostic diag in knn.ImportAllSamples("test.csv"))
            {
                if (diag.CP == 0.0F && diag.CA == 1.0 && diag.OldPeak == 2.0F && diag.Thal == 3.0F)
                {
                    ViewBag.Sample = knn.Predict(diag);
                }
            }

            return View("DiagnostiquerPatient", myUser);
        }

        [HttpPost]
        public IActionResult DiagnostiquerPatient(Models.AjoutPatient patient)
        {
            db.Entry(patient).State = EntityState.Modified;
            db.SaveChanges();


            return View();
        }


    }
}
