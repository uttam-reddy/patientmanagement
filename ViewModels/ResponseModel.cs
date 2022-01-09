using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientManagement.ViewModels
{
    public class ResponseModel<T>
    {
        public string Token { get; set; }

        public bool status { get; set; }

        public List<string> ReturnMessage { get; set; }

        public Hashtable Errors { get; set; }

        public int TotalPages { get; set; }
        public int TotalRows { get; set; }

        public int Pagesize { get; set; }

        public T Entity { get; set; }
        public Boolean IsAuthenticated { get; set; }
        public ResponseModel()
        {
            ReturnMessage = new List<string>();
            status = true;
            Errors = new Hashtable();
            TotalPages = 0;
            TotalRows = 0;
            Pagesize = 0;
            IsAuthenticated = false;
        }


    }
}
