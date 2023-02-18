using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiQuanLyQuancafe
{
    public  class  Information
    {
        private string account;
        private string password;
        private string name;
        private string  phonenumber;
        private string repassword;
        private string address;
        public string Account { get => account; set => account = value; }
        public string Password { get => password; set => password = value; }
        public string Repassword { get => repassword; set => repassword = value; }
        public string Name { get => name; set => name = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public string Address { get => address; set => address = value; }

        public Information(string name, string  phonenumber,string account,string password,string repassword)
        {
            this.name = name;
            this.phonenumber = phonenumber;
            this.account=account;
            this.password = password;
            this.repassword = repassword;
        }
        public Information()
        {

        }
        public string display(string x,string y)
        {
            return " Name: " + x + "Phonenumber:" + y;
        }
    }
}
