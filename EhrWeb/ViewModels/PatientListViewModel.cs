﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EhrWeb.Models;
using BusinessEntity;

namespace EhrWeb.ViewModels
{
    public class PatientListViewModel
    {
        public List<Patient> PatientCollection { get; set; }
    }
}