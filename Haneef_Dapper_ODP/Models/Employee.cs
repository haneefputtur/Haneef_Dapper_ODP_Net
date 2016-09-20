using System.ComponentModel.DataAnnotations;

namespace Haneef_Dapper_ODP.Models
    {
    public class Employee
        {
        [Key]
        public string EMPLOYEE_ID { get; set; }
        public string EMPLOYEE_NAME { get; set; }
        public string EMPLOYEE_MOBILE { get; set; }
        public string EMPLOYEE_DEPARTMENT { get; set; }
        }
    }