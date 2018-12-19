using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook {
    class Program {
        static void Main(string[] args) {
            UserInterface userInterface = new UserInterface();
            Manager manager = new Manager();
            while (true) {
                switch (userInterface.menu()) {
                    case 1:
                        userInterface.add(manager);
                        break;
                    case 2:
                        userInterface.find(manager);
                        break;
                    case 3:
                        userInterface.change(manager);
                        break;
                    case 4:
                        userInterface.remove(manager);
                        break;
                    case 5:
                        return;
                    default:
                        break;

                } 
            }
        }
    }
}
