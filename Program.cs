using FlightReservation.DataAccess;
using FlightReservation.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation
{
    class Program
    {
        static void Main(string[] args)
        {

            //using (flight_reservationEntities db = new flight_reservationEntities())
            //{
            //    Customer cust = db.Customers.FirstOrDefault(c => c.name == "Polly");
            //    //  Console.WriteLine(cust.name);
            //    // cust.name = "Polly";

            //    db.Customers.Remove(cust);
            //      db.SaveChanges();
            //}


               CustomerDAO cdao = new CustomerDAO();
            //cdao.createCustomer("Buciuman,);
            //  Customer c = cdao.FindCustomerById(5);
            // Console.WriteLine(c.name);

           //   cdao.UpdateCustomerName("Buciuman", "Paul");

            //    cdao.DeleteCustomerById(5);


            AirportDAO adao = new AirportDAO();


            //  Airport airport = new Airport(5, "BKK", "Thailand", "Bangkok");
            //  adao.createAirport(airport);

            // Airport airport = adao.FindAirportById(3);

            //  adao.DeleteAirportById(1);
            //  Console.WriteLine(airport.city);

            //  adao.UpdateAirportName("CJI", "CLJ");

            FlightDAO fdao = new FlightDAO();

            Flight flight = new Flight(3, 2, 3, 350, 3, DateTime.Now, "WizzAir");

        }
    }
}

Reinigung - a face curat 
Hinten - in spate
oben - sus
runta-jos

halbestunde - jumate de ora
bonnen ferleisen - sortare (pastai)

vanne - vana
graue - gri
gelbe - galben
rotte - rosu 
swarze - nergu 
greune - verde

gey-pauza
kleidung - imbracaminte

bad schutz - masca de barba
coph schutz - masca 
mantle - halat 

mus - trebuie 
schlauh - furtun
bodden - podea

  public Flight(Nullable<int> source_airport, Nullable<int> destination_airport, Nullable<double> price, Nullable<double> duration, Nullable<System.DateTime> flight_time, Nullable<System.TimeSpan> flight_hour, Nullable<int> company)
        {
            this.source_airport = source_airport;
            this.destination_airport = destination_airport;
            this.price = price;
            this.duration = duration;
            this.flight_time = flight_time;
            this.flight_hour = flight_hour;
            this.company = company;
        
        }
		
		public Airport(string name, string country, string city) {
            this.name = name;
            this.country = country;
            this.city = city;
        }
		
		   public Customer(string name, string email, string phone_number) {
            this.name = name;
            this.email = email;
            this.phone_number = phone_number;
        }

 public Reservation(Flight flight, Customer customer,string seat_number) {
            this.Flight1 = flight;
            this.Customer1 = customer;
            this.seat_number = seat_number;
        }







