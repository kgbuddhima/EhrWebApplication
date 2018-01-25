using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.BLLInterfaces;
using BusinessEntity;

namespace BLL.BLLDocuments
{
    public class PatientDocument : IPatientDocument
    {
        /// <summary>
        /// Deactivate patient
        /// </summary>
        /// <param name="patientId"></param>
        /// <returns></returns>
        public bool DeletePatient(int patientId)
        {
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }

        /// <summary>
        /// Get patient by PatientId or PIn
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Patient GetPatient(string value)
        {
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        /// <summary>
        /// Get patient by PatientId
        /// </summary>
        /// <param name="patientId"></param>
        /// <returns></returns>
        public Patient GetPatientById(int patientId)
        {
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        /// <summary>
        /// Get patient by PIN
        /// </summary>
        /// <param name="pin"></param>
        /// <returns></returns>
        public Patient GetPatientByPin(string pin)
        {
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        /// <summary>
        /// Get Patient Collection
        /// </summary>
        /// <returns></returns>
        public List<Patient> GetPatientCollection()
        {
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        /// <summary>
        /// Insert/Update patinet and return full atient objact
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        public Patient SavePatient(Patient patient)
        {
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }
    }
}
