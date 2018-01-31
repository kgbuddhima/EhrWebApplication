using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EhrWeb.Models;
using EhrWeb.ViewModels;
using BLL.BLLDocuments;
using BLL.BLLInterfaces;
using BusinessEntity;
using Utility;
using System.Web.Http;

namespace EhrWeb.Controllers
{
    public class PatientController : Controller
    {
        IPatientDocument _document = new PatientDocument();

        // GET: Patient
        [System.Web.Http.HttpPost]
        public ActionResult Patient([FromBody]int? usertype)
        {
            try
            {
                int patientId = UtilityLibrary.GetValueInt(Session["UserID"], 0);
                PatientModel model = new PatientModel();
                if (usertype == (int)CommonUnit.UserType.Patient)
                {
                    Patient result = _document.GetPatientById(patientId);
                    model = Mappings.MapPatient(result);
                    return View("Patient", model);
                }
                else if (usertype == (int)CommonUnit.UserType.Patient)
                {
                    return View("Patient", model);
                }
                else
                {
                    ViewBag.Error = "User type is invalid !";
                    return RedirectToAction("Login", "Login", CommonUnit.UserType.Staff);
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "User type is invalid !";
                return RedirectToAction("Login", "Login", CommonUnit.UserType.Staff);
            }
        }

        // GET: Patient/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [System.Web.Http.HttpPost]
        public ActionResult Details(int id, FormCollection collection)
        {
            return View();
        }

        // GET: Patient/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Patient/Save
        [System.Web.Http.HttpPost]
        public ActionResult Save(PatientModel patientModel)
        {
            try
            {
                Patient patient = _document.SavePatient(Mappings.MapPatient(patientModel));
                PatientModel model = Mappings.MapPatient(patient);
                return View("Patient", model);
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Patient/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // POST: Patient/Edit/5
        [System.Web.Http.HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Patient patient = _document.GetPatientById(id);
                PatientModel model = Mappings.MapPatient(patient);
                return View("Patient", model);

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // GET: Patient/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        // POST: Patient/Delete/5
        [System.Web.Http.HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                bool deleted = _document.DeletePatient(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //// GET: Patient/GetCollection
        //public ActionResult PatientList()
        //{
        //    try
        //    {
        //        List<Patient> col = new List<BusinessEntity.Patient>(); //_document.GetPatientCollection();
        //        col.Add(new Patient());
        //        col.Add(new Patient());
        //        col.Add(new Patient());
        //        PatientListViewModel model = new PatientListViewModel();
        //        model.PatientCollection = col;
        //        return View("PatientList",col.ToList());
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}
    }
}
