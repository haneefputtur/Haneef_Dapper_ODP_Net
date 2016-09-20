using Dapper;
using Haneef_Dapper_ODP.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Haneef_Dapper_ODP.Utilities
    {
    public class function
        {

         public static List<Employee> emp_list(string pdept)
            {
            var p = new OracleDynamicParameters();

            p.Add("p_dept", pdept);
            p.Add("p_emp_list", dbType: OracleDbType.RefCursor, direction: ParameterDirection.Output);



            var emplist = new List<Employee>();
            try
                {
                using (SqlMapper.GridReader gr = DB.GetMultiGrid("HPUTTUR.EMP.p_EMPLOYEE", p))
                    {

                    emplist = gr.Read<Employee>().ToList<Employee>();


                    }
                }
            catch (Exception e)
                {

                }
            return emplist;

            }
        }
        }
 