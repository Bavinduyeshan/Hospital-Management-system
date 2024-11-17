using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public abstract class Person
    {
        /*
        private string patientid;
        private string fname;
        private string lname;
        private string nic;
        private string gender;
        private string address;
        private string email;
        private string civilstatus;
        private string occupation;
        private string contactno;
        private string date;
        private string doc_id;
        private string room_id;
        */
        public abstract void Add(SqlConnection conn);

        public abstract void Update(SqlConnection conn);

        public abstract void Delete(SqlConnection conn,int patientid);
    }
}
