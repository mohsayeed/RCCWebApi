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
    public partial class rasdbContext
    {
        private IrasdbContextProcedures _procedures;

        public virtual IrasdbContextProcedures Procedures
        {
            get
            {
                if (_procedures is null) _procedures = new rasdbContextProcedures(this);
                return _procedures;
            }
            set
            {
                _procedures = value;
            }
        }

        public IrasdbContextProcedures GetProcedures()
        {
            return Procedures;
        }

        protected void OnModelCreatingGeneratedProcedures(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<usp_RIT_getCustomersOrdersByDateMobileResult>().HasNoKey().ToView(null);
        }
    }

    public partial class rasdbContextProcedures : IrasdbContextProcedures
    {
        private readonly rasdbContext _context;

        public rasdbContextProcedures(rasdbContext context)
        {
            _context = context;
        }

        public virtual async Task<List<usp_RIT_getCustomersOrdersByDateMobileResult>> usp_RIT_getCustomersOrdersByDateMobileAsync(DateTime? order_date, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "order_date",
                    Value = order_date ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Date,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<usp_RIT_getCustomersOrdersByDateMobileResult>("EXEC @returnValue = [dbo].[usp_RIT_getCustomersOrdersByDateMobile] @order_date", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }
    }
}
