using FlightReservation.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation.DataAccess
{
    class CustomerDAO
    {

        public void createCustomer(Customer customer) {

            
            using (flight_reservationEntities db = new flight_reservationEntities())
            {
                db.Customers.AddOrUpdate(customer);
                db.SaveChanges();
            }

        }

        public Customer FindCustomerById(int id)
        {

            Customer customer;
            using (flight_reservationEntities db = new flight_reservationEntities())
            {
               customer = db.Customers.FirstOrDefault(c => c.id_customer==id);
            }

            return customer;
        }

        public void UpdateCustomerEmail(String oldEmail, String newEmail)
        {
           
            using (flight_reservationEntities db = new flight_reservationEntities())
            {
                Customer customer = db.Customers.FirstOrDefault(c => c.email == oldEmail);
                if (customer != null)
                {
                    customer.email = newEmail;
                    db.SaveChanges();
                }
            }

        }

        public void UpdateCustomerName(String oldName, String newName)
        {
            
            using (flight_reservationEntities db = new flight_reservationEntities())
            {
                Customer customer = db.Customers.FirstOrDefault(c => c.name == oldName);
                if (customer != null)
                {
                    customer.name = newName;
                    db.SaveChanges();
                }
            }

        }

        public void DeleteCustomerById(int id) {

            using (flight_reservationEntities db = new flight_reservationEntities())
            {
                Customer customer = db.Customers.FirstOrDefault(c => c.id_customer == id);
                if (customer != null)
                {
                    db.Customers.Remove(customer);
                    db.SaveChanges();
                }
            }

        }
    }
}
