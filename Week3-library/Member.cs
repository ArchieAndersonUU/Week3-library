using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week3_library
{
    internal class Member
    {
        private int memberId;
        private string name;
        private string address;
        private int phone;

        public int MemberId
        {
            get { return memberId; }
            private set { memberId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public Member(int memberId, string name, string address, int phone)
        {
            this.MemberId = memberId;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book title: {ISBN}");
            
            Console.WriteLine();
        }
    }
}
