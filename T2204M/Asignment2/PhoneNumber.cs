using System;

namespace T2204M.Asignment2
{
    public class PhoneNumber : Phone
    {
        private List<string> PhoneList;
        public PhoneNumber()
        {

        }


        public override void InsertPhone(string name, string phone)
        {
            PhoneList.Add(name);
            Console.WriteLine(name);
            PhoneList.Add(phone);   
            Console.WriteLine(phone);
        }

        public override void RemovePhone(string name)
        {
            throw new NotImplementedException();
        }

        public override PhoneNumber SearchPhone(string name)
        {
            throw new NotImplementedException();
        }

        public override void Sort()
        {
            throw new NotImplementedException();
        }

        public override void UpdatePhone(string name, string oldPhone, string newPhone)
        {
            throw new NotImplementedException();
        }
    }
}
