﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RCCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace RCCWebApi.Models
{
    public partial interface IrasdbContextProcedures
    {
        Task<List<usp_RIT_getCustomersOrdersByDateMobileResult>> usp_RIT_getCustomersOrdersByDateMobileAsync(DateTime? order_date, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
