using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessEntity;
using EhrWeb.Models;

namespace EhrWeb.ViewModels
{
    public static class Mappings
    {
        /// <summary>
        /// Map Patient ModelPatient
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static Patient MapPatient(PatientModel model)
        {
            if (model == null) { return null; }
            Patient patient = null;
            try
            {
                patient = new Patient()
                {
                    ID = model.ID,
                    PatientId = model.PatientId,
                    PatientName = model.PatientName,
                    Birthday = model.Birthday,
                    Gender = model.Gender,
                    IsActive = model.IsActive,
                    JoinedDate = model.JoinedDate,
                    NIC = model.NIC,
                    PIN = model.PIN,
                    UpdatedDate = model.UpdatedDate
                };
                MapAddress(patient, model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return patient;
        }

        /// <summary>
        /// Map Patient to PatientModel
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        public static PatientModel MapPatient(Patient patient)
        {
            if (patient==null) { return null; }
            PatientModel model = null;
            try
            {
                model = new PatientModel()
                {
                    ID = model.ID,
                    PatientId = model.PatientId,
                    PatientName = model.PatientName,
                    Birthday = model.Birthday,
                    Gender = model.Gender,
                    IsActive = model.IsActive,
                    JoinedDate = model.JoinedDate,
                    NIC = model.NIC,
                    PIN = model.PIN,
                    UpdatedDate = model.UpdatedDate
                };
                MapAddress(model, patient);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return model;
        }

        /// <summary>
        /// Map Patient.Address to PatientModel.Address Model
        /// </summary>
        /// <param name="model"></param>
        /// <param name="patient"></param>
        public static void MapAddress(PatientModel model, Patient patient)
        {
            try
            {
                if (patient == null) { return; }
                model.Address = new AddressModel();
                model.Address.AddressId = patient.Address.AddressId;
                model.Address.AddressL1 = patient.Address.AddressL1;
                model.Address.AddressL2 = patient.Address.AddressL2;
                model.Address.AddressL3 = patient.Address.AddressL3;
                model.Address.City = patient.Address.City;
                model.Address.Country = patient.Address.Country;
                model.Address.PostCode = patient.Address.Country;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Map PatientModel.Address tp PatientAddress
        /// </summary>
        /// <param name="patient"></param>
        /// <param name="model"></param>
        public static void MapAddress(Patient patient,PatientModel model)
        {
            try
            {
                if (model == null) { return; }
                patient.Address = new Address();
                patient.Address.AddressId = model.Address.AddressId;
                patient.Address.AddressL1 = model.Address.AddressL1;
                patient.Address.AddressL2 = model.Address.AddressL2;
                patient.Address.AddressL3 = model.Address.AddressL3;
                patient.Address.City = model.Address.City;
                patient.Address.Country = model.Address.Country;
                patient.Address.PostCode = model.Address.Country;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}