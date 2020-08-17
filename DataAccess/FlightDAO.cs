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
    class FlightDAO
    {

        public void createFlight(Flight flight)
        {


            using (flight_reservationEntities db = new flight_reservationEntities())
            {
                db.Flights.AddOrUpdate(flight);
                db.SaveChanges();
            }

        }

        public Flight FindFlightByNumber(int flightNumber)
        {

            Flight flight;
            using (flight_reservationEntities db = new flight_reservationEntities())
            {
                flight = db.Flights.FirstOrDefault(f => f.flight_number == flightNumber);
            }

            return flight;
        }


        public void UpdateFlightPrice(Flight fl, int newPrice)
        {
            Flight flight;
            using (flight_reservationEntities db = new flight_reservationEntities())
            {
               flight = db.Flights.FirstOrDefault(f => f.flight_number==fl.flight_number);
                if (flight != null)
                {
                    flight.price=newPrice;
                    db.SaveChanges();
                }
            }

        }
        public void UpdateFlightDuration(Flight fl, int newDuration)
        {
            Flight flight;
            using (flight_reservationEntities db = new flight_reservationEntities())
            {
                flight = db.Flights.FirstOrDefault(f => f.flight_number == fl.flight_number);
                if (flight != null)
                {
                    flight.duration = newDuration;
                    db.SaveChanges();
                }
            }

        }

        public void UpdateFlightTime(Flight fl, System.DateTime newTime)
        {
            Flight flight;
            using (flight_reservationEntities db = new flight_reservationEntities())
            {
                flight = db.Flights.FirstOrDefault(f => f.flight_number == fl.flight_number);
                if (flight != null)
                {
                    flight.flight_time= newTime;
                    db.SaveChanges();
                }
            }

        }

        public void DeleteFlightByNumber(int number)
        {

            using (flight_reservationEntities db = new flight_reservationEntities())
            {
                Flight flight = db.Flights.FirstOrDefault(f => f.flight_number==number);
                if (flight!= null)
                {
                    db.Flights.Remove(flight);
                    db.SaveChanges();
                }
            }

        }

    }
}
