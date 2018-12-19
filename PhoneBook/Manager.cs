using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook {
    class Manager {
        Dictionary<String, Profile> book = new Dictionary<String, Profile>();

        public void save(Profile profile) {
            book.Add(profile.name, profile);
        }

        public Profile find(String name) {
            Profile profile;
            book.TryGetValue(name, out profile);
            return profile;
        }

        public void changeByPhoneNumber(String name, String phoneNumber) {
            Profile profile = find(name);
            profile.phoneNumber = phoneNumber;
        }

        public void remove(String name) {
            book.Remove(name);
        }
    }
}
