using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook {
    class UserInterface {

        public int menu() {
            Console.WriteLine("메뉴를 선택해 주세요 ~ ");
            Console.WriteLine("1. 추가");
            Console.WriteLine("2. 검색");
            Console.WriteLine("3. 수정");
            Console.WriteLine("4. 삭제");
            Console.WriteLine("5. 종료");

            return int.Parse(Console.ReadLine());
        }

        public void add(Manager manager) {
            Console.WriteLine("추가할 연락처의 이름을 입력해주세요");
            String name = Console.ReadLine();

            Console.WriteLine("추가할 연락처를 입력해주세요");
            String phoneNumber = Console.ReadLine();

            Profile profile = new Profile(name, phoneNumber);

            manager.save(profile);
        }

        public void find(Manager manager) {
            Console.WriteLine("검색할 연락처의 이름을 입력해주세요");
            
            Profile profile= manager.find(Console.ReadLine());
            Console.WriteLine(profile);
        }

        public void change(Manager manager) {
            Console.WriteLine("수정할 연락처의 이름을 입력해주세요");
            String name = Console.ReadLine();
            Console.WriteLine("수정할 연락처를 입력해주세요");
            String phoneNumber = Console.ReadLine();

            manager.changeByPhoneNumber(name, phoneNumber);
        }

        public void remove(Manager manager) {
            Console.WriteLine("삭제할 연락처의 이름을 입력해주세요");
            manager.remove(Console.ReadLine());
        }
    }
}
