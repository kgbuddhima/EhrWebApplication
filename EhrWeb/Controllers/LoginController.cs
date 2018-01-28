using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using BLL.BLLDocuments;
using BLL.BLLInterfaces;
using EhrWeb.Models;
using EhrWeb.ViewModels;
using Utility;

namespace EhrWeb.Controllers
{
    public class LoginController : Controller
    {
        IPatientDocument _document = new PatientDocument();

        public ActionResult Index()
        {
            ViewBag.Title = "Kingston EHR Solutions (Pvt) Ltd";
            return View("UserType");
        }

        public ActionResult SelectUserType(int? usertype)
        {
            if (UtilityLibrary.GetValueInt(usertype, 0) > 0)
            {
                UserModel model = new UserModel();
                model.UserType = (int)usertype == 1 ? CommonUnit.UserType.Staff : CommonUnit.UserType.Patient;
                model.UserTypeDsc = model.UserType.ToString();
                return View("Login", model);
            }
            else return View("Index");
        }

        public ActionResult Login(UserModel user)
        {
            if (user != null)
            {
                int userID = _document.CheckLogin(Mappings.MapCredentials(user));
                if (userID > 0)
                {
                    PatientModel patient = new PatientModel();
                    /*if (user.UserType== CommonUnit.UserType.Patient)
                    {
                        BusinessEntity.Patient result = _document.GetPatientById(userID);
                        if (result!=null)
                        {
                            patient = Mappings.MapPatient(result);
                        }
                    }*/
                    return View("Patient", "Patient", patient);
                }
                else
                {
                    ViewBag.Error = "Username or password are not correct";
                    return View("Login");
                }
            }
            else
            {
                return View("Index");
            }
        }
    }
}
