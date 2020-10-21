using CollectionViewDemo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CollectionViewDemo.ViewModel
{
    public class EmployeeDetailViewModel 
    {
        public ObservableCollection<EmployeeModel> EmployeeDetails { get; set; }
        public EmployeeDetailViewModel()
        {
            EmployeeDetails = new ObservableCollection<EmployeeModel>();
            EmployeeModel obj = new EmployeeModel();
            obj.FirstName = "Nirav";
            obj.LastName = "Tailor";
            obj.Email = "abc@gmail.com";
            obj.Country = "India";
            EmployeeDetails.Add(obj);

            obj = new EmployeeModel();
            obj.FirstName = "Sachin";
            obj.LastName = "Shinde";
            obj.Email = "abc@gmail.com";
            obj.Country = "India";
            EmployeeDetails.Add(obj);


            obj = new EmployeeModel();
            obj.FirstName = "Janani";
            obj.LastName = "Mistry";
            obj.Email = "abc@gmail.com";
            obj.Country = "India";
            EmployeeDetails.Add(obj);


            obj = new EmployeeModel();
            obj.FirstName = "Vishal";
            obj.LastName = "Makvana";
            obj.Email = "abc@gmail.com";
            obj.Country = "India";
            EmployeeDetails.Add(obj);


            obj = new EmployeeModel();
            obj.FirstName = "Ashwin";
            obj.LastName = "Mulay";
            obj.Email = "abc@gmail.com";
            obj.Country = "India";
            EmployeeDetails.Add(obj);


            obj = new EmployeeModel();
            obj.FirstName = "Viral";
            obj.LastName = "Mistry";
            obj.Email = "abc@gmail.com";
            obj.Country = "India";
            EmployeeDetails.Add(obj);


            obj = new EmployeeModel();
            obj.FirstName = "Krishna";
            obj.LastName = "Lad";
            obj.Email = "abc@gmail.com";
            obj.Country = "India";
            EmployeeDetails.Add(obj);

        }
    }
}
