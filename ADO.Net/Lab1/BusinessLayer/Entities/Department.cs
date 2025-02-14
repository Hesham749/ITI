﻿using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ClsDepartment
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Desc { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int? Dept_Manager { get; set; }
        public DateOnly? Manager_hireDate { get; set; }

        public override string ToString()
        {
            return $"ID : {Id} , Name : {Name,-5} , Description : {Desc , -20} , Location : {Location , -10} {((Dept_Manager is null) ? "" : $", Department Manager Id : {Dept_Manager , -20}")}{((Manager_hireDate is null) ? "" : $", Manager Hire Date : {Manager_hireDate}")}";
        }
    }
}
