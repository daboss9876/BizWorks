﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizWorks
{
    public class UserEmployeeAddressCollection
    {
        private static List<Address> EmployeeAddressList = new List<Address>();

        public static void addUserAddress1(string profileName, string addressStreet,
            string addressCity, string addressState,
            int addressZipCode, DateTime createdOn,
            string createdBy, DateTime lastUpdatedOn, string lastUpdatedBy,
            string notes)
        {
            EmployeeAddressList.Add(new Address(profileName, addressStreet,
                addressCity, addressState, addressZipCode, createdOn,
                createdBy, lastUpdatedOn, lastUpdatedBy, notes));
        }

        public static void ModifyUserAddress1(string profileName, string addressStreet,
            string addressCity, string addressState,
            int addressZipCode, DateTime createdOn,
            string createdBy, DateTime lastUpdatedOn, string lastUpdatedBy,
            string notes)
        {
            foreach (var element in EmployeeAddressList
                .Where(element => element.UserProfileName == profileName))
            {
                element.UserAddressStreet = addressStreet;
                element.UserAddressCity = addressCity;
                element.UserAddressState = addressState;
                element.UserAddressZipCode = addressZipCode;
                element.UserCreatedOn = createdOn;
                element.UserCreatedBy = createdBy;
                element.UserLastUpdatedOn = lastUpdatedOn;
                element.UserLastUpdatedBy = lastUpdatedBy;
                element.UserNotes = notes;
            } 
        }

        public static string GetStreet1(string passedUsername)
        {
            string x = "";
            var query =
                from employee in EmployeeAddressList
                where employee.UserProfileName == passedUsername
                select employee.UserAddressStreet;
            foreach (var item in query)
            {
                x = item;
            }
            return x;
        }
        public static string GetCity1(string passedUsername)
        {
            string x = "";
            var query =
                from employee in EmployeeAddressList
                where employee.UserProfileName == passedUsername
                select employee.UserAddressCity;
            foreach (var item in query)
            {
                x = item;
            }
            return x;
        }
        public static string GetState1(string passedUsername)
        {
            string x = "";
            var query =
                from employee in EmployeeAddressList
                where employee.UserProfileName == passedUsername
                select employee.UserAddressState;
            foreach (var item in query)
            {
                x = item;
            }
            return x;
        }
        public static int GetZipCode1(string passedUsername)
        {
            int x = 0;
            var query =
                from employee in EmployeeAddressList
                where employee.UserProfileName == passedUsername
                select employee.UserAddressZipCode;
            foreach(var item in query)
            {
                x = item;
            }
            return x;
        }
        public static string GetNotes1(string passedUsername)
        {
            string x = "";
            var query =
                from employee in EmployeeAddressList
                where employee.UserProfileName == passedUsername
                select employee.UserNotes;
            foreach (var item in query)
            {
                x = item;
            }
            return x;
        }
        public static string GetCreatedBy(string username)
        {
            string x = "";
            var query =
                from employee in EmployeeAddressList
                where employee.UserProfileName == username
                select employee.UserCreatedBy;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static DateTime GetCreatedByDate(string username)
        {
            DateTime x = new DateTime();
            var query =
                from employee in EmployeeAddressList
                where employee.UserProfileName == username
                select employee.UserCreatedOn;
            foreach (var item in query) { x = item; }
            return x;
        }

    }
}
