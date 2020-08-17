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
    class AirportDAO
    {

        public void createAirport(Airport airport)
        {


            using (flight_reservationEntities db = new flight_reservationEntities())
            {
                db.Airports.AddOrUpdate(airport);
                db.SaveChanges();
            }

        }

        public Airport FindAirportById(int id)
        {

            Airport airport;
            using (flight_reservationEntities db = new flight_reservationEntities())
            {
               airport = db.Airports.FirstOrDefault(a => a.id_airport == id);
            }

            return airport;
        }

        
        public void UpdateAirportName(String oldName, String newName)
        {
            Airport airport;
            using (flight_reservationEntities db = new flight_reservationEntities())
            {
                airport = db.Airports.FirstOrDefault(a => a.name == oldName);
                if (airport != null)
                {
                    airport.name = newName;
                    db.SaveChanges();
                }
            }

        }

        public void DeleteAirportById(int id)
        {

            using (flight_reservationEntities db = new flight_reservationEntities())
            {
                Airport airport = db.Airports.FirstOrDefault(a=>a.id_airport == id);
                if (airport != null)
                {
                    db.Airports.Remove(airport);
                    db.SaveChanges();
                }
            }

        }

        public void DeleteAirportByName(String name)
        {

            using (flight_reservationEntities db = new flight_reservationEntities())
            {
                Airport airport = db.Airports.FirstOrDefault(a => a.name == name);
                if (airport != null)
                {
                    db.Airports.Remove(airport);
                    db.SaveChanges();
                }
            }

        }

    }
}
