using criandoExcecoesPersonalizadas.Entities;
using criandoExcecoesPersonalizadas.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criandoExcecoesPersonalizadas {
    class Program {
        static void Main(string[] args) {

            try {
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine("\nEnter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.updateDates(checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);

            } catch (DomainException e) {
                Console.WriteLine("Error in reservation: " + e.Message);
            } catch (FormatException e) {
                Console.WriteLine("Fromat error: " + e.Message);
            } catch (Exception e) {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}