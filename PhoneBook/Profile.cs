using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook {
    class Profile {
       public String name;
       public String phoneNumber;

        public Profile(String name, String phoneNumber) {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }
        public override string ToString() {
            return $"이름: { this.name}\n전화번호 : {this.phoneNumber}";  
        }
    }
}
